Ext.define('B4.controller.ObjectsOrdersListMultiAddByZakazEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'ObjectsOrdersListMultiAddByZakazEditorModel'],
    views: [
        'ObjectsOrdersListMultiAddByZakazEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.ObjectsOrdersListMultiAddByZakazEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-objectsorderslistmultiaddbyzakazeditor',
    viewUid: '4be82f55-200d-54ab-7f7d-a49288cbd00e',
    viewDataModel: 'ObjectsOrdersListMultiAddByZakazEditorModel',
    viewDataController: 'ObjectsOrdersListMultiAddByZakazEditor',
    viewDataName: 'ObjectsOrdersListMultiAddByZakazEditor',
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-objectsorderslistmultiaddbyzakazeditor': {
                'onBeforeSaveRecord': me.on_rms_objectsorderslistmultiaddbyzakazeditor_on_before_save_record
            }
        });
        me.control({
            scope: me,
            'rms-objectsorderslistmultiaddbyzakazeditor b4pickerfield[name=Zakaz]': {
                'change': me.on_rms_objectsorderslistmultiaddbyzakazeditorb4pickerfield_name_zakaz_change
            }
        });
        me.callParent(arguments);
        this.initControllers(['B4.controller.OrdersObjectsList2']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Объекты
        element = form.down('[name=OrdersObjectsList2]');
        ctrl = me.getController('B4.controller.OrdersObjectsList2');
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
    },
    onSetViewData: function(record, form) {
        var me = this,
            element = null,
            ctrl = null,
            model = null,
            isNewRecord = Ext.isEmpty(record.get('Id')) || record.get('Id') == 0,
            isMultiAdd = true,
            isMultiLink = false;
        // получаем параметры контекста
        var ctxParams = form.data.getValues();
        // если в текущем контексте контроллера переданы идентификаторы
        // ссылочных полей, то необходимо передать их в параметрах операции 
        // и скрыть столбцы, отображающие поля ссылок
        if (!Ext.isEmpty(ctxParams['Zakaz_Id'])) {
            this.preventFieldInput(form, ['[name=Zakaz]']);
        }
        if (!Ext.isEmpty(ctxParams['Object_Id'])) {
            this.preventFieldInput(form, ['[name=Object]']);
        }
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_OrdersObjectsList2.enable();
            form.grid_OrdersObjectsList2.loadData(true);
        } else {
            form.grid_OrdersObjectsList2.enable();
            form.grid_OrdersObjectsList2.loadData(true);
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
        // Объекты
        element = view.down('[name=OrdersObjectsList2]');
        ctrl = me.getController('B4.controller.OrdersObjectsList2');
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
    on_rms_objectsorderslistmultiaddbyzakazeditor_on_before_save_record: function(form) {
        var grid = form.down('gridpanel');
        grid && grid.getSelectionModel && grid.getSelectionModel().deselectAll();
    },
    on_rms_objectsorderslistmultiaddbyzakazeditorb4pickerfield_name_zakaz_change: function(field, value, eOpts) {
        var view = field.up('rms-objectsorderslistmultiaddbyzakazeditor');
        var registry = view && view.down('[modelProperty=ObjectsOrders_Object_Registry]');
        if (registry) {
            if (registry.is('treepanel')) {
                registry.on('load', function(sender, store, records, successful, eOpts) {
                    registry.store.getRootNode().cascadeBy(function(node) {
                        node.set({
                            checked: false
                        });
                    });
                });
            };
            registry.loadData(true);
        }
    }
});