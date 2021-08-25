Ext.define('B4.view.OrdersObjectsList2', {
    'alias': 'widget.rms-ordersobjectslist2',
    'dataSourceUid': 'aa6ab35e-8dca-491d-8261-0bf3c834ab3b',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrdersObjectsList2Model',
    'rmsElementUid': '1ba47c5b-e4cb-49ea-816d-4e3bf13995f2',
    'rmsUid': '1ba47c5b-e4cb-49ea-816d-4e3bf13995f2',
    'stateful': false,
    'title': 'Объекты',
    requires: [
        'B4.form.StateContextMenuColumn',
        'B4.model.OrdersObjectsList2Model',
        'B4.ux.grid.plugin.StyleConditions',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-1ba47c5b-e4cb-49ea-816d-4e3bf13995f2-806546d6-367d-48ea-aa05-bb794f1fc8e6',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '806546d6-367d-48ea-aa05-bb794f1fc8e6',
        'text': 'Обновить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-1ba47c5b-e4cb-49ea-816d-4e3bf13995f2-864cbdc3-a46d-4bc2-a480-9aad970e5991',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-OrdersObjectsEditor_Copy_0-Default',
        'rmsUid': '864cbdc3-a46d-4bc2-a480-9aad970e5991',
        'text': 'Редактировать'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': '_State',
                'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$d547b8fb-bba6-4d6d-aac0-9000a3d5a1a7',
                'stateTypeId': 'bars.stkomleks.ordersobjects',
                'xtype': 'b4statecontextmenucolumn'
            }, {
                'dataIndex': 'Order_Number',
                'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$b059c2ef-ece8-4541-8ca6-11a818c0a53a$2f3de072-33f6-492c-8016-a55598f69f32',
                'dataIndexRelativePath': 'Zakaz.Number',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': '8fecf90d-8196-44cc-97c2-17101aed4fb7',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Заказ',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Type_Name',
                'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$a861dd69-8067-4c54-a160-4086f003580f$dfde2099-4a59-4d2f-8d32-43143b4ec043',
                'dataIndexRelativePath': 'Type.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '49cf854a-e6b6-45f0-8b2d-8c1a620bdba0',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Тип',
                'width': 200,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$8abbde9d-6cd1-4f40-84e7-9d387c970f1b',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '6ecaa7b8-27cc-4f18-9724-f78b627fa33e',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$00da65d1-e495-4651-acbe-a299e13fef87',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'da674c47-22f8-4b19-bb18-5079277da5cd',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
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