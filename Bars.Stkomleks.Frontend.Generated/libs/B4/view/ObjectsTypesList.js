Ext.define('B4.view.ObjectsTypesList', {
    'alias': 'widget.rms-objectstypeslist',
    'dataSourceUid': '0140e24b-1df6-4672-8302-a2a0cada0e53',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ObjectsTypesListModel',
    'rmsElementUid': 'fc7e521c-af45-4f93-8368-b267ae1c7667',
    'rmsUid': 'fc7e521c-af45-4f93-8368-b267ae1c7667',
    'stateful': false,
    'title': 'Типы объектов',
    requires: [
        'B4.model.ObjectsTypesListModel'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-fc7e521c-af45-4f93-8368-b267ae1c7667-aac068b2-a466-45ea-b56e-26eedac3a495',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'aac068b2-a466-45ea-b56e-26eedac3a495',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-fc7e521c-af45-4f93-8368-b267ae1c7667-d1f8a1dc-7ece-4ccf-8823-86701d0f7a67',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-ObjectsTypesEditor-InWindow',
        'rmsUid': 'd1f8a1dc-7ece-4ccf-8823-86701d0f7a67',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-fc7e521c-af45-4f93-8368-b267ae1c7667-6fc9be60-7696-4f81-a2d0-c2ddc8dd3e30',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-ObjectsTypesEditor-InWindow',
        'rmsUid': '6fc9be60-7696-4f81-a2d0-c2ddc8dd3e30',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-fc7e521c-af45-4f93-8368-b267ae1c7667-3c3e74a4-c321-4734-a142-fa7428ff6a83',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '3c3e74a4-c321-4734-a142-fa7428ff6a83',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://0140e24b-1df6-4672-8302-a2a0cada0e53$dfde2099-4a59-4d2f-8d32-43143b4ec043',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'e085bd2e-2e5b-4c0c-a890-86cd80892916',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'IconObjectType',
                'dataIndexAbsoluteUid': 'FieldPath://0140e24b-1df6-4672-8302-a2a0cada0e53$378de02a-7f1a-4c7b-95b3-50300ef739fc',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '7393a213-1de7-47fb-aad2-263a6ac4a0bb',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Иконка',
                'width': 150,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'ColorIconObjectType',
                'dataIndexAbsoluteUid': 'FieldPath://0140e24b-1df6-4672-8302-a2a0cada0e53$636a1f06-c235-4cd7-b3e3-3bdbf248e0cf',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '529cf857-5551-4fbf-a311-f9bdb7449237',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Цвет',
                'width': 150,
                'xtype': 'gridcolumn'
            }],
            plugins: []
        });
        me.callParent(arguments);
    }
});