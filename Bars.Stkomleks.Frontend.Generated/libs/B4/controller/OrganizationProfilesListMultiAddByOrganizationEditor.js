Ext.define('B4.controller.OrganizationProfilesListMultiAddByOrganizationEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'OrganizationProfilesListMultiAddByOrganizationEditorModel'],
    views: [
        'OrganizationProfilesListMultiAddByOrganizationEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.OrganizationProfilesListMultiAddByOrganizationEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-organizationprofileslistmultiaddbyorganizationeditor',
    viewUid: '83ebe89f-a43d-17d2-5f92-8ac69dd34e43',
    viewDataModel: 'OrganizationProfilesListMultiAddByOrganizationEditorModel',
    viewDataController: 'OrganizationProfilesListMultiAddByOrganizationEditor',
    viewDataName: 'OrganizationProfilesListMultiAddByOrganizationEditor',
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-organizationprofileslistmultiaddbyorganizationeditor': {
                'onBeforeSaveRecord': me.on_rms_organizationprofileslistmultiaddbyorganizationeditor_on_before_save_record
            }
        });
        me.control({
            scope: me,
            'rms-organizationprofileslistmultiaddbyorganizationeditor b4pickerfield[name=Organization]': {
                'change': me.on_rms_organizationprofileslistmultiaddbyorganizationeditorb4pickerfield_name_organization_change
            }
        });
        me.callParent(arguments);
        this.initControllers(['B4.controller.ProfilesOrganizationsList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Профили организаций
        element = form.down('[name=ProfilesOrganizationsList]');
        ctrl = me.getController('B4.controller.ProfilesOrganizationsList');
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
        if (!Ext.isEmpty(ctxParams['Organization_Id'])) {
            this.preventFieldInput(form, ['[name=Organization]']);
        }
        if (!Ext.isEmpty(ctxParams['Profile_Id'])) {
            this.preventFieldInput(form, ['[name=Profile]']);
        }
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_ProfilesOrganizationsList.enable();
            form.grid_ProfilesOrganizationsList.loadData(true);
        } else {
            form.grid_ProfilesOrganizationsList.enable();
            form.grid_ProfilesOrganizationsList.loadData(true);
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
        // Профили организаций
        element = view.down('[name=ProfilesOrganizationsList]');
        ctrl = me.getController('B4.controller.ProfilesOrganizationsList');
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
    on_rms_organizationprofileslistmultiaddbyorganizationeditor_on_before_save_record: function(form) {
        var grid = form.down('gridpanel');
        grid && grid.getSelectionModel && grid.getSelectionModel().deselectAll();
    },
    on_rms_organizationprofileslistmultiaddbyorganizationeditorb4pickerfield_name_organization_change: function(field, value, eOpts) {
        var view = field.up('rms-organizationprofileslistmultiaddbyorganizationeditor');
        var registry = view && view.down('[modelProperty=OrganizationProfiles_Profile_Registry]');
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