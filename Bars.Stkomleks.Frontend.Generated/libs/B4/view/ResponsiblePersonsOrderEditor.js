Ext.define('B4.view.ResponsiblePersonsOrderEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-responsiblepersonsordereditor',
    title: 'Ответственное лицо заказа',
    rmsUid: '67d498ae-2835-45e6-972f-62b96a4979aa',
    rmsElementUid: '67d498ae-2835-45e6-972f-62b96a4979aa',
    dataSourceUid: 'ad3b2737-f4d5-4495-b388-44a6dfd03bd9',
    requires: [
        'B4.form.PickerField',
        'B4.model.OrderOrganizationListModel',
        'B4.model.StaffListModel',
        'B4.view.OrderOrganizationList',
        'B4.view.StaffList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 205,
            width: 500
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'ResponsiblePersonsOrder_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'OrderOrganization',
        'modelProperty': 'ResponsiblePersonsOrder_OrderOrganization',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Staff',
        'modelProperty': 'ResponsiblePersonsOrder_Staff',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Appointment',
        'modelProperty': 'ResponsiblePersonsOrder_Appointment',
        'type': 'TextField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '67d498ae-2835-45e6-972f-62b96a4979aa-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'ResponsiblePersonsOrderEditor-container',
        'layout': {
            'type': 'anchor'
        },
        'region': 'Center',
        items: [{
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-67d498ae-2835-45e6-972f-62b96a4979aa-25b33cc3-d7a6-4307-a41f-039a518ca6c9',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-67d498ae-2835-45e6-972f-62b96a4979aa-43800083-ca57-478f-8e4b-3e530103fca2',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://ad3b2737-f4d5-4495-b388-44a6dfd03bd9$2173306f-90af-4867-96b1-ff443b3bc289',
                    'editable': false,
                    'extraCls': 'cmp-style-67d498ae-2835-45e6-972f-62b96a4979aa-3dfdd012-7ea1-47fa-86d7-10aaa70d0ab2',
                    'fieldLabel': 'Организация заказа',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrderOrganizationList',
                    'listViewCtl': 'B4.controller.OrderOrganizationList',
                    'maximizable': true,
                    'model': 'B4.model.OrderOrganizationListModel',
                    'modelProperty': 'ResponsiblePersonsOrder_OrderOrganization',
                    'name': 'OrderOrganization',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '3dfdd012-7ea1-47fa-86d7-10aaa70d0ab2',
                    'textProperty': 'Organization_Organization_Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Организация заказа',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '43800083-ca57-478f-8e4b-3e530103fca2',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '25b33cc3-d7a6-4307-a41f-039a518ca6c9',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-67d498ae-2835-45e6-972f-62b96a4979aa-08d3ed8d-d7da-4be9-91df-9376f08d0c98',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-67d498ae-2835-45e6-972f-62b96a4979aa-881b4b7e-c52a-481b-bc09-8e681140f3ed',
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
                            "Value": "@3dfdd012-7ea1-47fa-86d7-10aaa70d0ab2_Organization_Id",
                            "Filters": null,
                            "IsEmpty": false
                        }],
                        "IsEmpty": false
                    },
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://ad3b2737-f4d5-4495-b388-44a6dfd03bd9$d72d7037-1006-4e36-9322-acb7fac2c8ea',
                    'editable': false,
                    'extraCls': 'cmp-style-67d498ae-2835-45e6-972f-62b96a4979aa-cca396ee-fdd6-4e2a-9d9c-44007b0c8690',
                    'fieldLabel': 'Сотрудник',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.StaffList',
                    'listViewCtl': 'B4.controller.StaffList',
                    'maximizable': true,
                    'model': 'B4.model.StaffListModel',
                    'modelProperty': 'ResponsiblePersonsOrder_Staff',
                    'name': 'Staff',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'cca396ee-fdd6-4e2a-9d9c-44007b0c8690',
                    'textProperty': 'Individual_FIO',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Сотрудник',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '881b4b7e-c52a-481b-bc09-8e681140f3ed',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '08d3ed8d-d7da-4be9-91df-9376f08d0c98',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-67d498ae-2835-45e6-972f-62b96a4979aa-81e663f8-2fb6-4e4a-9bde-a4b3c6c6522e',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-67d498ae-2835-45e6-972f-62b96a4979aa-ca5cb3f0-f084-42a2-8a85-6b1986485c7e',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://ad3b2737-f4d5-4495-b388-44a6dfd03bd9$7194780a-1ae7-4273-a332-85e86223a895',
                    'extraCls': 'cmp-style-67d498ae-2835-45e6-972f-62b96a4979aa-cc815e19-f5bd-42ae-801b-00cf22861ec0',
                    'fieldLabel': 'Назначение',
                    'labelAlign': 'top',
                    'modelProperty': 'ResponsiblePersonsOrder_Appointment',
                    'name': 'Appointment',
                    'rmsUid': 'cc815e19-f5bd-42ae-801b-00cf22861ec0',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'ca5cb3f0-f084-42a2-8a85-6b1986485c7e',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '81e663f8-2fb6-4e4a-9bde-a4b3c6c6522e',
            'xtype': 'container'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'ResponsiblePersonsOrder_Id',
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
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
});