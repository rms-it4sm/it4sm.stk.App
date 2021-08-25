Ext.define('B4.view.ObjectProductsList', {
    'alias': 'widget.rms-objectproductslist',
    'dataSourceUid': 'c4895819-2171-42e1-bde2-d4fa83104bbd',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ObjectProductsListModel',
    'rmsElementUid': '218a4715-916c-405e-8a50-bbc28a353328',
    'rmsUid': '218a4715-916c-405e-8a50-bbc28a353328',
    'stateful': false,
    'title': 'Спецификация.Объект',
    requires: [
        'B4.model.ObjectProductsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-218a4715-916c-405e-8a50-bbc28a353328-ab774c8a-c985-403e-9b5e-16700b4fe11c',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'ab774c8a-c985-403e-9b5e-16700b4fe11c',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-218a4715-916c-405e-8a50-bbc28a353328-7ad1fc3c-8526-4378-9854-199173a7dc04',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-ObjectProductsEditor-InWindow',
        'rmsUid': '7ad1fc3c-8526-4378-9854-199173a7dc04',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-218a4715-916c-405e-8a50-bbc28a353328-f2281ac5-bfdc-4de9-9a45-c25945157fe4',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-ObjectProductsEditor-InWindow',
        'rmsUid': 'f2281ac5-bfdc-4de9-9a45-c25945157fe4',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-218a4715-916c-405e-8a50-bbc28a353328-0bc7c728-29e3-48c6-aefc-e5483284bad2',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '0bc7c728-29e3-48c6-aefc-e5483284bad2',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Code',
                'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$3b80eac1-dd79-421e-a6ea-301b5a8fa395',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '73b87ddd-1e4e-4b85-8559-ee77d420cd1d',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Код элемента',
                'width': 150,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'TypeElement_Name',
                'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$6937d6ae-a06f-4475-a391-7b5aced09f7f$b90e9798-469f-4de2-a64a-577dbe42640d',
                'dataIndexRelativePath': 'TypeElement.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '613aeeb7-ee64-4a4f-bba3-7aa2bbcb1b98',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Тип элемента',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Quantity',
                'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$ba306dc3-b0fd-4722-b546-acec6b81d4bf',
                'decimalPrecision': 2,
                'filter': true,
                'format': '0',
                'menuDisabled': false,
                'rmsUid': 'b67d6103-67f8-4a2c-8cf6-7a2ea052fc55',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Кол-во',
                'width': 150,
                'xtype': 'numbercolumn'
            }, {
                'dataIndex': 'UnitMeasure_CutName',
                'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$6f5c0ee8-5e92-42ad-8883-eba7cf11b2ab$ec1108d2-98bb-48b7-ad5a-6185dc2ccf2a',
                'dataIndexRelativePath': 'UnitMeasure.CutName',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '3a8e1477-abd7-478f-a3a4-f93818d24423',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Ед. изм.',
                'width': 150,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$593432ba-2fc0-4d71-9ed9-d67fd0a9970f',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '65730777-0002-4365-bd20-eef2995844c1',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'ObjectOrder_Id',
                'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$834b602a-f4f4-4943-be32-d82c58e50ce7$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'ObjectOrder.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'b2aa66f5-eda5-4d8d-8ccc-7e16f38d5d9f',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Объект.Идентификатор',
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