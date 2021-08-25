Ext.define('B4.controller.OrdersEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'OrdersEditorModel'],
    views: [
        'OrdersEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.aspects.StateButton',
        'B4.view.OrdersEditor'],
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
    viewAlias: 'rms-orderseditor',
    viewUid: 'b3d0c6e3-6410-4c8b-b359-da6efc0248e9',
    viewDataModel: 'OrdersEditorModel',
    viewDataController: 'OrdersEditor',
    viewDataName: 'OrdersEditor',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.ObjectsOrdersList', 'B4.controller.OrderOrganizationList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Объекты.Заказа
        element = form.down('[name=ObjectsOrdersList]');
        ctrl = me.getController('B4.controller.ObjectsOrdersList');
        element.data.set('Zakaz_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Организации.Заказ
        element = form.down('[name=OrderOrganizationList]');
        ctrl = me.getController('B4.controller.OrderOrganizationList');
        element.data.set('Zakaz_Id', rec.get('Id') || 0);
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
                    selectedState.TypeId = 'bars.stkomleks.zakaz';
                    aspect.setStateData(record.get('Id'), selectedState);
                }
            }
        }, this);
        // получаем параметры контекста
        var ctxParams = form.data.getValues();
        // если в текущем контексте контроллера переданы идентификаторы
        // ссылочных полей, то необходимо передать их в параметрах операции 
        // и скрыть столбцы, отображающие поля ссылок
        if (!Ext.isEmpty(ctxParams['Client_Id'])) {
            this.preventFieldInput(form, ['[name=Client]']);
        }
        if (!Ext.isEmpty(ctxParams['Manager_Id'])) {
            this.preventFieldInput(form, ['[name=Manager]']);
        }
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_ObjectsOrdersList.disableGrid();
            form.grid_OrderOrganizationList.disableGrid();
        } else {
            form.grid_ObjectsOrdersList.enable();
            form.grid_ObjectsOrdersList.loadData(true);
            form.grid_OrderOrganizationList.enable();
            form.grid_OrderOrganizationList.loadData(true);
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
        // Объекты.Заказа
        element = view.down('[name=ObjectsOrdersList]');
        ctrl = me.getController('B4.controller.ObjectsOrdersList');
        ctrl.connectView(element, view.ctxKey);
        // Организации.Заказ
        element = view.down('[name=OrderOrganizationList]');
        ctrl = me.getController('B4.controller.OrderOrganizationList');
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