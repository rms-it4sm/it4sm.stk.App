Ext.define('B4.view.FundingProgramsList', {
    'alias': 'widget.rms-fundingprogramslist',
    'dataSourceUid': '60a5fdca-979f-4332-9a9e-9a1fbd66665a',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.FundingProgramsListModel',
    'rmsElementUid': '98fb8f30-8450-4f6b-b523-c7bbbb613896',
    'rmsUid': '98fb8f30-8450-4f6b-b523-c7bbbb613896',
    'stateful': false,
    'title': 'Программы финансирования',
    requires: [
        'B4.model.FundingProgramsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-98fb8f30-8450-4f6b-b523-c7bbbb613896-78708dd9-99f1-4e01-85be-640e8e4e3bca',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '78708dd9-99f1-4e01-85be-640e8e4e3bca',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-98fb8f30-8450-4f6b-b523-c7bbbb613896-2ddde25a-720e-4b2a-b5f7-a3261032c3fd',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-FundingProgramsEditor-InWindow',
        'rmsUid': '2ddde25a-720e-4b2a-b5f7-a3261032c3fd',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-98fb8f30-8450-4f6b-b523-c7bbbb613896-abad3c46-58ce-4369-ac3e-5d9dcf36f4b1',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-FundingProgramsEditor-InWindow',
        'rmsUid': 'abad3c46-58ce-4369-ac3e-5d9dcf36f4b1',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-98fb8f30-8450-4f6b-b523-c7bbbb613896-0fa2859c-87e0-4cd0-a1db-1db511400091',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '0fa2859c-87e0-4cd0-a1db-1db511400091',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://60a5fdca-979f-4332-9a9e-9a1fbd66665a$5b06b53c-a325-441c-862c-df36a87d0ea8',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '5c5919d7-f8a6-4db6-a7d9-ec98e7fa91f9',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://60a5fdca-979f-4332-9a9e-9a1fbd66665a$362312bc-a43c-4cd7-8545-9e944431d1cb',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 2,
                'menuDisabled': false,
                'rmsUid': '4dfe2176-b118-4e24-bd23-101568b91ac3',
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