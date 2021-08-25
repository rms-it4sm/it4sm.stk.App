Ext.define('B4.controller.OrdersObjectsEditor_Copy_0', {
    extend: 'B4.base.form.Controller',
    models: [
        'OrdersObjectsEditor_Copy_0Model'],
    views: [
        'OrdersObjectsEditor_Copy_0'],
    requires: [
        'B4.aspects.Permission',
        'B4.aspects.StateButton',
        'B4.view.OrdersObjectsEditor_Copy_0'],
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
    viewAlias: 'rms-ordersobjectseditor_copy_0',
    viewUid: 'd0c2a2f2-1963-47b7-8908-491cb7e146fb',
    viewDataModel: 'OrdersObjectsEditor_Copy_0Model',
    viewDataController: 'OrdersObjectsEditor_Copy_0',
    viewDataName: 'OrdersObjectsEditor_Copy_0',
    init: function() {
        var me = this;
        me.callParent(arguments);
        this.initControllers(['B4.controller.OrdersObjectsEditor', 'B4.controller.ObjectsOrdersList2', 'B4.controller.ObjectProductsList', 'B4.controller.CompositionObjectSpecialistsList', 'B4.controller.CompositionWorksObjectsList', 'B4.controller.ObjectsDocumentsList']);
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
        element = form.down('[rmsUid=7ac403e4-faf4-4360-9f50-df22ba53258b]');
        ctrl = me.getController('B4.controller.OrdersObjectsEditor');
        model = ctrl.getModel(ctrl.viewDataModel).create(rec.get('OrdersObjectsEditor'));
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(model, element);
        // Заказы.Объект
        element = form.down('[name=ObjectsOrdersList2]');
        ctrl = me.getController('B4.controller.ObjectsOrdersList2');
        element.data.set('Object_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Спецификация.Объект
        element = form.down('[name=ObjectProductsList]');
        ctrl = me.getController('B4.controller.ObjectProductsList');
        element.data.set('ObjectOrder_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Специалисты.Объект
        element = form.down('[name=CompositionObjectSpecialistsList]');
        ctrl = me.getController('B4.controller.CompositionObjectSpecialistsList');
        element.data.set('Object_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Работы.Объект
        element = form.down('[name=CompositionWorksObjectsList]');
        ctrl = me.getController('B4.controller.CompositionWorksObjectsList');
        element.data.set('ObjectWork_Id', rec.get('Id') || 0);
        element.context && element.context.applyIf(_editorCtxValues);
        ctrl.applyCtxValues(element);
        // Документы.Объект
        element = form.down('[name=ObjectsDocumentsList]');
        ctrl = me.getController('B4.controller.ObjectsDocumentsList');
        element.data.set('ObjectWork_Id', rec.get('Id') || 0);
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
                    selectedState.TypeId = 'bars.stkomleks.ordersobjects';
                    aspect.setStateData(record.get('Id'), selectedState);
                }
            }
        }, this);
        // получаем параметры контекста
        var ctxParams = form.data.getValues();
        // если в текущем контексте контроллера переданы идентификаторы
        // ссылочных полей, то необходимо передать их в параметрах операции 
        // и скрыть столбцы, отображающие поля ссылок
        // Объект.Создание
        element = form.down('[rmsUid=7ac403e4-faf4-4360-9f50-df22ba53258b]');
        ctrl = me.getController('B4.controller.OrdersObjectsEditor');
        model = ctrl.getModel(ctrl.viewDataModel).create(record.get('OrdersObjectsEditor'));
        ctrl.onSetViewData(model, element);
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_ObjectsOrdersList2.disableGrid();
            form.grid_ObjectProductsList.disableGrid();
            form.grid_CompositionObjectSpecialistsList.disableGrid();
            form.grid_CompositionWorksObjectsList.disableGrid();
            form.grid_ObjectsDocumentsList.disableGrid();
        } else {
            form.grid_ObjectsOrdersList2.enable();
            form.grid_ObjectsOrdersList2.loadData(true);
            form.grid_ObjectProductsList.enable();
            form.grid_ObjectProductsList.loadData(true);
            form.grid_CompositionObjectSpecialistsList.enable();
            form.grid_CompositionObjectSpecialistsList.loadData(true);
            form.grid_CompositionWorksObjectsList.enable();
            form.grid_CompositionWorksObjectsList.loadData(true);
            form.grid_ObjectsDocumentsList.enable();
            form.grid_ObjectsDocumentsList.loadData(true);
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
        // Объект.Создание
        element = view.down('[rmsUid=7ac403e4-faf4-4360-9f50-df22ba53258b]');
        ctrl = me.getController('B4.controller.OrdersObjectsEditor');
        ctrl.connectView(element, view.ctxKey);
        // Заказы.Объект
        element = view.down('[name=ObjectsOrdersList2]');
        ctrl = me.getController('B4.controller.ObjectsOrdersList2');
        ctrl.connectView(element, view.ctxKey);
        // Спецификация.Объект
        element = view.down('[name=ObjectProductsList]');
        ctrl = me.getController('B4.controller.ObjectProductsList');
        ctrl.connectView(element, view.ctxKey);
        // Специалисты.Объект
        element = view.down('[name=CompositionObjectSpecialistsList]');
        ctrl = me.getController('B4.controller.CompositionObjectSpecialistsList');
        ctrl.connectView(element, view.ctxKey);
        // Работы.Объект
        element = view.down('[name=CompositionWorksObjectsList]');
        ctrl = me.getController('B4.controller.CompositionWorksObjectsList');
        ctrl.connectView(element, view.ctxKey);
        // Документы.Объект
        element = view.down('[name=ObjectsDocumentsList]');
        ctrl = me.getController('B4.controller.ObjectsDocumentsList');
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
        element = view.down('[rmsUid=7ac403e4-faf4-4360-9f50-df22ba53258b]');
        ctrl = me.getController('B4.controller.OrdersObjectsEditor');
        model = ctrl.getModel(ctrl.viewDataModel).create(element.getEditorValues());
        ctrl.onViewDeployed(element, model);
        if (view.isReadOnly) {
            view.setReadOnly();
        }
    },
});