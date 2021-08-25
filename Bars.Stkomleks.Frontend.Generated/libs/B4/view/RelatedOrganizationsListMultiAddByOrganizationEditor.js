Ext.define('B4.view.RelatedOrganizationsListMultiAddByOrganizationEditor', {
    extend: 'B4.base.form.MultiAddView',
    alias: 'widget.rms-relatedorganizationslistmultiaddbyorganizationeditor',
    title: '',
    rmsUid: '1a966ea7-1e15-5145-e7f8-e3b91e3056ae',
    rmsElementUid: '1a966ea7-1e15-5145-e7f8-e3b91e3056ae',
    dataSourceUid: 'ba084c30-4998-4494-a718-d6eca64c6140',
    requires: [
        'B4.form.PickerField',
        'B4.model.OrganizationListModel',
        'B4.view.OrganizationList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {},
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'RelatedOrganizations_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Organization',
        'modelProperty': 'RelatedOrganizations_Organization',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'RelatedOrg',
        'modelProperty': 'RelatedOrganizations_RelatedOrg',
        'type': 'SelectorField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Выбрать'
        }],
        'rmsUid': '1a966ea7-1e15-5145-e7f8-e3b91e3056ae-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'RelatedOrganizationsListMultiAddByOrganizationEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'maximizable': true,
        items: [{
            'dataIndexAbsoluteUid': 'FieldPath://ba084c30-4998-4494-a718-d6eca64c6140$42fbc98d-ab6c-474a-8a5e-74f8b1811518',
            'editable': false,
            'extraCls': 'cmp-style-1a966ea7-1e15-5145-e7f8-e3b91e3056ae-a9913a4a-6560-cb62-ab3a-82fb6689cc52',
            'fieldLabel': 'Организация',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.OrganizationList',
            'listViewCtl': 'B4.controller.OrganizationList',
            'model': 'B4.model.OrganizationListModel',
            'modelProperty': 'RelatedOrganizations_Organization',
            'name': 'Organization',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': 'a9913a4a-6560-cb62-ab3a-82fb6689cc52',
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
            'extraCls': 'cmp-style-1a966ea7-1e15-5145-e7f8-e3b91e3056ae-b1421b1f-2784-0477-4f1c-ebb2a364f317',
            'flex': 1,
            'getSelected': function() {
                var selModel = this.getSelectionModel(),
                    selected = selModel && selModel.getSelection && selModel.getSelection(),
                    view = this.getView(),
                    checked = view && view.getChecked && view.getChecked();
                return checked || selected;
            },
            'header': false,
            'modelProperty': 'RelatedOrganizations_RelatedOrg_Registry',
            'name': 'OrganizationList',
            'rmsUid': 'b1421b1f-2784-0477-4f1c-ebb2a364f317',
            'rootVisible': false,
            'stateful': false,
            'tbar': null,
            'title': null,
            'xtype': 'rms-organizationlist'
        }, {
            'dataIndexAbsoluteUid': 'FieldPath://ba084c30-4998-4494-a718-d6eca64c6140$21c4785e-e297-40c1-a26a-595bd3238a35',
            'editable': false,
            'extraCls': 'cmp-style-1a966ea7-1e15-5145-e7f8-e3b91e3056ae-1cb0d009-0f5a-4361-204a-1744329a84e0',
            'fieldLabel': 'Связанная организация',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.OrganizationList',
            'listViewCtl': 'B4.controller.OrganizationList',
            'model': 'B4.model.OrganizationListModel',
            'modelProperty': 'RelatedOrganizations_RelatedOrg',
            'name': 'RelatedOrg',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': '1cb0d009-0f5a-4361-204a-1744329a84e0',
            'textProperty': 'Name',
            'typeAhead': false,
            'windowCfg': {
                'border': false,
                'height': 550,
                'maximizable': true,
                'title': 'Связанная организация',
                'width': 600
            },
            'xtype': 'b4pickerfield'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'RelatedOrganizations_Id',
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
            if (item['modelProperty'] == 'RelatedOrganizations_RelatedOrg_Registry') {
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
        var registry = me.down('[modelProperty=RelatedOrganizations_RelatedOrg_Registry]');
        registry.getStore().on({
            'beforeload': function(curStore, operation) {
                const params = operation.getParams() || {};
                params.multiAddUid = '1bcf57c5-52d3-402a-923f-46a6681796e1';
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
        me.grid_OrganizationList = me.down('rms-organizationlist[name=OrganizationList]');
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
        var editor = me.down('[modelProperty=RelatedOrganizations_Organization]'),
            editorValue = editor.value || null,
            registry = me.down('[modelProperty=RelatedOrganizations_RelatedOrg_Registry]'),
            selected = registry.getSelected();
        values.records = [];
        if (Ext.isArray(selected)) {
            selected.forEach(function(item) {
                var model = {
                    Organization: {},
                    RelatedOrg: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.Organization[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.Organization = null;
                }
                model.RelatedOrg[editor.idProperty] = item.get(editor.idProperty);
                values.records.push(model);
            });
        } else if (Ext.isObject(selected)) {
            Ext.Object.each(selected, function(key, value, myself) {
                var model = {
                    Organization: {},
                    RelatedOrg: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.Organization[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.Organization = null;
                }
                model.RelatedOrg[editor.idProperty] = value.get(editor.idProperty);
                values.records.push(model);
            });
        }
        return values;
    }
});