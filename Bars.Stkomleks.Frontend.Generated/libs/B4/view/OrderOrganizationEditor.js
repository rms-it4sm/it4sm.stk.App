Ext.define('B4.view.OrderOrganizationEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-orderorganizationeditor',
    title: 'Организация заказа',
    rmsUid: '51b898b7-bab8-4c73-b0d3-856ce114d842',
    rmsElementUid: '51b898b7-bab8-4c73-b0d3-856ce114d842',
    dataSourceUid: 'e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e',
    requires: [
        'B4.form.PickerField',
        'B4.model.OrdersListModel',
        'B4.model.OrganizationProfilesList2Model',
        'B4.model.ProfilesOrganizationsListModel',
        'B4.view.OrdersList',
        'B4.view.OrganizationProfilesList2',
        'B4.view.ProfilesOrganizationsList',
        'B4.view.ResponsiblePersonsOrderList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 600,
            width: 600
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'OrderOrganization_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Zakaz',
        'modelProperty': 'OrderOrganization_Zakaz',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Profile',
        'modelProperty': 'OrderOrganization_Profile',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Organization',
        'modelProperty': 'OrderOrganization_Organization',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'OrderOrganization_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '51b898b7-bab8-4c73-b0d3-856ce114d842-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'OrderOrganizationEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-93b56080-dd4c-476c-870e-387830d95fca',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-0fdb2e09-1dda-40b1-a538-35cec5abc822',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$f7ae25e3-ce68-4402-a491-414fcd634df3',
                    'editable': false,
                    'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-06e1b195-0b50-4691-8a48-01e826ef8311',
                    'fieldLabel': 'Заказ',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrdersList',
                    'listViewCtl': 'B4.controller.OrdersList',
                    'maximizable': true,
                    'model': 'B4.model.OrdersListModel',
                    'modelProperty': 'OrderOrganization_Zakaz',
                    'name': 'Zakaz',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '06e1b195-0b50-4691-8a48-01e826ef8311',
                    'textProperty': 'Number',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Заказ',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '0fdb2e09-1dda-40b1-a538-35cec5abc822',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '93b56080-dd4c-476c-870e-387830d95fca',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-a32efa72-a546-409e-9a25-0b7bf141164d',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-9b66016c-9778-488e-bfc0-7125245a48d2',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$b3680cb2-895a-4302-b935-4f34a4fdbb84',
                    'editable': false,
                    'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-213f9170-9e05-426a-9529-8394defefd3c',
                    'fieldLabel': 'Профиль',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.ProfilesOrganizationsList',
                    'listViewCtl': 'B4.controller.ProfilesOrganizationsList',
                    'maximizable': true,
                    'model': 'B4.model.ProfilesOrganizationsListModel',
                    'modelProperty': 'OrderOrganization_Profile',
                    'name': 'Profile',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '213f9170-9e05-426a-9529-8394defefd3c',
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
                }],
                'layout': 'anchor',
                'rmsUid': '9b66016c-9778-488e-bfc0-7125245a48d2',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'a32efa72-a546-409e-9a25-0b7bf141164d',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-c308992c-8221-4269-9668-b30b16d4a0a1',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-8c88202d-70fb-4700-b3d1-22d49ed416de',
                'flex': 1,
                'items': [{
                    '$SelectorFilter': {
                        "Group": 2,
                        "Operand": 0,
                        "DataIndex": null,
                        "DataIndexType": null,
                        "Value": null,
                        "Filters": [{
                            "Group": 0,
                            "Operand": 0,
                            "DataIndex": "FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$5258c478-6f02-425d-a14e-025882b1b6c0$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                            "DataIndexType": null,
                            "Value": "@213f9170-9e05-426a-9529-8394defefd3c_Id",
                            "Filters": null,
                            "IsEmpty": false
                        }],
                        "IsEmpty": false
                    },
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$6ba61f70-f527-49f0-8be6-6b3ad80631e0',
                    'editable': false,
                    'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-c3b85dc8-9185-4dcd-8290-3412f84ebbbb',
                    'fieldLabel': 'Организация',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrganizationProfilesList2',
                    'listViewCtl': 'B4.controller.OrganizationProfilesList2',
                    'maximizable': true,
                    'model': 'B4.model.OrganizationProfilesList2Model',
                    'modelProperty': 'OrderOrganization_Organization',
                    'name': 'Organization',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'c3b85dc8-9185-4dcd-8290-3412f84ebbbb',
                    'textProperty': 'Organization_Name',
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
                'rmsUid': '8c88202d-70fb-4700-b3d1-22d49ed416de',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'c308992c-8221-4269-9668-b30b16d4a0a1',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-5a1bb805-9b0e-4ab9-9e44-0f216892baa7',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-38cd30ef-2bd3-4ce3-9156-a04ad07a9a27',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$4ff1b371-5045-429f-b88e-9d6c6f52dd4e',
                    'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-0405b220-229b-44b3-9e70-9ca4ae8de489',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'OrderOrganization_Comment',
                    'name': 'Comment',
                    'rmsUid': '0405b220-229b-44b3-9e70-9ca4ae8de489',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': '38cd30ef-2bd3-4ce3-9156-a04ad07a9a27',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '5a1bb805-9b0e-4ab9-9e44-0f216892baa7',
            'xtype': 'container'
        }, {
            '$EntityFilter': {
                'LinkFilter': {
                    "Group": 3,
                    "Operand": 0,
                    "DataIndex": null,
                    "DataIndexType": null,
                    "Value": null,
                    "Filters": [{
                        "Group": 0,
                        "Operand": 0,
                        "DataIndex": "FieldPath://ad3b2737-f4d5-4495-b388-44a6dfd03bd9$2173306f-90af-4867-96b1-ff443b3bc289$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                        "DataIndexType": null,
                        "Value": "@OrderOrganization_Id",
                        "Filters": null,
                        "IsEmpty": false
                    }],
                    "IsEmpty": false
                }
            },
            'closable': false,
            'extraCls': 'cmp-style-51b898b7-bab8-4c73-b0d3-856ce114d842-1d7f1108-d152-426d-b268-cc56de6021a0',
            'flex': 1,
            'header': false,
            'inlineCascadeSave': false,
            'name': 'ResponsiblePersonsOrderList',
            'region': 'Center',
            'rmsUid': '1d7f1108-d152-426d-b268-cc56de6021a0',
            'title': null,
            'xtype': 'rms-responsiblepersonsorderlist'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'OrderOrganization_Id',
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
        me.grid_ResponsiblePersonsOrderList = me.down('rms-responsiblepersonsorderlist[name=ResponsiblePersonsOrderList]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Добавление организации в заказ');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
});