Ext.define('B4.controller.CompositionWorksObjectsEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'CompositionWorksObjectsEditorModel'],
    views: [
        'CompositionWorksObjectsEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.aspects.StateButton',
        'B4.view.CompositionWorksObjectsEditor'],
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
    viewAlias: 'rms-compositionworksobjectseditor',
    viewUid: '4e04503b-095f-40ac-a590-d3b44110768f',
    viewDataModel: 'CompositionWorksObjectsEditorModel',
    viewDataController: 'CompositionWorksObjectsEditor',
    viewDataName: 'CompositionWorksObjectsEditor',
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-compositionworksobjectseditor': {
                'onBeforeValidate': me.on_rms_compositionworksobjectseditor_on_before_validate
            }
        });
        me.control({
            scope: me,
            'rms-compositionworksobjectseditor': {
                'onCreateRecord': me.on_rms_compositionworksobjectseditor_on_create_record
            }
        });
        me.control({
            scope: me,
            '[rmsUid=e1d5e4c4-3020-4ea2-84c7-17d4e228ade9]': {
                'change': me.on_rmsuid_e1d5e4c4_3020_4ea2_84c7_17d4e228ade9_change
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
                    selectedState.TypeId = 'bars.stkomleks.compositionworksobjects';
                    aspect.setStateData(record.get('Id'), selectedState);
                }
            }
        }, this);
        // получаем параметры контекста
        var ctxParams = form.data.getValues();
        // если в текущем контексте контроллера переданы идентификаторы
        // ссылочных полей, то необходимо передать их в параметрах операции 
        // и скрыть столбцы, отображающие поля ссылок
        if (!Ext.isEmpty(ctxParams['ObjectWork_Id'])) {
            this.preventFieldInput(form, ['[name=ObjectWork]']);
        }
        if (!Ext.isEmpty(ctxParams['WorkType_Id'])) {
            this.preventFieldInput(form, ['[name=WorkType]']);
        }
        if (!Ext.isEmpty(ctxParams['ObjectElement_Id'])) {
            this.preventFieldInput(form, ['[name=ObjectElement]']);
        }
        if (!Ext.isEmpty(ctxParams['ContractorWork_Id'])) {
            this.preventFieldInput(form, ['[name=ContractorWork]']);
        }
        if (!Ext.isEmpty(ctxParams['Brigade_Id'])) {
            this.preventFieldInput(form, ['[name=Brigade]']);
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
    on_rms_compositionworksobjectseditor_on_before_validate: function(view) {
        try {
            var _self = this,
                _args = Array.prototype.slice.call(arguments);
            var cmp = B4.utils.FormHelper.findComponentByUid('b6a092b6-cd49-4b7b-b0d1-0c0c9b25b988', typeof _self === 'undefined' ? this : _self),
                value = B4.utils.FormHelper.getCmpValue(cmp, null),
                cmp1 = B4.utils.FormHelper.findComponentByUid('d7aa4ba2-32fc-4a4f-9a3a-32c7519cc054', typeof _self === 'undefined' ? this : _self),
                cmp2 = B4.utils.FormHelper.findComponentByUid('186250b8-243c-46dd-8485-aecd9df9c34d', typeof _self === 'undefined' ? this : _self);
            if (Ext.isEmpty(value)) {
                cmp2.setValue(cmp1.getRawValue());
            } else {
                cmp2.setValue(cmp.getRawValue());
            }
        } catch (_e__r__r) {
            console.warn("Ошибка в событии `Перед валидацией` элемента `4e04503b-095f-40ac-a590-d3b44110768f`");
            throw _e__r__r;
        }
    },
    on_rms_compositionworksobjectseditor_on_create_record: function(cmp) {
        try {
            var _self = this,
                _args = Array.prototype.slice.call(arguments);
            var cmp = B4.utils.FormHelper.findComponentByUid('e1d5e4c4-3020-4ea2-84c7-17d4e228ade9', typeof _self === 'undefined' ? this : _self),
                cmp1 = B4.utils.FormHelper.findComponentByUid('b6a092b6-cd49-4b7b-b0d1-0c0c9b25b988', typeof _self === 'undefined' ? this : _self),
                cmp2 = cmp1 && cmp1.tab ? cmp1.tab : cmp1,
                cmp3 = B4.utils.FormHelper.findComponentByUid('d7aa4ba2-32fc-4a4f-9a3a-32c7519cc054', typeof _self === 'undefined' ? this : _self),
                cmp4 = cmp3 && cmp3.tab ? cmp3.tab : cmp3;
            cmp.setValue(1);
            cmp2 && cmp2.hide();
            cmp4 && cmp4.show();
        } catch (_e__r__r) {
            console.warn("Ошибка в событии `При создании записи` элемента `4e04503b-095f-40ac-a590-d3b44110768f`");
            throw _e__r__r;
        }
    },
    on_rmsuid_e1d5e4c4_3020_4ea2_84c7_17d4e228ade9_change: function(sender, newValue, oldValue) {
        try {
            var _self = this,
                _args = Array.prototype.slice.call(arguments);
            var cmp = B4.utils.FormHelper.findComponentByUid('e1d5e4c4-3020-4ea2-84c7-17d4e228ade9', typeof _self === 'undefined' ? this : _self),
                cmp1 = B4.utils.FormHelper.findComponentByUid('b6a092b6-cd49-4b7b-b0d1-0c0c9b25b988', typeof _self === 'undefined' ? this : _self),
                cmp2 = cmp1 && cmp1.tab ? cmp1.tab : cmp1,
                cmp3 = B4.utils.FormHelper.findComponentByUid('d7aa4ba2-32fc-4a4f-9a3a-32c7519cc054', typeof _self === 'undefined' ? this : _self),
                cmp4 = cmp3 && cmp3.tab ? cmp3.tab : cmp3;
            if (cmp.getValue() == 1) {
                cmp2 && cmp2.hide();
                cmp1.setValue(null);
                cmp4 && cmp4.show();
            } else {
                cmp2 && cmp2.show();
                cmp4 && cmp4.hide();
                cmp3.setValue(null);
            }
        } catch (_e__r__r) {
            console.warn("Ошибка в событии `При изменении значения` элемента `e1d5e4c4-3020-4ea2-84c7-17d4e228ade9`");
            throw _e__r__r;
        }
    }
});