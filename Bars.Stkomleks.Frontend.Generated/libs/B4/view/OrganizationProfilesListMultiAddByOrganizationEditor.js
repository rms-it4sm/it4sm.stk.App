Ext.define('B4.view.OrganizationProfilesListMultiAddByOrganizationEditor', {
    extend: 'B4.base.form.MultiAddView',
    alias: 'widget.rms-organizationprofileslistmultiaddbyorganizationeditor',
    title: '',
    rmsUid: '83ebe89f-a43d-17d2-5f92-8ac69dd34e43',
    rmsElementUid: '83ebe89f-a43d-17d2-5f92-8ac69dd34e43',
    dataSourceUid: '2f3cc7da-d8a3-4c53-b83f-ec26f028202e',
    requires: [
        'B4.form.PickerField',
        'B4.model.OrganizationListModel',
        'B4.model.ProfilesOrganizationsListModel',
        'B4.view.OrganizationList',
        'B4.view.ProfilesOrganizationsList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {},
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'OrganizationProfiles_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Organization',
        'modelProperty': 'OrganizationProfiles_Organization',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Profile',
        'modelProperty': 'OrganizationProfiles_Profile',
        'type': 'SelectorField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Выбрать'
        }],
        'rmsUid': '83ebe89f-a43d-17d2-5f92-8ac69dd34e43-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'OrganizationProfilesListMultiAddByOrganizationEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'maximizable': true,
        items: [{
            'dataIndexAbsoluteUid': 'FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$e0a08ecf-f833-461a-8b0d-8d7e5d4e4778',
            'editable': false,
            'extraCls': 'cmp-style-83ebe89f-a43d-17d2-5f92-8ac69dd34e43-3f6a27a7-9537-6b5e-172c-f61ca13808c4',
            'fieldLabel': 'Организация',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.OrganizationList',
            'listViewCtl': 'B4.controller.OrganizationList',
            'model': 'B4.model.OrganizationListModel',
            'modelProperty': 'OrganizationProfiles_Organization',
            'name': 'Organization',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': '3f6a27a7-9537-6b5e-172c-f61ca13808c4',
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
            'extraCls': 'cmp-style-83ebe89f-a43d-17d2-5f92-8ac69dd34e43-7fcb5033-cbfe-1dc9-5d12-c1cf269e022f',
            'flex': 1,
            'getSelected': function() {
                var selModel = this.getSelectionModel(),
                    selected = selModel && selModel.getSelection && selModel.getSelection(),
                    view = this.getView(),
                    checked = view && view.getChecked && view.getChecked();
                return checked || selected;
            },
            'header': false,
            'modelProperty': 'OrganizationProfiles_Profile_Registry',
            'name': 'ProfilesOrganizationsList',
            'rmsUid': '7fcb5033-cbfe-1dc9-5d12-c1cf269e022f',
            'rootVisible': false,
            'stateful': false,
            'tbar': null,
            'title': null,
            'xtype': 'rms-profilesorganizationslist'
        }, {
            'dataIndexAbsoluteUid': 'FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$5258c478-6f02-425d-a14e-025882b1b6c0',
            'editable': false,
            'extraCls': 'cmp-style-83ebe89f-a43d-17d2-5f92-8ac69dd34e43-f41fc75b-99e9-2cb7-334f-1847641581ea',
            'fieldLabel': 'Профиль',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.ProfilesOrganizationsList',
            'listViewCtl': 'B4.controller.ProfilesOrganizationsList',
            'model': 'B4.model.ProfilesOrganizationsListModel',
            'modelProperty': 'OrganizationProfiles_Profile',
            'name': 'Profile',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': 'f41fc75b-99e9-2cb7-334f-1847641581ea',
            'textProperty': 'Name',
            'typeAhead': false,
            'windowCfg': {
                'border': false,
                'height': 550,
                'maximizable': true,
                'title': 'Профиль',
                'width': 600
            },
            'xtype': 'b4pickerfield'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'OrganizationProfiles_Id',
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
            if (item['modelProperty'] == 'OrganizationProfiles_Profile_Registry') {
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
        var registry = me.down('[modelProperty=OrganizationProfiles_Profile_Registry]');
        registry.getStore().on({
            'beforeload': function(curStore, operation) {
                const params = operation.getParams() || {};
                params.multiAddUid = 'a472d882-baaf-4085-90e0-7c7dffa14f80';
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
        me.grid_ProfilesOrganizationsList = me.down('rms-profilesorganizationslist[name=ProfilesOrganizationsList]');
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
        var editor = me.down('[modelProperty=OrganizationProfiles_Organization]'),
            editorValue = editor.value || null,
            registry = me.down('[modelProperty=OrganizationProfiles_Profile_Registry]'),
            selected = registry.getSelected();
        values.records = [];
        if (Ext.isArray(selected)) {
            selected.forEach(function(item) {
                var model = {
                    Organization: {},
                    Profile: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.Organization[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.Organization = null;
                }
                model.Profile[editor.idProperty] = item.get(editor.idProperty);
                values.records.push(model);
            });
        } else if (Ext.isObject(selected)) {
            Ext.Object.each(selected, function(key, value, myself) {
                var model = {
                    Organization: {},
                    Profile: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.Organization[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.Organization = null;
                }
                model.Profile[editor.idProperty] = value.get(editor.idProperty);
                values.records.push(model);
            });
        }
        return values;
    }
});