Ext.define('B4.controller.OrdersObjectsEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'OrdersObjectsEditorModel'],
    views: [
        'OrdersObjectsEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.aspects.StateButton',
        'B4.view.OrdersObjectsEditor'],
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
    viewAlias: 'rms-ordersobjectseditor',
    viewUid: '395dbab2-e4ab-4846-b876-dbf8b577d6d9',
    viewDataModel: 'OrdersObjectsEditorModel',
    viewDataController: 'OrdersObjectsEditor',
    viewDataName: 'OrdersObjectsEditor',
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-ordersobjectseditor': {
                'onAfterSaveRecord': me.on_rms_ordersobjectseditor_on_after_save_record
            }
        });
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
        if (!Ext.isEmpty(ctxParams['Zakaz_Id'])) {
            this.preventFieldInput(form, ['[name=Zakaz]']);
        }
        if (!Ext.isEmpty(ctxParams['Type_Id'])) {
            this.preventFieldInput(form, ['[name=Type]']);
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
    on_rms_ordersobjectseditor_on_after_save_record: function(cmp, recordId, recordData) {
        try {
            var _self = this,
                _args = Array.prototype.slice.call(arguments);
            var editor = B4.utils.FormHelper.getEditorView(arguments, this),
                id = editor ? editor.getRecord().get('Id') : null,
                grid = B4.utils.FormHelper.findNearestListView(typeof _self === 'undefined' ? this : _self),
                ctxKey = (grid && grid.ctxKey) || this.getCurrentContextKey(),
                dataVariables = new B4.variables.Container();
            var _v60697d20bb334cfe89867f5b7658fc3d = cmp.rmsUid == '395dbab2-e4ab-4846-b876-dbf8b577d6d9' ? cmp : cmp.up('[rmsUid=395dbab2-e4ab-4846-b876-dbf8b577d6d9]');
            _v60697d20bb334cfe89867f5b7658fc3d = _v60697d20bb334cfe89867f5b7658fc3d.up("window") || _v60697d20bb334cfe89867f5b7658fc3d;
            _v60697d20bb334cfe89867f5b7658fc3d && _v60697d20bb334cfe89867f5b7658fc3d.destroy();
            grid && grid.data && grid.data.getVariables().forEach(v => dataVariables.set(v.code, v.value));
            var inWindow = false;
            var parentComponentWithVersionAttribute = B4.utils.FormHelper.findNearestParentWithAttribute(grid, 'versionScope');
            var parentComponentWithChangeSetAttribute = B4.utils.FormHelper.findNearestParentWithAttribute(grid, 'changeSet');
            B4.Navigation.openForm("OrdersObjectsEditor_Copy_0", id, inWindow, false, {
                dataVariables: dataVariables,
                RmsDataGridAlias: this.viewAlias,
                RmsDataGridId: grid ? grid.getId() : null,
                ctxKey: ctxKey,
                isDataGridEditor: !Ext.isEmpty(grid),
                versionScope: parentComponentWithVersionAttribute != null ? Ext.decode(Ext.encode(parentComponentWithVersionAttribute.versionScope)) : null,
                changeSet: parentComponentWithChangeSetAttribute != null ? Ext.decode(Ext.encode(parentComponentWithChangeSetAttribute.changeSet)) : null,
                maximizable: true,
                viewStack: grid && grid.viewStack ? [...grid.viewStack] : []
            });
        } catch (_e__r__r) {
            console.warn("Ошибка в событии `После сохранения` элемента `395dbab2-e4ab-4846-b876-dbf8b577d6d9`");
            throw _e__r__r;
        }
    }
});