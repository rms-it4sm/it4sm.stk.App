Ext.define('B4.view.DepartmentsPositionsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-departmentspositionseditor',
    title: 'Должность подразделения',
    rmsUid: '23beb68e-9c91-43c1-a435-257bf4e15d1b',
    rmsElementUid: '23beb68e-9c91-43c1-a435-257bf4e15d1b',
    dataSourceUid: '1cbc241a-85e4-47db-964b-6bec69dec86c',
    requires: [
        'B4.form.PickerField',
        'B4.model.DepartmentsListModel',
        'B4.model.PositionsTypesListModel',
        'B4.view.CurrentPositionsDepartmentsList',
        'B4.view.DepartmentsList',
        'B4.view.PositionsTypesList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 500,
            width: 700
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'DepartmentsPositions_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Department',
        'modelProperty': 'DepartmentsPositions_Department',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Type',
        'modelProperty': 'DepartmentsPositions_Type',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Position',
        'modelProperty': 'DepartmentsPositions_Position',
        'type': 'TextField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '23beb68e-9c91-43c1-a435-257bf4e15d1b-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'DepartmentsPositionsEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-6dc67697-1a9b-4d4e-9448-6de4e2abff17',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-aedad699-355f-4337-9bac-7a8a9a00db0e',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://1cbc241a-85e4-47db-964b-6bec69dec86c$403e67cf-fb18-4e44-8066-e9987352fdc0',
                    'editable': false,
                    'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-2c050fdb-4916-4e3d-b8da-508462e9600a',
                    'fieldLabel': 'Подразделение',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.DepartmentsList',
                    'listViewCtl': 'B4.controller.DepartmentsList',
                    'maximizable': true,
                    'model': 'B4.model.DepartmentsListModel',
                    'modelProperty': 'DepartmentsPositions_Department',
                    'name': 'Department',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '2c050fdb-4916-4e3d-b8da-508462e9600a',
                    'textProperty': 'Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Подразделение',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'aedad699-355f-4337-9bac-7a8a9a00db0e',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '6dc67697-1a9b-4d4e-9448-6de4e2abff17',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-111fe3a9-371f-4c8c-b646-08820c97eac7',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-d432ce3e-dbac-4387-a064-c039da78d73d',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://1cbc241a-85e4-47db-964b-6bec69dec86c$f176197f-28ae-4253-a228-0f5ef5df9aea',
                    'editable': false,
                    'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-6bebd2c4-d428-4333-8a9d-2357a439a91b',
                    'fieldLabel': 'Вид',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.PositionsTypesList',
                    'listViewCtl': 'B4.controller.PositionsTypesList',
                    'maximizable': true,
                    'model': 'B4.model.PositionsTypesListModel',
                    'modelProperty': 'DepartmentsPositions_Type',
                    'name': 'Type',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '6bebd2c4-d428-4333-8a9d-2357a439a91b',
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
                'rmsUid': 'd432ce3e-dbac-4387-a064-c039da78d73d',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-b340d761-aaa2-4c65-a18f-4fe566b0aaff',
                'flex': 2,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://1cbc241a-85e4-47db-964b-6bec69dec86c$ac773733-14e9-4469-920f-500782bb6cef',
                    'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-a3a81165-7954-4dcd-9e6e-e8da0f83eec2',
                    'fieldLabel': 'Должность',
                    'labelAlign': 'top',
                    'modelProperty': 'DepartmentsPositions_Position',
                    'name': 'Position',
                    'rmsUid': 'a3a81165-7954-4dcd-9e6e-e8da0f83eec2',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'b340d761-aaa2-4c65-a18f-4fe566b0aaff',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '111fe3a9-371f-4c8c-b646-08820c97eac7',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-81d8bd32-b275-4a56-922e-1253710ee6c8',
            'fieldLabel': 'Панель закладок',
            'flex': 1,
            'header': false,
            'items': [{
                'dockedItems': [],
                'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-61b36cb0-8751-48ab-9b52-d86fc01814b2',
                'fieldLabel': 'Сотрудники',
                'iconCls': 'fad fa-user-hard-hat',
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
                                "DataIndex": "FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$45701d0f-8b89-4f73-97ce-6b22afb0832e$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@DepartmentsPositions_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-23beb68e-9c91-43c1-a435-257bf4e15d1b-c2df756f-e4df-47c5-b7fd-a26e39693337',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'CurrentPositionsDepartmentsList',
                    'region': 'Center',
                    'rmsUid': 'c2df756f-e4df-47c5-b7fd-a26e39693337',
                    'title': null,
                    'xtype': 'rms-currentpositionsdepartmentslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '61b36cb0-8751-48ab-9b52-d86fc01814b2',
                'title': 'Сотрудники',
                'xtype': 'container'
            }],
            'layout': {
                'type': 'fit'
            },
            'region': 'Center',
            'rmsUid': '81d8bd32-b275-4a56-922e-1253710ee6c8',
            'title': null,
            'xtype': 'tabpanel'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'DepartmentsPositions_Id',
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
        me.grid_CurrentPositionsDepartmentsList = me.down('rms-currentpositionsdepartmentslist[name=CurrentPositionsDepartmentsList]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Добавление должности подразделения');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
});