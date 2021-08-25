Ext.define('B4.controller.DepartmentsPositionsEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'DepartmentsPositionsEditorModel'],
    views: [
        'DepartmentsPositionsEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.DepartmentsPositionsEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-departmentspositionseditor',
    viewUid: '23beb68e-9c91-43c1-a435-257bf4e15d1b',
    viewDataModel: 'DepartmentsPositionsEditorModel',
    viewDataController: 'DepartmentsPositionsEditor',
    viewDataName: 'DepartmentsPositionsEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.CurrentPositionsDepartmentsList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Занимаемые должности.Подразделение
        element = form.down('[name=CurrentPositionsDepartmentsList]');
        ctrl = me.getController('B4.controller.CurrentPositionsDepartmentsList');
        element.data.set('DepartmentPosition_Id', rec.get('Id') || 0);
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
        if (!Ext.isEmpty(ctxParams['Department_Id'])) {
            this.preventFieldInput(form, ['[name=Department]']);
        }
        if (!Ext.isEmpty(ctxParams['Type_Id'])) {
            this.preventFieldInput(form, ['[name=Type]']);
        }
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_CurrentPositionsDepartmentsList.disableGrid();
        } else {
            form.grid_CurrentPositionsDepartmentsList.enable();
            form.grid_CurrentPositionsDepartmentsList.loadData(true);
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
        // Занимаемые должности.Подразделение
        element = view.down('[name=CurrentPositionsDepartmentsList]');
        ctrl = me.getController('B4.controller.CurrentPositionsDepartmentsList');
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