Ext.define('B4.controller.OrganizationEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'OrganizationEditorModel'],
    views: [
        'OrganizationEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.aspects.StateButton',
        'B4.view.OrganizationEditor'],
    aspects: [{
        'listeners': {
            transfersuccess: function(asp, entityId, newState) {
                var ctrl = asp.controller;
                var view = ctrl.getMainView();
                // получаем данные редактора
                var viewData = view.data.getValues();
                // фомирование параметров загрузки данных
                var loadParams = {
                    rec: entityId,
                    ctxParams: viewData,
                    onFailure: function(p) {},
                    callback: function(record) {
                        // установка зависимых от данных переменных представления
                        ctrl.setViewData(record, view);
                        //вызываем обработчик события если он присутствует в контролере
                        if (Ext.isFunction(ctrl.onViewDeployed)) ctrl.onViewDeployed.call(ctrl, view, record);
                    }
                };
                // загружаем запись с сервера
                ctrl.loadRecord(loadParams);
            }
        },
        'stateButtonSelector': '#btnState',
        'xtype': 'statebuttonaspect'
    }, {
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-organizationeditor',
    viewUid: '7bfd891d-f74e-48c4-9141-e68896e91cc3',
    viewDataModel: 'OrganizationEditorModel',
    viewDataController: 'OrganizationEditor',
    viewDataName: 'OrganizationEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.OrganizationContactsList', 'B4.controller.DepartmentsList', 'B4.controller.StaffList', 'B4.controller.OrganizationFundingProgramsList', 'B4.controller.OrganizationProfilesList', 'B4.controller.RelatedOrganizationsList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Контакты.Организация
        element = form.down('[name=OrganizationContactsList]');
        ctrl = me.getController('B4.controller.OrganizationContactsList');
        element.data.set('Organization_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Подразделения.Организация
        element = form.down('[name=DepartmentsList]');
        ctrl = me.getController('B4.controller.DepartmentsList');
        element.data.set('Organization_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Сотрудники.Организация
        element = form.down('[name=StaffList]');
        ctrl = me.getController('B4.controller.StaffList');
        element.data.set('Organization_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Программы.Организация
        element = form.down('[name=OrganizationFundingProgramsList]');
        ctrl = me.getController('B4.controller.OrganizationFundingProgramsList');
        element.data.set('Organization_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Профили.Организация
        element = form.down('[name=OrganizationProfilesList]');
        ctrl = me.getController('B4.controller.OrganizationProfilesList');
        element.data.set('Organization_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Связанные организации.Организация
        element = form.down('[name=RelatedOrganizationsList]');
        ctrl = me.getController('B4.controller.RelatedOrganizationsList');
        element.data.set('Organization_Id', rec.get('Id') || 0);
        element.data.set('RelatedOrg_Id', rec.get('Id') || 0);
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
        this.aspectCollection.each(function(aspect) {
            if (aspect && aspect.xtype == 'statebuttonaspect') {
                var selectedState = record.get('_State');
                if (selectedState) {
                    selectedState.TypeId = 'bars.stkomleks.organization';
                    aspect.setStateData(record.get('Id'), selectedState);
                }
            }
        }, this);
        // получаем параметры контекста
        var ctxParams = form.data.getValues();
        // если в текущем контексте контроллера переданы идентификаторы
        // ссылочных полей, то необходимо передать их в параметрах операции 
        // и скрыть столбцы, отображающие поля ссылок
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_OrganizationContactsList.disableGrid();
            form.grid_DepartmentsList.disableGrid();
            form.grid_StaffList.disableGrid();
            form.grid_OrganizationFundingProgramsList.disableGrid();
            form.grid_OrganizationProfilesList.disableGrid();
            form.grid_RelatedOrganizationsList.disableGrid();
        } else {
            form.grid_OrganizationContactsList.enable();
            form.grid_OrganizationContactsList.loadData(true);
            form.grid_DepartmentsList.enable();
            form.grid_DepartmentsList.loadData(true);
            form.grid_StaffList.enable();
            form.grid_StaffList.loadData(true);
            form.grid_OrganizationFundingProgramsList.enable();
            form.grid_OrganizationFundingProgramsList.loadData(true);
            form.grid_OrganizationProfilesList.enable();
            form.grid_OrganizationProfilesList.loadData(true);
            form.grid_RelatedOrganizationsList.enable();
            form.grid_RelatedOrganizationsList.loadData(true);
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
        // Контакты.Организация
        element = view.down('[name=OrganizationContactsList]');
        ctrl = me.getController('B4.controller.OrganizationContactsList');
        ctrl.connectView(element, view.ctxKey);
        // Подразделения.Организация
        element = view.down('[name=DepartmentsList]');
        ctrl = me.getController('B4.controller.DepartmentsList');
        ctrl.connectView(element, view.ctxKey);
        // Сотрудники.Организация
        element = view.down('[name=StaffList]');
        ctrl = me.getController('B4.controller.StaffList');
        ctrl.connectView(element, view.ctxKey);
        // Программы.Организация
        element = view.down('[name=OrganizationFundingProgramsList]');
        ctrl = me.getController('B4.controller.OrganizationFundingProgramsList');
        ctrl.connectView(element, view.ctxKey);
        // Профили.Организация
        element = view.down('[name=OrganizationProfilesList]');
        ctrl = me.getController('B4.controller.OrganizationProfilesList');
        ctrl.connectView(element, view.ctxKey);
        // Связанные организации.Организация
        element = view.down('[name=RelatedOrganizationsList]');
        ctrl = me.getController('B4.controller.RelatedOrganizationsList');
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