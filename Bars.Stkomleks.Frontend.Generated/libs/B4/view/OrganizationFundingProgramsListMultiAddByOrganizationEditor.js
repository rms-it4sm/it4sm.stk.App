Ext.define('B4.view.OrganizationFundingProgramsListMultiAddByOrganizationEditor', {
    extend: 'B4.base.form.MultiAddView',
    alias: 'widget.rms-organizationfundingprogramslistmultiaddbyorganizationeditor',
    title: '',
    rmsUid: 'c2a5c600-80de-0cf0-9304-42a9df7ae60e',
    rmsElementUid: 'c2a5c600-80de-0cf0-9304-42a9df7ae60e',
    dataSourceUid: '0de41a18-2d17-4f59-b60b-e39e0559c240',
    requires: [
        'B4.form.PickerField',
        'B4.model.FundingProgramsListModel',
        'B4.model.OrganizationListModel',
        'B4.view.FundingProgramsList',
        'B4.view.OrganizationList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {},
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'OrganizationFundingPrograms_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Organization',
        'modelProperty': 'OrganizationFundingPrograms_Organization',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'FundingPrograms',
        'modelProperty': 'OrganizationFundingPrograms_FundingPrograms',
        'type': 'SelectorField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Выбрать'
        }],
        'rmsUid': 'c2a5c600-80de-0cf0-9304-42a9df7ae60e-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'OrganizationFundingProgramsListMultiAddByOrganizationEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'maximizable': true,
        items: [{
            'dataIndexAbsoluteUid': 'FieldPath://0de41a18-2d17-4f59-b60b-e39e0559c240$a739203f-8f97-4e4a-b804-7d0a5ae76632',
            'editable': false,
            'extraCls': 'cmp-style-c2a5c600-80de-0cf0-9304-42a9df7ae60e-d293b26a-b89b-aefe-87a1-4bad120ba077',
            'fieldLabel': 'Организация',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.OrganizationList',
            'listViewCtl': 'B4.controller.OrganizationList',
            'model': 'B4.model.OrganizationListModel',
            'modelProperty': 'OrganizationFundingPrograms_Organization',
            'name': 'Organization',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': 'd293b26a-b89b-aefe-87a1-4bad120ba077',
            'textProperty': 'Name',
            'typeAhead': false,
            'windowCfg': {
                'border': false,
                'height': 550,
                'maximizable': true,
                'title': 'Организация',
                'width': 600
            },
            'xtype': 'b4pickerfield'
        }, {
            'closable': false,
            'dockedItems': null,
            'extraCls': 'cmp-style-c2a5c600-80de-0cf0-9304-42a9df7ae60e-6aca93db-5c20-864a-9c1b-c5b573f943ab',
            'flex': 1,
            'getSelected': function() {
                var selModel = this.getSelectionModel(),
                    selected = selModel && selModel.getSelection && selModel.getSelection(),
                    view = this.getView(),
                    checked = view && view.getChecked && view.getChecked();
                return checked || selected;
            },
            'header': false,
            'modelProperty': 'OrganizationFundingPrograms_FundingPrograms_Registry',
            'name': 'FundingProgramsList',
            'rmsUid': '6aca93db-5c20-864a-9c1b-c5b573f943ab',
            'rootVisible': false,
            'stateful': false,
            'tbar': null,
            'title': null,
            'xtype': 'rms-fundingprogramslist'
        }, {
            'dataIndexAbsoluteUid': 'FieldPath://0de41a18-2d17-4f59-b60b-e39e0559c240$f95a256b-5ae1-40f4-aa65-89e63c58f335',
            'editable': false,
            'extraCls': 'cmp-style-c2a5c600-80de-0cf0-9304-42a9df7ae60e-85777005-b52b-9921-3685-5a412553cd80',
            'fieldLabel': 'Программа финансирования',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.FundingProgramsList',
            'listViewCtl': 'B4.controller.FundingProgramsList',
            'model': 'B4.model.FundingProgramsListModel',
            'modelProperty': 'OrganizationFundingPrograms_FundingPrograms',
            'name': 'FundingPrograms',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': '85777005-b52b-9921-3685-5a412553cd80',
            'textProperty': 'Name',
            'typeAhead': false,
            'windowCfg': {
                'border': false,
                'height': 550,
                'maximizable': true,
                'title': 'Программа финансирования',
                'width': 600
            },
            'xtype': 'b4pickerfield'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'OrganizationFundingPrograms_Id',
                'name': 'Id',
                'xtype': 'hidden'
            }],
            'xtype': 'panel'
        }]
    }],
    plugins: [],
    initComponent: function() {
        var me = this;
        var tempXtypeName = null;
        Ext.each(this.items[0].items, function(item, index) {
            if (item['modelProperty'] == 'OrganizationFundingPrograms_FundingPrograms_Registry') {
                tempXtypeName = item['xtype'];
            }
        });
        var templist = Ext.create('widget.' + tempXtypeName);
        if (templist && !templist.is('treepanel')) {
            var selModel = Ext.create('Ext.selection.CheckboxModel', {
                mode: 'MULTI',
                checkOnly: true,
                pruneRemoved: false
            });
            Ext.each(this.items[0].items, function(item, index) {
                if (item['xtype'] == tempXtypeName) {
                    item['selModel'] = selModel;
                }
            });
        }
        templist.destroy();
        templist = null;
        me.callParent(arguments);
        me.submitTimeout = 120;
        var registry = me.down('[modelProperty=OrganizationFundingPrograms_FundingPrograms_Registry]');
        registry.getStore().on({
            'beforeload': function(curStore, operation) {
                const params = operation.getParams() || {};
                params.multiAddUid = '6da929c6-59b4-437b-8fc6-ad6cec6b69d5';
                operation.setParams(params);
            }
        });
        if (registry.is('treepanel')) {
            registry.on('load', function(sender, store, records, successful, eOpts) {
                registry.store.getRootNode().cascadeBy(function(node) {
                    node.set({
                        checked: false
                    });
                });
            });
            registry.loadData(true);
        }
        me.grid_FundingProgramsList = me.down('rms-fundingprogramslist[name=FundingProgramsList]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
    'getEditorValues': function() {
        var me = this;
        var record = me.getRecord();
        var values = {};
        var editor = me.down('[modelProperty=OrganizationFundingPrograms_Organization]'),
            editorValue = editor.value || null,
            registry = me.down('[modelProperty=OrganizationFundingPrograms_FundingPrograms_Registry]'),
            selected = registry.getSelected();
        values.records = [];
        if (Ext.isArray(selected)) {
            selected.forEach(function(item) {
                var model = {
                    Organization: {},
                    FundingPrograms: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.Organization[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.Organization = null;
                }
                model.FundingPrograms[editor.idProperty] = item.get(editor.idProperty);
                values.records.push(model);
            });
        } else if (Ext.isObject(selected)) {
            Ext.Object.each(selected, function(key, value, myself) {
                var model = {
                    Organization: {},
                    FundingPrograms: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.Organization[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.Organization = null;
                }
                model.FundingPrograms[editor.idProperty] = value.get(editor.idProperty);
                values.records.push(model);
            });
        }
        return values;
    }
});