Ext.define('B4.controller.CompositionObjectSpecialistsEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'CompositionObjectSpecialistsEditorModel'],
    views: [
        'CompositionObjectSpecialistsEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.CompositionObjectSpecialistsEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-compositionobjectspecialistseditor',
    viewUid: '77a6afbc-c73b-4ee9-af30-3fa36d6a8a37',
    viewDataModel: 'CompositionObjectSpecialistsEditorModel',
    viewDataController: 'CompositionObjectSpecialistsEditor',
    viewDataName: 'CompositionObjectSpecialistsEditor',
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
        if (!Ext.isEmpty(ctxParams['Object_Id'])) {
            this.preventFieldInput(form, ['[name=Object]']);
        }
        if (!Ext.isEmpty(ctxParams['Role_Id'])) {
            this.preventFieldInput(form, ['[name=Role]']);
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