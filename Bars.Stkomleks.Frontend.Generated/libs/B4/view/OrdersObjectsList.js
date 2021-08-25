Ext.define('B4.view.OrdersObjectsList', {
    'alias': 'widget.rms-ordersobjectslist',
    'dataSourceUid': 'aa6ab35e-8dca-491d-8261-0bf3c834ab3b',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrdersObjectsListModel',
    'rmsElementUid': '503f008d-4c32-4e29-a3e4-536c5dbab2a4',
    'rmsUid': '503f008d-4c32-4e29-a3e4-536c5dbab2a4',
    'stateful': false,
    'title': 'Объекты.Заказ',
    'wrapTextOnSelection': true,
    requires: [
        'B4.form.StateContextMenuColumn',
        'B4.model.OrdersObjectsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-503f008d-4c32-4e29-a3e4-536c5dbab2a4-c349118c-3c7d-4019-9762-910a0704d095',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'c349118c-3c7d-4019-9762-910a0704d095',
        'text': 'Обновить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-503f008d-4c32-4e29-a3e4-536c5dbab2a4-8966b238-d05c-44f2-a9e2-a1392b33b788',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-OrdersObjectsEditor_Copy_0-Default',
        'rmsUid': '8966b238-d05c-44f2-a9e2-a1392b33b788',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-503f008d-4c32-4e29-a3e4-536c5dbab2a4-ee45efb6-6696-4c3f-9fa8-55b2702880b3',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'ee45efb6-6696-4c3f-9fa8-55b2702880b3',
        'text': 'Удалить'
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
                'dataIndex': 'Type_Name',
                'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$a861dd69-8067-4c54-a160-4086f003580f$dfde2099-4a59-4d2f-8d32-43143b4ec043',
                'dataIndexRelativePath': 'Type.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': 'ada74523-c77d-4ed2-9ce2-c24a772cb8b7',
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
                'rmsUid': '52451e79-6189-4cad-a6c8-34f7c3dc6bb9',
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
                'rmsUid': '753efc67-8713-4eaa-8915-5e41ff0edf70',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Type_Id',
                'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$a861dd69-8067-4c54-a160-4086f003580f$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Type.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'a8a9e464-a41f-4472-8ba3-5c0767f116d5',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Тип.Идентификатор',
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