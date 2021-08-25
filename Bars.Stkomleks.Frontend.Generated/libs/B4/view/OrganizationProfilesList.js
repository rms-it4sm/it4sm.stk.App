Ext.define('B4.view.OrganizationProfilesList', {
    'alias': 'widget.rms-organizationprofileslist',
    'dataSourceUid': '2f3cc7da-d8a3-4c53-b83f-ec26f028202e',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrganizationProfilesListModel',
    'rmsElementUid': '48cb21c4-9e41-4893-8056-c81344d7e489',
    'rmsUid': '48cb21c4-9e41-4893-8056-c81344d7e489',
    'stateful': false,
    'title': 'Профили.Организация',
    requires: [
        'B4.model.OrganizationProfilesListModel',
        'B4.ux.grid.plugin.StyleConditions',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-48cb21c4-9e41-4893-8056-c81344d7e489-6ceeb797-4f32-4f9a-b924-8a5e0474792c',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '6ceeb797-4f32-4f9a-b924-8a5e0474792c',
        'text': 'Обновить'
    }, {
        'actionName': 'multiadd',
        'extraCls': 'cmp-style-48cb21c4-9e41-4893-8056-c81344d7e489-a472d882-baaf-4085-90e0-7c7dffa14f80',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'MultiAddition-OrganizationProfilesListMultiAddByOrganizationEditor-InWindow',
        'rmsUid': 'a472d882-baaf-4085-90e0-7c7dffa14f80',
        'text': 'Выбрать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-48cb21c4-9e41-4893-8056-c81344d7e489-0900ef43-d385-4759-a021-71dbafdaa792',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '0900ef43-d385-4759-a021-71dbafdaa792',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Organization_Id',
                'dataIndexAbsoluteUid': 'FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$e0a08ecf-f833-461a-8b0d-8d7e5d4e4778$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Organization.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'dc2bd87a-ff12-4eb0-b69a-38f38fd8d625',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Организация.Идентификатор',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Profile_Name',
                'dataIndexAbsoluteUid': 'FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$5258c478-6f02-425d-a14e-025882b1b6c0$f44c4209-af60-444a-a056-671a5255de8d',
                'dataIndexRelativePath': 'Profile.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '901e4efa-b5ec-4754-b117-2b7c717a19f6',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Профиль',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Organization_Name',
                'dataIndexAbsoluteUid': 'FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$e0a08ecf-f833-461a-8b0d-8d7e5d4e4778$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                'dataIndexRelativePath': 'Organization.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'e7d95c71-8599-4e6d-8619-71ca43a0703d',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Организация',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'ptype': 'gridfilters',
                'renderHidden': false,
                'showClearAllButton': false,
                'showShowHideButton': false
            }, {
                'conditions': [],
                'ptype': 'gridStyleConditions'
            }]
        });
        me.callParent(arguments);
    }
});