Ext.define('B4.view.OrganizationFundingProgramsList', {
    'alias': 'widget.rms-organizationfundingprogramslist',
    'dataSourceUid': '0de41a18-2d17-4f59-b60b-e39e0559c240',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrganizationFundingProgramsListModel',
    'rmsElementUid': 'e8cec20f-24a8-4cc3-9a21-ebf7a34c9d41',
    'rmsUid': 'e8cec20f-24a8-4cc3-9a21-ebf7a34c9d41',
    'stateful': false,
    'title': 'Программы.Организация',
    requires: [
        'B4.model.OrganizationFundingProgramsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-e8cec20f-24a8-4cc3-9a21-ebf7a34c9d41-5c4bf8f5-1b1f-40f8-8b2b-ea4ff14e0e60',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '5c4bf8f5-1b1f-40f8-8b2b-ea4ff14e0e60',
        'text': 'Обновить'
    }, {
        'actionName': 'multiadd',
        'extraCls': 'cmp-style-e8cec20f-24a8-4cc3-9a21-ebf7a34c9d41-6da929c6-59b4-437b-8fc6-ad6cec6b69d5',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'MultiAddition-OrganizationFundingProgramsListMultiAddByOrganizationEditor-InWindow',
        'rmsUid': '6da929c6-59b4-437b-8fc6-ad6cec6b69d5',
        'text': 'Выбрать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-e8cec20f-24a8-4cc3-9a21-ebf7a34c9d41-11bc31c4-a362-438c-9943-5c20c0a611bc',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '11bc31c4-a362-438c-9943-5c20c0a611bc',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'FundingPrograms_Name',
                'dataIndexAbsoluteUid': 'FieldPath://0de41a18-2d17-4f59-b60b-e39e0559c240$f95a256b-5ae1-40f4-aa65-89e63c58f335$5b06b53c-a325-441c-862c-df36a87d0ea8',
                'dataIndexRelativePath': 'FundingPrograms.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'df401530-4f3e-4f03-a169-e41056470510',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Программа',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'FundingPrograms_Comment',
                'dataIndexAbsoluteUid': 'FieldPath://0de41a18-2d17-4f59-b60b-e39e0559c240$f95a256b-5ae1-40f4-aa65-89e63c58f335$362312bc-a43c-4cd7-8545-9e944431d1cb',
                'dataIndexRelativePath': 'FundingPrograms.Comment',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 2,
                'menuDisabled': false,
                'rmsUid': '81ad5fd7-60ec-4ff3-82e8-cc716eb86016',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Organization_Id',
                'dataIndexAbsoluteUid': 'FieldPath://0de41a18-2d17-4f59-b60b-e39e0559c240$a739203f-8f97-4e4a-b804-7d0a5ae76632$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Organization.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': '741c46f1-8961-4a39-83bf-af67f33ff550',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Организация.Идентификатор',
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