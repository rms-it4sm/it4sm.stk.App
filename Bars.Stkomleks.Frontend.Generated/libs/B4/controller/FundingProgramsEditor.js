Ext.define('B4.controller.FundingProgramsEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'FundingProgramsEditorModel'],
    views: [
        'FundingProgramsEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.FundingProgramsEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-fundingprogramseditor',
    viewUid: 'b26c9636-0eb1-412a-be11-c01993a415e2',
    viewDataModel: 'FundingProgramsEditorModel',
    viewDataController: 'FundingProgramsEditor',
    viewDataName: 'FundingProgramsEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.OrganizationFundingProgramsList2']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Оганизации.Программа финансирования
        element = form.down('[name=OrganizationFundingProgramsList2]');
        ctrl = me.getController('B4.controller.OrganizationFundingProgramsList2');
        element.data.set('FundingPrograms_Id', rec.get('Id') || 0);
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
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_OrganizationFundingProgramsList2.disableGrid();
        } else {
            form.grid_OrganizationFundingProgramsList2.enable();
            form.grid_OrganizationFundingProgramsList2.loadData(true);
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
        // Оганизации.Программа финансирования
        element = view.down('[name=OrganizationFundingProgramsList2]');
        ctrl = me.getController('B4.controller.OrganizationFundingProgramsList2');
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