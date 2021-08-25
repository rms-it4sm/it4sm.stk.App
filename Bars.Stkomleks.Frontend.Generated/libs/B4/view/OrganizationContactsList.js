Ext.define('B4.view.OrganizationContactsList', {
    'alias': 'widget.rms-organizationcontactslist',
    'dataSourceUid': '2ab43a3b-81eb-4f93-8d61-eb1304c71200',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrganizationContactsListModel',
    'rmsElementUid': 'a2b814e9-17f9-4573-ac19-8787d7ae0bb4',
    'rmsUid': 'a2b814e9-17f9-4573-ac19-8787d7ae0bb4',
    'stateful': false,
    'title': 'Контакты.Организация',
    requires: [
        'B4.model.OrganizationContactsListModel'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-a2b814e9-17f9-4573-ac19-8787d7ae0bb4-9de2cdd4-2c27-48a7-944b-2a265fab6a85',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '9de2cdd4-2c27-48a7-944b-2a265fab6a85',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-a2b814e9-17f9-4573-ac19-8787d7ae0bb4-5193fa42-cc36-4d5b-a912-5b155780edab',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-OrganizationContactsEditor-InWindow',
        'rmsUid': '5193fa42-cc36-4d5b-a912-5b155780edab',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-a2b814e9-17f9-4573-ac19-8787d7ae0bb4-4fd70723-af69-4ad7-910f-235571882c1a',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-OrganizationContactsEditor-InWindow',
        'rmsUid': '4fd70723-af69-4ad7-910f-235571882c1a',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-a2b814e9-17f9-4573-ac19-8787d7ae0bb4-c0ff4520-0904-48df-87ab-a324d21e2ec6',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'c0ff4520-0904-48df-87ab-a324d21e2ec6',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Type_Name',
                'dataIndexAbsoluteUid': 'FieldPath://2ab43a3b-81eb-4f93-8d61-eb1304c71200$a386480f-9a10-4e5d-bb26-988e998fe6f2$baf7c554-f6dd-4fa0-911e-22d7d5c06cb4',
                'dataIndexRelativePath': 'Type.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '272e62f2-f97c-42e5-b0a0-25197e44d78e',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Тип',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Contact',
                'dataIndexAbsoluteUid': 'FieldPath://2ab43a3b-81eb-4f93-8d61-eb1304c71200$97085dd4-c3b0-426b-85d2-dcd4d324177f',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '0d53186d-6a69-482f-98d8-a5d357c7bcea',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Контакт',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://2ab43a3b-81eb-4f93-8d61-eb1304c71200$5a634474-ec51-4c7b-bdd6-654d0c2914e7',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 2,
                'menuDisabled': false,
                'rmsUid': '3e04c7cd-3dc1-4b8e-8690-e02cbe98e0f9',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Organization_Id',
                'dataIndexAbsoluteUid': 'FieldPath://2ab43a3b-81eb-4f93-8d61-eb1304c71200$56a4d0ab-d6fa-4f25-aab9-24b4e09fa869$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Organization.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'fd02eec9-cf92-423f-aa0a-c4faefce66d3',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Организация.Идентификатор',
                'xtype': 'gridcolumn'
            }],
            plugins: []
        });
        me.callParent(arguments);
    }
});