Ext.define('B4.view.ObjectsDocumentsList', {
    'alias': 'widget.rms-objectsdocumentslist',
    'dataSourceUid': 'f83926a7-db81-4655-acb3-9a95778fe130',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ObjectsDocumentsListModel',
    'rmsElementUid': '4bf4ac40-fac3-4c39-ac42-cfb6999a05b8',
    'rmsUid': '4bf4ac40-fac3-4c39-ac42-cfb6999a05b8',
    'stateful': false,
    'title': 'Документы.Объект',
    requires: [
        'B4.model.ObjectsDocumentsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-4bf4ac40-fac3-4c39-ac42-cfb6999a05b8-b1ff6913-e26e-4034-a59f-432a52f3682f',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'b1ff6913-e26e-4034-a59f-432a52f3682f',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-4bf4ac40-fac3-4c39-ac42-cfb6999a05b8-d8085c88-07cc-4cc6-b7ca-52fb65a54858',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-ObjectsDocumentsEditor-InWindow',
        'rmsUid': 'd8085c88-07cc-4cc6-b7ca-52fb65a54858',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-4bf4ac40-fac3-4c39-ac42-cfb6999a05b8-2d5699ee-22ff-42ad-8e88-e4d31a8c4a88',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-ObjectsDocumentsEditor-InWindow',
        'rmsUid': '2d5699ee-22ff-42ad-8e88-e4d31a8c4a88',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-4bf4ac40-fac3-4c39-ac42-cfb6999a05b8-d104da0a-66f2-4d34-8ad1-f26e5fbcd852',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'd104da0a-66f2-4d34-8ad1-f26e5fbcd852',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://f83926a7-db81-4655-acb3-9a95778fe130$21f62c7f-c180-4905-be66-eecf1438515e',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'ea8c0461-96ee-4284-966d-659d7545709b',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'File',
                'dataIndexAbsoluteUid': 'FieldPath://f83926a7-db81-4655-acb3-9a95778fe130$76347bed-514a-4aef-861c-7cc3a41c8750',
                'decimalPrecision': 2,
                'filter': false,
                'inlineExtensions': 'pdf',
                'menuDisabled': false,
                'rmsUid': '18613b58-082a-4e6e-9404-b4d545ef4474',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Скачать',
                'width': 80,
                'xtype': 'b4filecolumn'
            }, {
                'dataIndex': 'ObjectWork_Id',
                'dataIndexAbsoluteUid': 'FieldPath://f83926a7-db81-4655-acb3-9a95778fe130$58f67435-6a62-4318-9ff7-af5953ffa9a6$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'ObjectWork.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': '3331e6b3-479f-47cd-82af-735a78af9d66',
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