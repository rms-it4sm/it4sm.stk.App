Ext.define('B4.view.PositionsTypesList', {
    'alias': 'widget.rms-positionstypeslist',
    'dataSourceUid': 'c3cd4337-81c8-466a-98ca-872e581dcf97',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.PositionsTypesListModel',
    'rmsElementUid': '737bdcf7-5e44-44a4-96dc-b4bd3152a50a',
    'rmsUid': '737bdcf7-5e44-44a4-96dc-b4bd3152a50a',
    'stateful': false,
    'title': 'Виды должностей',
    requires: [
        'B4.model.PositionsTypesListModel',
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
        'extraCls': 'cmp-style-737bdcf7-5e44-44a4-96dc-b4bd3152a50a-95b9e877-25d4-4f81-8ea0-04fca5e4b144',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '95b9e877-25d4-4f81-8ea0-04fca5e4b144',
        'text': 'Обновить'
    }, {
        'actionName': 'inline-add',
        'extraCls': 'cmp-style-737bdcf7-5e44-44a4-96dc-b4bd3152a50a-867482d4-2cbf-48ae-b63c-da6be18a9dae',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Add',
        'rmsUid': '867482d4-2cbf-48ae-b63c-da6be18a9dae',
        'text': 'Добавить',
        'xtype': 'b4addbutton'
    }, {
        'actionName': 'inline-edit',
        'extraCls': 'cmp-style-737bdcf7-5e44-44a4-96dc-b4bd3152a50a-e18ee3dd-5420-4712-ba48-ea32c6b5a968',
        'hidden': false,
        'iconCls': 'icon-edit',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Edit',
        'rmsUid': 'e18ee3dd-5420-4712-ba48-ea32c6b5a968',
        'text': 'Редактировать',
        'xtype': 'b4editbutton'
    }, {
        'actionName': 'save',
        'extraCls': 'cmp-style-737bdcf7-5e44-44a4-96dc-b4bd3152a50a-31788e69-e2ed-4f6c-98f6-4c496bc1c76e',
        'hidden': false,
        'iconCls': 'icon-save',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'SaveAll',
        'rmsUid': '31788e69-e2ed-4f6c-98f6-4c496bc1c76e',
        'text': 'Сохранить',
        'xtype': 'b4savebutton'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-737bdcf7-5e44-44a4-96dc-b4bd3152a50a-9a7141f2-3a6e-4693-b8e9-efebbcca1340',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '9a7141f2-3a6e-4693-b8e9-efebbcca1340',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://c3cd4337-81c8-466a-98ca-872e581dcf97$a4db7755-81d6-415e-83ff-dc5e999fc018',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '0ce82545-b89a-483a-acf5-7d6e3eae8dd4',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'cellediting': 'cellediting-positionstypeslist',
                'clicksToEdit': -1,
                'ptype': 'cellediting'
            }]
        });
        me.callParent(arguments);
    }
});