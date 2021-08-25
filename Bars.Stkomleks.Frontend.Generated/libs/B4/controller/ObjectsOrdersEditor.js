Ext.define('B4.controller.ObjectsOrdersEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'ObjectsOrdersEditorModel'],
    views: [
        'ObjectsOrdersEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.ObjectsOrdersEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-objectsorderseditor',
    viewUid: '6185abdb-13fa-4e36-a62b-20d4a979c7ec',
    viewDataModel: 'ObjectsOrdersEditorModel',
    viewDataController: 'ObjectsOrdersEditor',
    viewDataName: 'ObjectsOrdersEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.OrdersObjectsEditor']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Объект.Создание
        element = form.down('rms-ordersobjectseditor[modelProperty=ObjectsOrders_Object]');
        ctrl = me.getController('B4.controller.OrdersObjectsEditor');
        model = ctrl.getModel(ctrl.viewDataModel).create(rec.get('Object'));
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(model, element);
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
        // Объект.Создание
        element = form.down('rms-ordersobjectseditor[modelProperty=ObjectsOrders_Object]');
        ctrl = me.getController('B4.controller.OrdersObjectsEditor');
        model = ctrl.getModel(ctrl.viewDataModel).create(record.get('Object'));
        ctrl.onSetViewData(model, element);
    },
    onViewConnected: function(view) {
        this.callParent(arguments);
        var me = this,
            element = null,
            ctrl = null;
        // при привязке представления к контроллеру  необходимо обойти 
        // список вложенных представлений (реестров, редакторов и т.д.)
        // и привязать их к их контроллерам
        // Объект.Создание
        element = view.down('rms-ordersobjectseditor[modelProperty=ObjectsOrders_Object]');
        ctrl = me.getController('B4.controller.OrdersObjectsEditor');
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
        // Объект.Создание
        element = view.down('rms-ordersobjectseditor[modelProperty=ObjectsOrders_Object]');
        ctrl = me.getController('B4.controller.OrdersObjectsEditor');
        model = ctrl.getModel(ctrl.viewDataModel).create(record.get('Object'));
        ctrl.onViewDeployed(element, model);
        if (view.isReadOnly) {
            view.setReadOnly();
        }
    },
});