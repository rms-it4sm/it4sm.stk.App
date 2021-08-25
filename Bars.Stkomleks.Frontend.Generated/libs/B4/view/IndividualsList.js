Ext.define('B4.view.IndividualsList', {
    'alias': 'widget.rms-individualslist',
    'dataSourceUid': '49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.IndividualsListModel',
    'rmsElementUid': '33f0a694-0fd2-4fee-9b06-8b6a2d5f9fa4',
    'rmsUid': '33f0a694-0fd2-4fee-9b06-8b6a2d5f9fa4',
    'stateful': false,
    'title': 'Физические лица',
    requires: [
        'B4.model.IndividualsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-33f0a694-0fd2-4fee-9b06-8b6a2d5f9fa4-a56c989d-262a-49f5-9a51-8f4b389e1dbb',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'a56c989d-262a-49f5-9a51-8f4b389e1dbb',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-33f0a694-0fd2-4fee-9b06-8b6a2d5f9fa4-099a7e3d-9176-4747-9914-61e66923e2ae',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-IndividualsEditor-InWindow',
        'rmsUid': '099a7e3d-9176-4747-9914-61e66923e2ae',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-33f0a694-0fd2-4fee-9b06-8b6a2d5f9fa4-6c8049b5-feb5-4a97-a6e8-794ece38ec52',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-IndividualsEditor-InWindow',
        'rmsUid': '6c8049b5-feb5-4a97-a6e8-794ece38ec52',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-33f0a694-0fd2-4fee-9b06-8b6a2d5f9fa4-a64d079c-fdda-4b95-814f-6a1a0f9e295b',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'a64d079c-fdda-4b95-814f-6a1a0f9e295b',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'FIO',
                'dataIndexAbsoluteUid': 'FieldPath://49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d$9eb7280e-5e7f-4c39-b975-ad80302db2f6',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '1e5d7cd4-bd4c-4abd-9b2e-e06caa0811f2',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'ФИО',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d$6921b320-087a-421a-804d-0506c8838012',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '160acee7-01fc-4be0-a0b4-2c2578b1995a',
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
            }]
        });
        me.callParent(arguments);
    }
});