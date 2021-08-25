Ext.define('B4.view.WorksRolesList', {
    'alias': 'widget.rms-worksroleslist',
    'dataSourceUid': 'd8f32d3f-e219-467b-8b32-c0f3311a5e05',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.WorksRolesListModel',
    'rmsElementUid': '3cc7cd9d-1d25-4a00-a4fe-f9bcf904f1ab',
    'rmsUid': '3cc7cd9d-1d25-4a00-a4fe-f9bcf904f1ab',
    'stateful': false,
    'title': 'Роли в бригаде',
    requires: [
        'B4.model.WorksRolesListModel',
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
        'extraCls': 'cmp-style-3cc7cd9d-1d25-4a00-a4fe-f9bcf904f1ab-a0e9deab-be0a-4fca-b600-87a7f7200550',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'a0e9deab-be0a-4fca-b600-87a7f7200550',
        'text': 'Обновить'
    }, {
        'actionName': 'inline-add',
        'extraCls': 'cmp-style-3cc7cd9d-1d25-4a00-a4fe-f9bcf904f1ab-38f48abb-747d-4223-ac2f-b92901a55745',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Add',
        'rmsUid': '38f48abb-747d-4223-ac2f-b92901a55745',
        'text': 'Добавить',
        'xtype': 'b4addbutton'
    }, {
        'actionName': 'inline-edit',
        'extraCls': 'cmp-style-3cc7cd9d-1d25-4a00-a4fe-f9bcf904f1ab-a4d945c8-4523-4263-8886-ca16806ca0d5',
        'hidden': false,
        'iconCls': 'icon-edit',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Edit',
        'rmsUid': 'a4d945c8-4523-4263-8886-ca16806ca0d5',
        'text': 'Редактировать',
        'xtype': 'b4editbutton'
    }, {
        'actionName': 'save',
        'extraCls': 'cmp-style-3cc7cd9d-1d25-4a00-a4fe-f9bcf904f1ab-4ed3a91b-e690-402c-816f-48f33e0ed9c7',
        'hidden': false,
        'iconCls': 'icon-save',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'SaveAll',
        'rmsUid': '4ed3a91b-e690-402c-816f-48f33e0ed9c7',
        'text': 'Сохранить',
        'xtype': 'b4savebutton'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-3cc7cd9d-1d25-4a00-a4fe-f9bcf904f1ab-e331e042-6c7d-4ffe-9d5a-c2babcbfa41b',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'e331e042-6c7d-4ffe-9d5a-c2babcbfa41b',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://d8f32d3f-e219-467b-8b32-c0f3311a5e05$aa7fe838-9d6b-4fdf-b29c-e212b72b8f30',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '63fbc3c7-2042-4fad-a103-32b9d54b099b',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'cellediting': 'cellediting-worksroleslist',
                'clicksToEdit': -1,
                'ptype': 'cellediting'
            }]
        });
        me.callParent(arguments);
    }
});