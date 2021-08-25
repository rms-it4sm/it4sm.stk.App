Ext.define('B4.controller.ObjectsTypesEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'ObjectsTypesEditorModel'],
    views: [
        'ObjectsTypesEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.ObjectsTypesEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-objectstypeseditor',
    viewUid: '88f43eeb-7601-4451-bc70-14cfe8179b08',
    viewDataModel: 'ObjectsTypesEditorModel',
    viewDataController: 'ObjectsTypesEditor',
    viewDataName: 'ObjectsTypesEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.TypesWorkTypesObjectsList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Виды работ.Тип объекта
        element = form.down('[name=TypesWorkTypesObjectsList]');
        ctrl = me.getController('B4.controller.TypesWorkTypesObjectsList');
        element.data.set('ObjectType_Id', rec.get('Id') || 0);
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
            form.grid_TypesWorkTypesObjectsList.disableGrid();
        } else {
            form.grid_TypesWorkTypesObjectsList.enable();
            form.grid_TypesWorkTypesObjectsList.loadData(true);
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
        // Виды работ.Тип объекта
        element = view.down('[name=TypesWorkTypesObjectsList]');
        ctrl = me.getController('B4.controller.TypesWorkTypesObjectsList');
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