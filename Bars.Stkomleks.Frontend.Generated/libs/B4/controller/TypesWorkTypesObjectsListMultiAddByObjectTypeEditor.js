Ext.define('B4.controller.TypesWorkTypesObjectsListMultiAddByObjectTypeEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel'],
    views: [
        'TypesWorkTypesObjectsListMultiAddByObjectTypeEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.TypesWorkTypesObjectsListMultiAddByObjectTypeEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-typesworktypesobjectslistmultiaddbyobjecttypeeditor',
    viewUid: '29f93965-1a12-ded8-53ec-b1b5d225fe54',
    viewDataModel: 'TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel',
    viewDataController: 'TypesWorkTypesObjectsListMultiAddByObjectTypeEditor',
    viewDataName: 'TypesWorkTypesObjectsListMultiAddByObjectTypeEditor',
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-typesworktypesobjectslistmultiaddbyobjecttypeeditor': {
                'onBeforeSaveRecord': me.on_rms_typesworktypesobjectslistmultiaddbyobjecttypeeditor_on_before_save_record
            }
        });
        me.control({
            scope: me,
            'rms-typesworktypesobjectslistmultiaddbyobjecttypeeditor b4pickerfield[name=ObjectType]': {
                'change': me.on_rms_typesworktypesobjectslistmultiaddbyobjecttypeeditorb4pickerfield_name_objecttype_change
            }
        });
        me.callParent(arguments);
        this.initControllers(['B4.controller.WorksTypesList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Виды работ
        element = form.down('[name=WorksTypesList]');
        ctrl = me.getController('B4.controller.WorksTypesList');
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
        if (!Ext.isEmpty(ctxParams['ObjectType_Id'])) {
            this.preventFieldInput(form, ['[name=ObjectType]']);
        }
        if (!Ext.isEmpty(ctxParams['WorkType_Id'])) {
            this.preventFieldInput(form, ['[name=WorkType]']);
        }
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_WorksTypesList.enable();
            form.grid_WorksTypesList.loadData(true);
        } else {
            form.grid_WorksTypesList.enable();
            form.grid_WorksTypesList.loadData(true);
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
        // Виды работ
        element = view.down('[name=WorksTypesList]');
        ctrl = me.getController('B4.controller.WorksTypesList');
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
    on_rms_typesworktypesobjectslistmultiaddbyobjecttypeeditor_on_before_save_record: function(form) {
        var grid = form.down('gridpanel');
        grid && grid.getSelectionModel && grid.getSelectionModel().deselectAll();
    },
    on_rms_typesworktypesobjectslistmultiaddbyobjecttypeeditorb4pickerfield_name_objecttype_change: function(field, value, eOpts) {
        var view = field.up('rms-typesworktypesobjectslistmultiaddbyobjecttypeeditor');
        var registry = view && view.down('[modelProperty=TypesWorkTypesObjects_WorkType_Registry]');
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