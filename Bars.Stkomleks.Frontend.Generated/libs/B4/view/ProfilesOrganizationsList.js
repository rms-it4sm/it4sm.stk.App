Ext.define('B4.view.ProfilesOrganizationsList', {
    'alias': 'widget.rms-profilesorganizationslist',
    'dataSourceUid': '239223c0-de50-410c-8e79-bd1e57b91b4e',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ProfilesOrganizationsListModel',
    'rmsElementUid': '11e97eb6-e81f-43ad-9fbd-1dca834a10a5',
    'rmsUid': '11e97eb6-e81f-43ad-9fbd-1dca834a10a5',
    'stateful': false,
    'title': 'Профили организаций',
    requires: [
        'B4.model.ProfilesOrganizationsListModel',
        'B4.ux.button.Add',
        'B4.ux.button.Edit',
        'B4.ux.button.Save',
        'B4.ux.grid.column.*',
        'Ext.ux.CheckColumn'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-11e97eb6-e81f-43ad-9fbd-1dca834a10a5-8533a44a-5ee1-4873-b9d2-bfb1924951da',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '8533a44a-5ee1-4873-b9d2-bfb1924951da',
        'text': 'Обновить'
    }, {
        'actionName': 'inline-add',
        'extraCls': 'cmp-style-11e97eb6-e81f-43ad-9fbd-1dca834a10a5-48c7e427-c49a-4814-b021-313a98d2a9ce',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Add',
        'rmsUid': '48c7e427-c49a-4814-b021-313a98d2a9ce',
        'text': 'Добавить',
        'xtype': 'b4addbutton'
    }, {
        'actionName': 'inline-edit',
        'extraCls': 'cmp-style-11e97eb6-e81f-43ad-9fbd-1dca834a10a5-492cc5d4-55ad-4448-93b6-7f29194476ec',
        'hidden': false,
        'iconCls': 'icon-edit',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Edit',
        'rmsUid': '492cc5d4-55ad-4448-93b6-7f29194476ec',
        'text': 'Редактировать',
        'xtype': 'b4editbutton'
    }, {
        'actionName': 'save',
        'extraCls': 'cmp-style-11e97eb6-e81f-43ad-9fbd-1dca834a10a5-d64857ad-10d9-48de-9e79-f8b98c187c0f',
        'hidden': false,
        'iconCls': 'icon-save',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'SaveAll',
        'rmsUid': 'd64857ad-10d9-48de-9e79-f8b98c187c0f',
        'text': 'Сохранить',
        'xtype': 'b4savebutton'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-11e97eb6-e81f-43ad-9fbd-1dca834a10a5-319410d2-ad40-42ac-a2a3-0bea6d0843d2',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '319410d2-ad40-42ac-a2a3-0bea6d0843d2',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://239223c0-de50-410c-8e79-bd1e57b91b4e$f44c4209-af60-444a-a056-671a5255de8d',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '8561fb6c-599d-4447-bb41-bf10411b9cfc',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'cellediting': 'cellediting-profilesorganizationslist',
                'clicksToEdit': -1,
                'ptype': 'cellediting'
            }]
        });
        me.callParent(arguments);
    }
});