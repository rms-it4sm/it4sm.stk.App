Ext.define('B4.controller.OrganizationFundingProgramsListMultiAddByOrganizationEditor', {
    extend: 'B4.base.form.Controller',
    models: [
        'OrganizationFundingProgramsListMultiAddByOrganizationEditorModel'],
    views: [
        'OrganizationFundingProgramsListMultiAddByOrganizationEditor'],
    requires: [
        'B4.aspects.Permission',
        'B4.view.OrganizationFundingProgramsListMultiAddByOrganizationEditor'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-organizationfundingprogramslistmultiaddbyorganizationeditor',
    viewUid: 'c2a5c600-80de-0cf0-9304-42a9df7ae60e',
    viewDataModel: 'OrganizationFundingProgramsListMultiAddByOrganizationEditorModel',
    viewDataController: 'OrganizationFundingProgramsListMultiAddByOrganizationEditor',
    viewDataName: 'OrganizationFundingProgramsListMultiAddByOrganizationEditor',
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-organizationfundingprogramslistmultiaddbyorganizationeditor': {
                'onBeforeSaveRecord': me.on_rms_organizationfundingprogramslistmultiaddbyorganizationeditor_on_before_save_record
            }
        });
        me.control({
            scope: me,
            'rms-organizationfundingprogramslistmultiaddbyorganizationeditor b4pickerfield[name=Organization]': {
                'change': me.on_rms_organizationfundingprogramslistmultiaddbyorganizationeditorb4pickerfield_name_organization_change
            }
        });
        me.callParent(arguments);
        this.initControllers(['B4.controller.FundingProgramsList']);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
        // Программы финансирования
        element = form.down('[name=FundingProgramsList]');
        ctrl = me.getController('B4.controller.FundingProgramsList');
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
        if (!Ext.isEmpty(ctxParams['FundingPrograms_Id'])) {
            this.preventFieldInput(form, ['[name=FundingPrograms]']);
        }
        if (isNewRecord == true && isMultiAdd == false) {
            form.grid_FundingProgramsList.enable();
            form.grid_FundingProgramsList.loadData(true);
        } else {
            form.grid_FundingProgramsList.enable();
            form.grid_FundingProgramsList.loadData(true);
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
        // Программы финансирования
        element = view.down('[name=FundingProgramsList]');
        ctrl = me.getController('B4.controller.FundingProgramsList');
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
    on_rms_organizationfundingprogramslistmultiaddbyorganizationeditor_on_before_save_record: function(form) {
        var grid = form.down('gridpanel');
        grid && grid.getSelectionModel && grid.getSelectionModel().deselectAll();
    },
    on_rms_organizationfundingprogramslistmultiaddbyorganizationeditorb4pickerfield_name_organization_change: function(field, value, eOpts) {
        var view = field.up('rms-organizationfundingprogramslistmultiaddbyorganizationeditor');
        var registry = view && view.down('[modelProperty=OrganizationFundingPrograms_FundingPrograms_Registry]');
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