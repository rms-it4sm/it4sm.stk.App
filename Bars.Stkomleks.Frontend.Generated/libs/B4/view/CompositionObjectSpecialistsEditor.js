Ext.define('B4.view.CompositionObjectSpecialistsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-compositionobjectspecialistseditor',
    title: 'Специалист объекта',
    rmsUid: '77a6afbc-c73b-4ee9-af30-3fa36d6a8a37',
    rmsElementUid: '77a6afbc-c73b-4ee9-af30-3fa36d6a8a37',
    dataSourceUid: 'e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2',
    requires: [
        'B4.form.PickerField',
        'B4.model.CurrentPositionsDepartmentsListModel',
        'B4.model.OrdersObjectsListModel',
        'B4.model.WorksRolesListModel',
        'B4.view.CurrentPositionsDepartmentsList',
        'B4.view.OrdersObjectsList',
        'B4.view.WorksRolesList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 235,
            width: 600
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'CompositionObjectSpecialists_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Object',
        'modelProperty': 'CompositionObjectSpecialists_Object',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Role',
        'modelProperty': 'CompositionObjectSpecialists_Role',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Staff',
        'modelProperty': 'CompositionObjectSpecialists_Staff',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'CompositionObjectSpecialists_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'CompositionObjectSpecialistsEditor-container',
        'layout': {
            'type': 'anchor'
        },
        'region': 'Center',
        items: [{
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-22e1a55e-1799-4907-a0c9-b93ed97833d6',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-4993d945-940d-4901-b68d-78e3682b72e8',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$4dfa5472-c553-43e8-b2e7-af1b34fab335',
                    'editable': false,
                    'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-ee6aac1d-7f16-447d-a4f8-d47f06134b29',
                    'fieldLabel': 'Объект',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrdersObjectsList',
                    'listViewCtl': 'B4.controller.OrdersObjectsList',
                    'maximizable': true,
                    'model': 'B4.model.OrdersObjectsListModel',
                    'modelProperty': 'CompositionObjectSpecialists_Object',
                    'name': 'Object',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'ee6aac1d-7f16-447d-a4f8-d47f06134b29',
                    'textProperty': 'Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Объект',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '4993d945-940d-4901-b68d-78e3682b72e8',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '22e1a55e-1799-4907-a0c9-b93ed97833d6',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-9deabe66-22c7-4df8-9b4d-2830828a3641',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-47844ddd-4b3a-45d0-9004-4477821359b1',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$6a3ca1e4-f71f-453d-9fe6-9a9dbfd364ab',
                    'editable': false,
                    'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-5d246691-97db-4aa2-a56d-1c4312ad6807',
                    'fieldLabel': 'Роль',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.WorksRolesList',
                    'listViewCtl': 'B4.controller.WorksRolesList',
                    'maximizable': true,
                    'model': 'B4.model.WorksRolesListModel',
                    'modelProperty': 'CompositionObjectSpecialists_Role',
                    'name': 'Role',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '5d246691-97db-4aa2-a56d-1c4312ad6807',
                    'textProperty': 'Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Роль',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '47844ddd-4b3a-45d0-9004-4477821359b1',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-b85781fa-72b3-4305-844c-2b17e89699ff',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$fb8e963d-efd7-47e3-b908-21358bea5fcb',
                    'editable': false,
                    'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-1c2fe304-8ce2-4934-94fe-83cade766219',
                    'fieldLabel': 'Сотрудник',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.CurrentPositionsDepartmentsList',
                    'listViewCtl': 'B4.controller.CurrentPositionsDepartmentsList',
                    'maximizable': true,
                    'model': 'B4.model.CurrentPositionsDepartmentsListModel',
                    'modelProperty': 'CompositionObjectSpecialists_Staff',
                    'name': 'Staff',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '1c2fe304-8ce2-4934-94fe-83cade766219',
                    'textProperty': 'Staff_Individual_FIO',
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
                'rmsUid': 'b85781fa-72b3-4305-844c-2b17e89699ff',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '9deabe66-22c7-4df8-9b4d-2830828a3641',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-933b9562-4578-4985-87ae-322f7eb6273a',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-96dcc776-97a0-4a2a-97b6-0ebd9e26dbcd',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$b3a7961a-bf00-4c1b-8dc4-13e207a3c9d9',
                    'extraCls': 'cmp-style-77a6afbc-c73b-4ee9-af30-3fa36d6a8a37-884058c1-498e-497b-8708-e894edb22a80',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'CompositionObjectSpecialists_Comment',
                    'name': 'Comment',
                    'rmsUid': '884058c1-498e-497b-8708-e894edb22a80',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': '96dcc776-97a0-4a2a-97b6-0ebd9e26dbcd',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '933b9562-4578-4985-87ae-322f7eb6273a',
            'xtype': 'container'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'CompositionObjectSpecialists_Id',
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
            me.setTitle('Добавление специалиста');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
});