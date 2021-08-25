Ext.define('B4.view.ContactsTypeList', {
    'alias': 'widget.rms-contactstypelist',
    'dataSourceUid': 'a94c08c3-bfc2-4c72-ae81-c082487d5588',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ContactsTypeListModel',
    'rmsElementUid': '48303e21-0e2e-4ecc-9c5a-1f32519b2ff9',
    'rmsUid': '48303e21-0e2e-4ecc-9c5a-1f32519b2ff9',
    'stateful': false,
    'title': 'Типы контактов',
    requires: [
        'B4.model.ContactsTypeListModel',
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
        'extraCls': 'cmp-style-48303e21-0e2e-4ecc-9c5a-1f32519b2ff9-3a89ccd8-3bb5-4757-8b07-7c1ab0befcb0',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '3a89ccd8-3bb5-4757-8b07-7c1ab0befcb0',
        'text': 'Обновить'
    }, {
        'actionName': 'inline-add',
        'extraCls': 'cmp-style-48303e21-0e2e-4ecc-9c5a-1f32519b2ff9-22211fca-d778-4e63-9b1f-d00b356c22cf',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Add',
        'rmsUid': '22211fca-d778-4e63-9b1f-d00b356c22cf',
        'text': 'Добавить',
        'xtype': 'b4addbutton'
    }, {
        'actionName': 'inline-edit',
        'extraCls': 'cmp-style-48303e21-0e2e-4ecc-9c5a-1f32519b2ff9-086446f0-ce86-42eb-bef4-80b0d65b46a0',
        'hidden': false,
        'iconCls': 'icon-edit',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Edit',
        'rmsUid': '086446f0-ce86-42eb-bef4-80b0d65b46a0',
        'text': 'Редактировать',
        'xtype': 'b4editbutton'
    }, {
        'actionName': 'save',
        'extraCls': 'cmp-style-48303e21-0e2e-4ecc-9c5a-1f32519b2ff9-99e4634e-db49-4f7a-80aa-8a4bb233db71',
        'hidden': false,
        'iconCls': 'icon-save',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'SaveAll',
        'rmsUid': '99e4634e-db49-4f7a-80aa-8a4bb233db71',
        'text': 'Сохранить',
        'xtype': 'b4savebutton'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-48303e21-0e2e-4ecc-9c5a-1f32519b2ff9-8e5538af-4ae5-4c5b-b2d4-ce28d808504f',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '8e5538af-4ae5-4c5b-b2d4-ce28d808504f',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://a94c08c3-bfc2-4c72-ae81-c082487d5588$baf7c554-f6dd-4fa0-911e-22d7d5c06cb4',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'ee0af2da-1270-4785-acc1-1dcb8f4d1785',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'cellediting': 'cellediting-contactstypelist',
                'clicksToEdit': -1,
                'ptype': 'cellediting'
            }]
        });
        me.callParent(arguments);
    }
});