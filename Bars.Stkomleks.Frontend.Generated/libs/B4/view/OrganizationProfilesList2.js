Ext.define('B4.view.OrganizationProfilesList2', {
    'alias': 'widget.rms-organizationprofileslist2',
    'dataSourceUid': '2f3cc7da-d8a3-4c53-b83f-ec26f028202e',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrganizationProfilesList2Model',
    'rmsElementUid': 'e0e0f8f2-1a95-477b-9208-680d865acb04',
    'rmsUid': 'e0e0f8f2-1a95-477b-9208-680d865acb04',
    'stateful': false,
    'title': 'Организации по профилю.Выбор',
    requires: [
        'B4.model.OrganizationProfilesList2Model',
        'B4.ux.grid.plugin.StyleConditions',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-e0e0f8f2-1a95-477b-9208-680d865acb04-1e6d02dd-88ff-4d15-b40c-cfed76e7656f',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '1e6d02dd-88ff-4d15-b40c-cfed76e7656f',
        'text': 'Обновить'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-e0e0f8f2-1a95-477b-9208-680d865acb04-d5f31cae-0d00-4ab4-b1f0-1d24c6210dd8',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'd5f31cae-0d00-4ab4-b1f0-1d24c6210dd8',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Organization_Name',
                'dataIndexAbsoluteUid': 'FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$e0a08ecf-f833-461a-8b0d-8d7e5d4e4778$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                'dataIndexRelativePath': 'Organization.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '2d14fd93-6b32-45c6-bce2-b7e6810cbfc5',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Организация',
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
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': '6cf441dc-d81e-474a-82a0-1612faf155af',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Профиль.Наименование',
                'xtype': 'gridcolumn'
            }, {
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
                'rmsUid': '565de724-6828-4938-808f-88c4330d3cde',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Организация.Идентификатор',
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