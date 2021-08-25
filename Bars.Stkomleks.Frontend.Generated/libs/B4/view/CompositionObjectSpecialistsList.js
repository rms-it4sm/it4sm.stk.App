Ext.define('B4.view.CompositionObjectSpecialistsList', {
    'alias': 'widget.rms-compositionobjectspecialistslist',
    'dataSourceUid': 'e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.CompositionObjectSpecialistsListModel',
    'rmsElementUid': '937c5337-375e-4581-8bd2-24c49f8e9bd7',
    'rmsUid': '937c5337-375e-4581-8bd2-24c49f8e9bd7',
    'stateful': false,
    'title': 'Специалисты.Объект',
    requires: [
        'B4.model.CompositionObjectSpecialistsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-937c5337-375e-4581-8bd2-24c49f8e9bd7-34af89ec-2341-44ef-afb3-e9d8d7ffb1fc',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '34af89ec-2341-44ef-afb3-e9d8d7ffb1fc',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-937c5337-375e-4581-8bd2-24c49f8e9bd7-5ccc5abf-1919-4eea-9a16-5e6641a02d39',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-CompositionObjectSpecialistsEditor-InWindow',
        'rmsUid': '5ccc5abf-1919-4eea-9a16-5e6641a02d39',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-937c5337-375e-4581-8bd2-24c49f8e9bd7-4bf59d38-c1d1-498e-b1ef-0a9d70ed5aaf',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-CompositionObjectSpecialistsEditor-InWindow',
        'rmsUid': '4bf59d38-c1d1-498e-b1ef-0a9d70ed5aaf',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-937c5337-375e-4581-8bd2-24c49f8e9bd7-ba75b33a-740d-48d9-a5b0-7e7c5cdb5f8f',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'ba75b33a-740d-48d9-a5b0-7e7c5cdb5f8f',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Object_Id',
                'dataIndexAbsoluteUid': 'FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$4dfa5472-c553-43e8-b2e7-af1b34fab335$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Object.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'b9a4c01c-5ed8-4a8f-86a9-847bd0e149c3',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Объект.Идентификатор',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Role_Name',
                'dataIndexAbsoluteUid': 'FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$6a3ca1e4-f71f-453d-9fe6-9a9dbfd364ab$aa7fe838-9d6b-4fdf-b29c-e212b72b8f30',
                'dataIndexRelativePath': 'Role.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '5f14aa1f-de64-4ed1-9d50-a40577aa8808',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Роль',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Staff_DepartmentPosition_Position',
                'dataIndexAbsoluteUid': 'FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$fb8e963d-efd7-47e3-b908-21358bea5fcb$45701d0f-8b89-4f73-97ce-6b22afb0832e$ac773733-14e9-4469-920f-500782bb6cef',
                'dataIndexRelativePath': 'Staff.DepartmentPosition.Position',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '03e2b03b-e259-4b0b-bf8e-e73c7688f58a',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Должность',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Staff_Staff_Individual_FIO',
                'dataIndexAbsoluteUid': 'FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$fb8e963d-efd7-47e3-b908-21358bea5fcb$ae322edc-4521-4ff9-9d21-49d1aacb76da$2841e6bd-6760-4243-92b0-d26a48633898$9eb7280e-5e7f-4c39-b975-ad80302db2f6',
                'dataIndexRelativePath': 'Staff.Staff.Individual.FIO',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'c89ba115-2d29-4ddb-9903-98df16f3c898',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'ФИО',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$b3a7961a-bf00-4c1b-8dc4-13e207a3c9d9',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'afd58360-ea36-4f3e-ae9b-5770701f3461',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'ptype': 'gridfilters',
                'renderHidden': false,
                'showClearAllButton': false,
                'showShowHideButton': false
            }]
        });
        me.callParent(arguments);
    }
});