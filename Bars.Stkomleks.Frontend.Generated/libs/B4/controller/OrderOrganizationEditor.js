Ext.define('B4.controller.OrderOrganizationEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'OrderOrganizationEditorModel'],
    views: [
        'OrderOrganizationEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.OrderOrganizationEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-orderorganizationeditor',
    viewUid: '51b898b7-bab8-4c73-b0d3-856ce114d842',
    viewDataModel: 'OrderOrganizationEditorModel',
    viewDataController: 'OrderOrganizationEditor',
    viewDataName: 'OrderOrganizationEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.ResponsiblePersonsOrderList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Ответственные лица. Организация заказа
        element = form.down('[name=ResponsiblePersonsOrderList]');
        ctrl = me.getController('B4.controller.ResponsiblePersonsOrderList');
        element.data.set('OrderOrganization_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
    },
    onSetViewData: function(record, form) {
        var me = this,
            element = null,
            ctrl = null,
            model = null,
            isNewRecord = Ext.isEmpty(record.get('Id')) || record.get('Id') == 0,
            isMultiAdd = false,
            isMultiLink = false;
        // получаем параметры контекста
        var ctxParams = form.data.getValues();
        // если в текущем контексте контроллера переданы идентификаторы
        // ссылочных полей, то необходимо передать их в параметрах операции 
        // и скрыть столбцы, отображающие поля ссылок
        if (!Ext.isEmpty(ctxParams['Zakaz_Id'])) {
            this.preventFieldInput(form, ['[name=Zakaz]']);
        }
        if (!Ext.isEmpty(ctxParams['Profile_Id'])) {
            this.preventFieldInput(form, ['[name=Profile]']);
        }
        if (!Ext.isEmpty(ctxParams['Organization_Id'])) {
            this.preventFieldInput(form, ['[name=Organization]']);
        }
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_ResponsiblePersonsOrderList.disableGrid();
        } else {
            form.grid_ResponsiblePersonsOrderList.enable();
            form.grid_ResponsiblePersonsOrderList.loadData(true);
        }
    },
    onViewConnected: function(view) {
        this.callParent(arguments);
        var me = this,
            element = null,
            ctrl = null;
        // при привязке представления к контроллеру  необходимо обойти 
        // список вложенных представлений (реестров, редакторов и т.д.)
        // и привязать их к их контроллерам
        // Ответственные лица. Организация заказа
        element = view.down('[name=ResponsiblePersonsOrderList]');
        ctrl = me.getController('B4.controller.ResponsiblePersonsOrderList');
        ctrl.connectView(element, view.ctxKey);
    },
    onViewDeployed: function(view, record) {
        this.callParent(arguments);
        var me = this,
            element = null,
            ctrl = null,
            model = null,
            isNewRecord = Ext.isEmpty(record.get('Id')) || record.get('Id') == 0;
        // после размещения представления необходимо обойти 
        // список вложенных представлений (реестров, редакторов и т.д.)
        // и выполнить допонительные методы инициализации
        // в данный момент параметры контекста заданы, 
        // компоненты созданы и отрендерены	
        if (view.isReadOnly) {
            view.setReadOnly();
        }
    },
});