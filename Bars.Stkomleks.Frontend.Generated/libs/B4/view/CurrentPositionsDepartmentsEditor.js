Ext.define('B4.view.CurrentPositionsDepartmentsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-currentpositionsdepartmentseditor',
    title: 'Занимаемая должность подразделения',
    rmsUid: '5384176d-011e-4051-a1ad-61487308dd00',
    rmsElementUid: '5384176d-011e-4051-a1ad-61487308dd00',
    dataSourceUid: '788a15f1-40ba-4144-b7a9-45ce08fb1ffc',
    requires: [
        'B4.form.PickerField',
        'B4.model.DepartmentsPositionsListModel',
        'B4.model.StaffListModel',
        'B4.view.DepartmentsPositionsList',
        'B4.view.StaffList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 295,
            width: 500
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'CurrentPositionsDepartments_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'DepartmentPosition',
        'modelProperty': 'CurrentPositionsDepartments_DepartmentPosition',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Staff',
        'modelProperty': 'CurrentPositionsDepartments_Staff',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Start',
        'modelProperty': 'CurrentPositionsDepartments_Start',
        'type': 'DateField'
    }, {
        'dataIndex': 'Finish',
        'modelProperty': 'CurrentPositionsDepartments_Finish',
        'type': 'DateField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'CurrentPositionsDepartments_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '5384176d-011e-4051-a1ad-61487308dd00-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'CurrentPositionsDepartmentsEditor-container',
        'layout': {
            'type': 'anchor'
        },
        'region': 'Center',
        items: [{
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-1b01cc1c-f044-4e5b-b79e-e068c861f4a6',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-1b40079b-2f81-4430-a969-406b80fc075c',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$45701d0f-8b89-4f73-97ce-6b22afb0832e',
                    'editable': false,
                    'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-ab8f4df2-bb87-4293-847e-d488615cdc83',
                    'fieldLabel': 'DepartmentPosition',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.DepartmentsPositionsList',
                    'listViewCtl': 'B4.controller.DepartmentsPositionsList',
                    'maximizable': true,
                    'model': 'B4.model.DepartmentsPositionsListModel',
                    'modelProperty': 'CurrentPositionsDepartments_DepartmentPosition',
                    'name': 'DepartmentPosition',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'ab8f4df2-bb87-4293-847e-d488615cdc83',
                    'textProperty': 'Position',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'DepartmentPosition',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '1b40079b-2f81-4430-a969-406b80fc075c',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '1b01cc1c-f044-4e5b-b79e-e068c861f4a6',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-44892e5c-0570-41ce-9d8a-712f226314a8',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-f67162d1-55e7-4592-bcb0-a1c81619f651',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$ae322edc-4521-4ff9-9d21-49d1aacb76da',
                    'editable': false,
                    'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-062171fa-0c1d-4fa5-b31e-3d325d0f344e',
                    'fieldLabel': 'Сотрудник',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.StaffList',
                    'listViewCtl': 'B4.controller.StaffList',
                    'maximizable': true,
                    'model': 'B4.model.StaffListModel',
                    'modelProperty': 'CurrentPositionsDepartments_Staff',
                    'name': 'Staff',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '062171fa-0c1d-4fa5-b31e-3d325d0f344e',
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
                'rmsUid': 'f67162d1-55e7-4592-bcb0-a1c81619f651',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '44892e5c-0570-41ce-9d8a-712f226314a8',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-20c597fd-c009-4605-85c6-dc30808a5e33',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-ed3077ec-c0a1-445a-b8b2-e0f9dde92149',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$970a73c8-7aa2-4627-aa61-f63efe1b404a',
                    'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-f0555789-6bc1-4662-b7ec-ed7a8187b0fb',
                    'fieldLabel': 'Начало',
                    'format': 'd.m.Y',
                    'labelAlign': 'top',
                    'modelProperty': 'CurrentPositionsDepartments_Start',
                    'name': 'Start',
                    'rmsUid': 'f0555789-6bc1-4662-b7ec-ed7a8187b0fb',
                    'xtype': 'datefield'
                }],
                'layout': 'anchor',
                'rmsUid': 'ed3077ec-c0a1-445a-b8b2-e0f9dde92149',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-a5b1bfe7-5ba6-47d3-a4bd-4c1967a6124a',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$38dc8ddd-3d66-42aa-a5b8-bf02e173b825',
                    'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-d7767b20-476e-488e-9317-271ff8beb4c9',
                    'fieldLabel': 'Завершение',
                    'format': 'd.m.Y',
                    'labelAlign': 'top',
                    'modelProperty': 'CurrentPositionsDepartments_Finish',
                    'name': 'Finish',
                    'rmsUid': 'd7767b20-476e-488e-9317-271ff8beb4c9',
                    'xtype': 'datefield'
                }],
                'layout': 'anchor',
                'rmsUid': 'a5b1bfe7-5ba6-47d3-a4bd-4c1967a6124a',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '20c597fd-c009-4605-85c6-dc30808a5e33',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-e43fbab4-eabc-47a4-90c8-1cc1f9cf7184',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-31479a70-3254-471f-a247-9b1ce1f3c821',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$7c4f9660-2d1a-45ef-92a6-23eba0557973',
                    'extraCls': 'cmp-style-5384176d-011e-4051-a1ad-61487308dd00-236ab0cb-e3d9-4611-a02c-670ae5464ea5',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'CurrentPositionsDepartments_Comment',
                    'name': 'Comment',
                    'rmsUid': '236ab0cb-e3d9-4611-a02c-670ae5464ea5',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': '31479a70-3254-471f-a247-9b1ce1f3c821',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'e43fbab4-eabc-47a4-90c8-1cc1f9cf7184',
            'xtype': 'container'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'CurrentPositionsDepartments_Id',
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
            me.setTitle('Добавление занимаемой должности');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
});