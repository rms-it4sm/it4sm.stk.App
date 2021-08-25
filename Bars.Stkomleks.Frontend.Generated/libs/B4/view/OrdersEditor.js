Ext.define('B4.view.OrdersEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-orderseditor',
    title: 'Заказ',
    rmsUid: 'b3d0c6e3-6410-4c8b-b359-da6efc0248e9',
    rmsElementUid: 'b3d0c6e3-6410-4c8b-b359-da6efc0248e9',
    dataSourceUid: 'cac4cb82-577f-4682-bbd7-bf7d70fbfee1',
    requires: [
        'B4.form.PickerField',
        'B4.model.OrganizationProfilesListModel',
        'B4.model.StaffListModel',
        'B4.view.ObjectsOrdersList',
        'B4.view.OrderOrganizationList',
        'B4.view.OrganizationProfilesList',
        'B4.view.StaffList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 600,
            width: 700
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'Zakaz_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Number',
        'modelProperty': 'Zakaz_Number',
        'type': 'TextField'
    }, {
        'dataIndex': 'Date',
        'modelProperty': 'Zakaz_Date',
        'type': 'DateField'
    }, {
        'dataIndex': 'Client',
        'modelProperty': 'Zakaz_Client',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Manager',
        'modelProperty': 'Zakaz_Manager',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'Zakaz_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'items': [{
                'iconCls': 'fas fs-exchange-alt',
                'itemId': 'btnState',
                'menu': [],
                'text': 'Статус',
                'xtype': 'button'
            }],
            'xtype': 'buttongroup'
        }, {
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': 'b3d0c6e3-6410-4c8b-b359-da6efc0248e9-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'OrdersEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-bbb9f947-96a8-43a4-ba13-446471dc90b1',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-a2a5b382-98ac-4c1c-b978-37e922a41c3d',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$2f3de072-33f6-492c-8016-a55598f69f32',
                    'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-90d74d06-9e1c-4bae-91cc-f8a54ec861fd',
                    'fieldLabel': 'Номер',
                    'labelAlign': 'top',
                    'modelProperty': 'Zakaz_Number',
                    'name': 'Number',
                    'rmsUid': '90d74d06-9e1c-4bae-91cc-f8a54ec861fd',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'a2a5b382-98ac-4c1c-b978-37e922a41c3d',
                'width': 150,
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-2f18e463-9178-49f7-a716-4ddecde6d262',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$94896f6f-f4a2-4c12-a701-0e988c92f462',
                    'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-b477d19c-aee8-4e02-b1d0-839b34b76598',
                    'fieldLabel': 'Дата',
                    'format': 'd.m.Y',
                    'labelAlign': 'top',
                    'modelProperty': 'Zakaz_Date',
                    'name': 'Date',
                    'rmsUid': 'b477d19c-aee8-4e02-b1d0-839b34b76598',
                    'xtype': 'datefield'
                }],
                'layout': 'anchor',
                'rmsUid': '2f18e463-9178-49f7-a716-4ddecde6d262',
                'width': 150,
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'bbb9f947-96a8-43a4-ba13-446471dc90b1',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-3dcc6734-703f-4a55-bb8d-421bc9d96f2f',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-dd9b6e94-e969-4c92-b62d-7561b4735cf3',
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
                            "DataIndex": "FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$5258c478-6f02-425d-a14e-025882b1b6c0$f44c4209-af60-444a-a056-671a5255de8d",
                            "DataIndexType": null,
                            "Value": "Заказчик",
                            "Filters": null,
                            "IsEmpty": false
                        }],
                        "IsEmpty": false
                    },
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$4082c604-c52d-4594-88ad-b59078285797',
                    'editable': false,
                    'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-1adc66bb-f2a6-42f2-ad47-bca4ec7f7b25',
                    'fieldLabel': 'Заказчик',
                    'hiddenListFields': [
                        'Id',
                        'Organization_Id',
                        'Profile_Name'],
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrganizationProfilesList',
                    'listViewCtl': 'B4.controller.OrganizationProfilesList',
                    'maximizable': true,
                    'model': 'B4.model.OrganizationProfilesListModel',
                    'modelProperty': 'Zakaz_Client',
                    'name': 'Client',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '1adc66bb-f2a6-42f2-ad47-bca4ec7f7b25',
                    'textProperty': 'Organization_Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Заказчик',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'dd9b6e94-e969-4c92-b62d-7561b4735cf3',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-63abbcc5-3df9-4e1b-b180-298db5c88daa',
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
                            "DataIndex": "FieldPath://0b83a4c4-1b8b-49d6-b16b-dcb3a373a391$877ada62-82d4-4fca-8574-61c4290187d5$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                            "DataIndexType": null,
                            "Value": "@1adc66bb-f2a6-42f2-ad47-bca4ec7f7b25_Organization_Id",
                            "Filters": null,
                            "IsEmpty": false
                        }],
                        "IsEmpty": false
                    },
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$3ee53bb5-bb60-47aa-8a69-41594431f6e0',
                    'editable': false,
                    'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-f42a0cdf-dc4b-4211-a0ef-e4652a986169',
                    'fieldLabel': 'Менеджер',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.StaffList',
                    'listViewCtl': 'B4.controller.StaffList',
                    'maximizable': true,
                    'model': 'B4.model.StaffListModel',
                    'modelProperty': 'Zakaz_Manager',
                    'name': 'Manager',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'f42a0cdf-dc4b-4211-a0ef-e4652a986169',
                    'textProperty': 'Individual_FIO',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Менеджер',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '63abbcc5-3df9-4e1b-b180-298db5c88daa',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '3dcc6734-703f-4a55-bb8d-421bc9d96f2f',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-3d9ed2fe-360b-472e-8bbc-113b6bc4f8eb',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-1dbe0f12-14ef-43d8-9dd3-c01e8222c8d2',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$01be0595-d7b3-4466-bf15-f9110b6fa65f',
                    'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-67de81d6-9c11-46ab-b862-7c352b920943',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'Zakaz_Comment',
                    'name': 'Comment',
                    'rmsUid': '67de81d6-9c11-46ab-b862-7c352b920943',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': '1dbe0f12-14ef-43d8-9dd3-c01e8222c8d2',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '3d9ed2fe-360b-472e-8bbc-113b6bc4f8eb',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-ad1048a9-1e9a-4773-8578-39eb33d882d9',
            'fieldLabel': 'Панель закладок',
            'flex': 1,
            'header': false,
            'items': [{
                'dockedItems': [],
                'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-83d83d1d-cbc7-4f04-984d-ec9d7f6cf67b',
                'fieldLabel': 'Объекты',
                'flex': 1,
                'iconCls': 'fad fa-map-marker-alt',
                'items': [{
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
                                "DataIndex": "FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$30ef3bf7-35e0-4a5c-9945-9fa7db560dc7$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@Zakaz_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-56478bd5-eb79-47aa-8264-408553cbd463',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'ObjectsOrdersList',
                    'region': 'Center',
                    'rmsUid': '56478bd5-eb79-47aa-8264-408553cbd463',
                    'title': null,
                    'xtype': 'rms-objectsorderslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '83d83d1d-cbc7-4f04-984d-ec9d7f6cf67b',
                'title': 'Объекты',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-26936da3-4bd0-42a9-9303-1cd4b87dbdaa',
                'fieldLabel': 'Организации',
                'flex': 1,
                'iconCls': 'fad fa-building',
                'items': [{
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
                                "DataIndex": "FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$f7ae25e3-ce68-4402-a491-414fcd634df3$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@Zakaz_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-b3d0c6e3-6410-4c8b-b359-da6efc0248e9-f8b64983-4cce-4108-8faa-aeee15bbfbd3',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'OrderOrganizationList',
                    'region': 'Center',
                    'rmsUid': 'f8b64983-4cce-4108-8faa-aeee15bbfbd3',
                    'title': null,
                    'xtype': 'rms-orderorganizationlist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '26936da3-4bd0-42a9-9303-1cd4b87dbdaa',
                'title': 'Организации',
                'xtype': 'container'
            }],
            'layout': {
                'type': 'fit'
            },
            'region': 'Center',
            'rmsUid': 'ad1048a9-1e9a-4773-8578-39eb33d882d9',
            'title': null,
            'xtype': 'tabpanel'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'Zakaz_Id',
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
        me.grid_ObjectsOrdersList = me.down('rms-objectsorderslist[name=ObjectsOrdersList]');
        me.grid_OrderOrganizationList = me.down('rms-orderorganizationlist[name=OrderOrganizationList]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Создание заказа');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        if (Ext.isNumber(entityId) && entityId > 0) {
            me.setTitle(rec.get('Number'));
        }
        return res;
    },
});