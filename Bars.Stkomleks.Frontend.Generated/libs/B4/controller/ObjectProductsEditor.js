Ext.define('B4.controller.ObjectProductsEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'ObjectProductsEditorModel'],
    views: [
        'ObjectProductsEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.ObjectProductsEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-objectproductseditor',
    viewUid: '59e2e72a-5563-4787-bd22-7bdb89882368',
    viewDataModel: 'ObjectProductsEditorModel',
    viewDataController: 'ObjectProductsEditor',
    viewDataName: 'ObjectProductsEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.ProductsList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Комплектация.Элемент спецификации
        element = form.down('[name=ProductsList]');
        ctrl = me.getController('B4.controller.ProductsList');
        element.data.set('ObjectSpecification_Id', rec.get('Id') || 0);
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
        if (!Ext.isEmpty(ctxParams['ObjectOrder_Id'])) {
            this.preventFieldInput(form, ['[name=ObjectOrder]']);
        }
        if (!Ext.isEmpty(ctxParams['TypeElement_Id'])) {
            this.preventFieldInput(form, ['[name=TypeElement]']);
        }
        if (!Ext.isEmpty(ctxParams['UnitMeasure_Id'])) {
            this.preventFieldInput(form, ['[name=UnitMeasure]']);
        }
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_ProductsList.disableGrid();
        } else {
            form.grid_ProductsList.enable();
            form.grid_ProductsList.loadData(true);
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
        // Комплектация.Элемент спецификации
        element = view.down('[name=ProductsList]');
        ctrl = me.getController('B4.controller.ProductsList');
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