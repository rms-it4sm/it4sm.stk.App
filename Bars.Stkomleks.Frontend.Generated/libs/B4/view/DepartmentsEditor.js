Ext.define('B4.view.DepartmentsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-departmentseditor',
    title: 'Подразделение',
    rmsUid: '130c4db5-a9b3-4c6f-b37e-01182825968c',
    rmsElementUid: '130c4db5-a9b3-4c6f-b37e-01182825968c',
    dataSourceUid: '493d5e72-6f08-4da0-9fa7-bfd88e202a82',
    requires: [
        'B4.form.PickerField',
        'B4.model.DepartmentsTypeListModel',
        'B4.model.OrganizationListModel',
        'B4.view.DepartmentsPositionsList',
        'B4.view.DepartmentsTypeList',
        'B4.view.OrganizationList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 600,
            width: 600
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'Departments_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Organization',
        'modelProperty': 'Departments_Organization',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Name',
        'modelProperty': 'Departments_Name',
        'type': 'TextField'
    }, {
        'dataIndex': 'Type',
        'modelProperty': 'Departments_Type',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'Departments_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '130c4db5-a9b3-4c6f-b37e-01182825968c-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'DepartmentsEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-252feb6e-92b6-4ea3-81be-8c6463bc472f',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-d3108992-1d31-4f9a-aa26-2f155c513a1a',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://493d5e72-6f08-4da0-9fa7-bfd88e202a82$4232236c-1a3f-44b0-9871-c455627e996f',
                    'editable': false,
                    'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-90129f07-21b7-4503-91d6-ca0217b398e0',
                    'fieldLabel': 'Организация',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrganizationList',
                    'listViewCtl': 'B4.controller.OrganizationList',
                    'maximizable': true,
                    'model': 'B4.model.OrganizationListModel',
                    'modelProperty': 'Departments_Organization',
                    'name': 'Organization',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '90129f07-21b7-4503-91d6-ca0217b398e0',
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
                'rmsUid': 'd3108992-1d31-4f9a-aa26-2f155c513a1a',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '252feb6e-92b6-4ea3-81be-8c6463bc472f',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-2d21ead1-363e-46b3-ba6c-b350c95b6350',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-2b38bf39-2402-48c8-8a17-b517e9baee2b',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://493d5e72-6f08-4da0-9fa7-bfd88e202a82$31eb0ef3-24ba-477d-a32e-31fa9d658932',
                    'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-4ca0d1ef-3e33-4fdc-b1ca-99e934fc0588',
                    'fieldLabel': 'Наименование',
                    'labelAlign': 'top',
                    'modelProperty': 'Departments_Name',
                    'name': 'Name',
                    'rmsUid': '4ca0d1ef-3e33-4fdc-b1ca-99e934fc0588',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': '2b38bf39-2402-48c8-8a17-b517e9baee2b',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '2d21ead1-363e-46b3-ba6c-b350c95b6350',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-102d10ce-4ad3-452f-b28f-ef51114f1d56',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-aa85a36c-1200-4951-a939-e1f2b4b32eb9',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://493d5e72-6f08-4da0-9fa7-bfd88e202a82$f4affac2-1b88-4f95-8f8c-ad4c66ba22bd',
                    'editable': false,
                    'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-53e57f8a-2b2d-4fde-92bd-2b7d4ebdad54',
                    'fieldLabel': 'Вид',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.DepartmentsTypeList',
                    'listViewCtl': 'B4.controller.DepartmentsTypeList',
                    'maximizable': true,
                    'model': 'B4.model.DepartmentsTypeListModel',
                    'modelProperty': 'Departments_Type',
                    'name': 'Type',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '53e57f8a-2b2d-4fde-92bd-2b7d4ebdad54',
                    'textProperty': 'Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Вид',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'aa85a36c-1200-4951-a939-e1f2b4b32eb9',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '102d10ce-4ad3-452f-b28f-ef51114f1d56',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-007b9845-553e-4c77-849d-c97bc0d53a20',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-b2e5f796-77af-46f0-8aa2-abcc2091bbd9',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://493d5e72-6f08-4da0-9fa7-bfd88e202a82$d577bb47-5437-47b1-8c10-65d243db1f04',
                    'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-cf3778c4-1dd0-40bd-b58d-a56e2cc1dc07',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'Departments_Comment',
                    'name': 'Comment',
                    'rmsUid': 'cf3778c4-1dd0-40bd-b58d-a56e2cc1dc07',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': 'b2e5f796-77af-46f0-8aa2-abcc2091bbd9',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '007b9845-553e-4c77-849d-c97bc0d53a20',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-b2dc4bf2-6d28-4279-9cfe-2ad2fefc4775',
            'fieldLabel': 'Панель закладок',
            'flex': 1,
            'header': false,
            'items': [{
                'dockedItems': [],
                'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-42134958-1749-4f8b-a485-ed2b1d96d3b8',
                'fieldLabel': 'Должности',
                'flex': 1,
                'iconCls': 'fad fa-clipboard-user',
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
                                "DataIndex": "FieldPath://1cbc241a-85e4-47db-964b-6bec69dec86c$403e67cf-fb18-4e44-8066-e9987352fdc0$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@Departments_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-130c4db5-a9b3-4c6f-b37e-01182825968c-20ff84c6-cf96-4b38-8267-bd951a6cb743',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'DepartmentsPositionsList',
                    'region': 'Center',
                    'rmsUid': '20ff84c6-cf96-4b38-8267-bd951a6cb743',
                    'title': null,
                    'xtype': 'rms-departmentspositionslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '42134958-1749-4f8b-a485-ed2b1d96d3b8',
                'title': 'Должности',
                'xtype': 'container'
            }],
            'layout': {
                'type': 'fit'
            },
            'region': 'Center',
            'rmsUid': 'b2dc4bf2-6d28-4279-9cfe-2ad2fefc4775',
            'title': null,
            'xtype': 'tabpanel'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'Departments_Id',
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
        me.grid_DepartmentsPositionsList = me.down('rms-departmentspositionslist[name=DepartmentsPositionsList]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Добавление подразделения');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        if (Ext.isNumber(entityId) && entityId > 0) {
            me.setTitle(rec.get('Name'));
        }
        return res;
    },
});