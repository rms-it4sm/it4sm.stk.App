Ext.define('B4.view.OrganizationContactsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-organizationcontactseditor',
    title: 'Контакт организации',
    rmsUid: 'ecb21833-eea4-4cc6-abf7-af8875eff7fe',
    rmsElementUid: 'ecb21833-eea4-4cc6-abf7-af8875eff7fe',
    dataSourceUid: '2ab43a3b-81eb-4f93-8d61-eb1304c71200',
    requires: [
        'B4.form.PickerField',
        'B4.model.ContactsTypeListModel',
        'B4.model.OrganizationListModel',
        'B4.view.ContactsTypeList',
        'B4.view.OrganizationList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 235,
            width: 500
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'OrganizationContacts_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Organization',
        'modelProperty': 'OrganizationContacts_Organization',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Type',
        'modelProperty': 'OrganizationContacts_Type',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Contact',
        'modelProperty': 'OrganizationContacts_Contact',
        'type': 'TextField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'OrganizationContacts_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': 'ecb21833-eea4-4cc6-abf7-af8875eff7fe-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'OrganizationContactsEditor-container',
        'layout': {
            'type': 'anchor'
        },
        'region': 'Center',
        items: [{
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-7ade1bd0-e0d7-4ce9-8676-ee531d7324b2',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-9ff11f4d-b083-4c51-9811-ce81d618adbf',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://2ab43a3b-81eb-4f93-8d61-eb1304c71200$56a4d0ab-d6fa-4f25-aab9-24b4e09fa869',
                    'editable': false,
                    'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-5bc8a725-8141-4786-8b89-295f6a741051',
                    'fieldLabel': 'Организация',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrganizationList',
                    'listViewCtl': 'B4.controller.OrganizationList',
                    'maximizable': true,
                    'model': 'B4.model.OrganizationListModel',
                    'modelProperty': 'OrganizationContacts_Organization',
                    'name': 'Organization',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '5bc8a725-8141-4786-8b89-295f6a741051',
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
                }],
                'layout': 'anchor',
                'rmsUid': '9ff11f4d-b083-4c51-9811-ce81d618adbf',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '7ade1bd0-e0d7-4ce9-8676-ee531d7324b2',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-0573d314-9daa-4cb1-8496-517629c637fd',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-68d1c666-b632-49f9-be4b-87efe7be1153',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://2ab43a3b-81eb-4f93-8d61-eb1304c71200$a386480f-9a10-4e5d-bb26-988e998fe6f2',
                    'editable': false,
                    'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-0716e607-5126-4514-9753-10e22e55cf33',
                    'fieldLabel': 'Тип',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.ContactsTypeList',
                    'listViewCtl': 'B4.controller.ContactsTypeList',
                    'maximizable': true,
                    'model': 'B4.model.ContactsTypeListModel',
                    'modelProperty': 'OrganizationContacts_Type',
                    'name': 'Type',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '0716e607-5126-4514-9753-10e22e55cf33',
                    'textProperty': 'Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Тип',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '68d1c666-b632-49f9-be4b-87efe7be1153',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-53ab3604-1d24-4eda-89e2-a9173fe00b4b',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://2ab43a3b-81eb-4f93-8d61-eb1304c71200$97085dd4-c3b0-426b-85d2-dcd4d324177f',
                    'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-8e2f1526-27be-49c5-ace5-4d75e6a0fd66',
                    'fieldLabel': 'Контакт',
                    'labelAlign': 'top',
                    'modelProperty': 'OrganizationContacts_Contact',
                    'name': 'Contact',
                    'rmsUid': '8e2f1526-27be-49c5-ace5-4d75e6a0fd66',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': '53ab3604-1d24-4eda-89e2-a9173fe00b4b',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '0573d314-9daa-4cb1-8496-517629c637fd',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-d03fc73c-5d7a-4ae1-b28d-d448672cb890',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-da351868-5feb-4e4e-a43b-a2299943c083',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://2ab43a3b-81eb-4f93-8d61-eb1304c71200$5a634474-ec51-4c7b-bdd6-654d0c2914e7',
                    'extraCls': 'cmp-style-ecb21833-eea4-4cc6-abf7-af8875eff7fe-cdf68203-272f-439b-af3a-2fd2f8b799d5',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'OrganizationContacts_Comment',
                    'name': 'Comment',
                    'rmsUid': 'cdf68203-272f-439b-af3a-2fd2f8b799d5',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': 'da351868-5feb-4e4e-a43b-a2299943c083',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'd03fc73c-5d7a-4ae1-b28d-d448672cb890',
            'xtype': 'container'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'OrganizationContacts_Id',
                'name': 'Id',
                'xtype': 'hidden'
            }],
            'xtype': 'panel'
        }]
    }],
    plugins: [],
    initComponent: function() {
        var me = this;
        me.callParent(arguments);
        me.submitTimeout = 20;
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Добавление контакта организации');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        if (Ext.isNumber(entityId) && entityId > 0) {
            var _titleValue = Ext.String.format('{0}', rec.get('Type_Name'));
            me.setTitle(_titleValue);
        }
        return res;
    },
});