Ext.define('B4.controller.DepartmentsEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'DepartmentsEditorModel'],
    views: [
        'DepartmentsEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.DepartmentsEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-departmentseditor',
    viewUid: '130c4db5-a9b3-4c6f-b37e-01182825968c',
    viewDataModel: 'DepartmentsEditorModel',
    viewDataController: 'DepartmentsEditor',
    viewDataName: 'DepartmentsEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.DepartmentsPositionsList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Должности.Подразделение
        element = form.down('[name=DepartmentsPositionsList]');
        ctrl = me.getController('B4.controller.DepartmentsPositionsList');
        element.data.set('Department_Id', rec.get('Id') || 0);
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
        if (!Ext.isEmpty(ctxParams['Organization_Id'])) {
            this.preventFieldInput(form, ['[name=Organization]']);
        }
        if (!Ext.isEmpty(ctxParams['Type_Id'])) {
            this.preventFieldInput(form, ['[name=Type]']);
        }
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_DepartmentsPositionsList.disableGrid();
        } else {
            form.grid_DepartmentsPositionsList.enable();
            form.grid_DepartmentsPositionsList.loadData(true);
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
        // Должности.Подразделение
        element = view.down('[name=DepartmentsPositionsList]');
        ctrl = me.getController('B4.controller.DepartmentsPositionsList');
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