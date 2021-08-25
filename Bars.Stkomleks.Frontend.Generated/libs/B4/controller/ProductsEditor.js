Ext.define('B4.controller.ProductsEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'ProductsEditorModel'],
    views: [
        'ProductsEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.ProductsEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-productseditor',
    viewUid: '153ded49-b5ae-4c43-bdb2-a835368c2cf2',
    viewDataModel: 'ProductsEditorModel',
    viewDataController: 'ProductsEditor',
    viewDataName: 'ProductsEditor',
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
        if (!Ext.isEmpty(ctxParams['ObjectSpecification_Id'])) {
            this.preventFieldInput(form, ['[name=ObjectSpecification]']);
        }
        if (!Ext.isEmpty(ctxParams['Supplier_Id'])) {
            this.preventFieldInput(form, ['[name=Supplier]']);
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