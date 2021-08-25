Ext.define('B4.view.ProductsTypesList', {
    'alias': 'widget.rms-productstypeslist',
    'dataSourceUid': 'c8da2215-8f85-4af6-bffa-8d66d53fd0cd',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ProductsTypesListModel',
    'rmsElementUid': '5af375bb-5a64-4d0c-a176-bea50230e573',
    'rmsUid': '5af375bb-5a64-4d0c-a176-bea50230e573',
    'stateful': false,
    'title': 'Типы продуктов',
    requires: [
        'B4.model.ProductsTypesListModel',
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
        'extraCls': 'cmp-style-5af375bb-5a64-4d0c-a176-bea50230e573-ddd49804-a04e-4d90-9128-558c7293c86f',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'ddd49804-a04e-4d90-9128-558c7293c86f',
        'text': 'Обновить'
    }, {
        'actionName': 'inline-add',
        'extraCls': 'cmp-style-5af375bb-5a64-4d0c-a176-bea50230e573-25b40c4d-5f3d-4fb2-a39e-c2f5fa68ddd1',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Add',
        'rmsUid': '25b40c4d-5f3d-4fb2-a39e-c2f5fa68ddd1',
        'text': 'Добавить',
        'xtype': 'b4addbutton'
    }, {
        'actionName': 'inline-edit',
        'extraCls': 'cmp-style-5af375bb-5a64-4d0c-a176-bea50230e573-93b2d556-f815-4538-b7e6-42f0d332e1b5',
        'hidden': false,
        'iconCls': 'icon-edit',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Edit',
        'rmsUid': '93b2d556-f815-4538-b7e6-42f0d332e1b5',
        'text': 'Редактировать',
        'xtype': 'b4editbutton'
    }, {
        'actionName': 'save',
        'extraCls': 'cmp-style-5af375bb-5a64-4d0c-a176-bea50230e573-25c6eca6-240b-4a02-947c-29686bcf40e7',
        'hidden': false,
        'iconCls': 'icon-save',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'SaveAll',
        'rmsUid': '25c6eca6-240b-4a02-947c-29686bcf40e7',
        'text': 'Сохранить',
        'xtype': 'b4savebutton'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-5af375bb-5a64-4d0c-a176-bea50230e573-a7863999-04b6-411b-84ae-6e4030ca1f00',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'a7863999-04b6-411b-84ae-6e4030ca1f00',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://c8da2215-8f85-4af6-bffa-8d66d53fd0cd$b90e9798-469f-4de2-a64a-577dbe42640d',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'db5d6f3e-8cc0-40db-8de1-74fe79561d99',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'cellediting': 'cellediting-productstypeslist',
                'clicksToEdit': -1,
                'ptype': 'cellediting'
            }]
        });
        me.callParent(arguments);
    }
});