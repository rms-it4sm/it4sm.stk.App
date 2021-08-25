Ext.define('B4.view.ProductsList', {
    'alias': 'widget.rms-productslist',
    'dataSourceUid': '59c0f660-c442-4e9a-8772-a97243000d48',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ProductsListModel',
    'rmsElementUid': 'b27e985c-2128-4576-a925-287ab689ba48',
    'rmsUid': 'b27e985c-2128-4576-a925-287ab689ba48',
    'stateful': false,
    'title': 'Комплектация.Элемент спецификации',
    requires: [
        'B4.model.ProductsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-b27e985c-2128-4576-a925-287ab689ba48-f8ef86c4-533a-4c55-adf6-0b7fb36c477a',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'f8ef86c4-533a-4c55-adf6-0b7fb36c477a',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-b27e985c-2128-4576-a925-287ab689ba48-3f7aaf28-5020-4b10-8b76-67c3ada5b8d1',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-ProductsEditor-InWindow',
        'rmsUid': '3f7aaf28-5020-4b10-8b76-67c3ada5b8d1',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-b27e985c-2128-4576-a925-287ab689ba48-9f5c36bc-bc38-4e26-85ab-2f1583bd0094',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-ProductsEditor-InWindow',
        'rmsUid': '9f5c36bc-bc38-4e26-85ab-2f1583bd0094',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-b27e985c-2128-4576-a925-287ab689ba48-d571cd0e-250f-4a14-9d50-692684225afd',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'd571cd0e-250f-4a14-9d50-692684225afd',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Code',
                'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$456f9a5a-a1e3-4657-8c32-0998de5c8ef0',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '175a67a3-1895-400c-832d-c42594a56900',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Артикул',
                'width': 100,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Product',
                'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$73f245ed-c7e5-4328-a973-ba959aba22f9',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'a0bd4594-cba1-4239-bda4-86f5d783ba28',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Товар',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Quantity',
                'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$fb54ae14-ffe8-4bda-9f02-635d225baa9a',
                'decimalPrecision': 2,
                'filter': true,
                'format': '0',
                'menuDisabled': false,
                'rmsUid': '10004bb1-2856-4151-9047-07345bc85944',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Кол-во',
                'width': 100,
                'xtype': 'numbercolumn'
            }, {
                'dataIndex': 'Supplier_Organization_Name',
                'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$45a5ab39-ea3e-4bf8-bb76-4e063c9b11e4$e0a08ecf-f833-461a-8b0d-8d7e5d4e4778$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                'dataIndexRelativePath': 'Supplier.Organization.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '2f41d228-0fa7-462d-8b74-b3c095a64863',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Поставщик',
                'width': 200,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'ObjectSpecification_Id',
                'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$3dcb8175-9311-4543-9aed-da77478ece62$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'ObjectSpecification.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'c00bc456-e803-4b75-8a70-68c4c24acf72',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Спецификация объекта.Идентификатор',
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