Ext.define('B4.controller.ResponsiblePersonsOrderEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'ResponsiblePersonsOrderEditorModel'],
    views: [
        'ResponsiblePersonsOrderEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.ResponsiblePersonsOrderEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-responsiblepersonsordereditor',
    viewUid: '67d498ae-2835-45e6-972f-62b96a4979aa',
    viewDataModel: 'ResponsiblePersonsOrderEditorModel',
    viewDataController: 'ResponsiblePersonsOrderEditor',
    viewDataName: 'ResponsiblePersonsOrderEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
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
        if (!Ext.isEmpty(ctxParams['OrderOrganization_Id'])) {
            this.preventFieldInput(form, ['[name=OrderOrganization]']);
        }
        if (!Ext.isEmpty(ctxParams['Staff_Id'])) {
            this.preventFieldInput(form, ['[name=Staff]']);
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