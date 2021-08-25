Ext.define('B4.controller.CurrentPositionsDepartmentsEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'CurrentPositionsDepartmentsEditorModel'],
    views: [
        'CurrentPositionsDepartmentsEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.CurrentPositionsDepartmentsEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-currentpositionsdepartmentseditor',
    viewUid: '5384176d-011e-4051-a1ad-61487308dd00',
    viewDataModel: 'CurrentPositionsDepartmentsEditorModel',
    viewDataController: 'CurrentPositionsDepartmentsEditor',
    viewDataName: 'CurrentPositionsDepartmentsEditor',
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
        if (!Ext.isEmpty(ctxParams['DepartmentPosition_Id'])) {
            this.preventFieldInput(form, ['[name=DepartmentPosition]']);
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