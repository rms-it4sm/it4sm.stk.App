Ext.define('B4.view.RelatedOrganizationsList', {
    'alias': 'widget.rms-relatedorganizationslist',
    'dataSourceUid': 'ba084c30-4998-4494-a718-d6eca64c6140',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.RelatedOrganizationsListModel',
    'rmsElementUid': '01d8c8b1-e594-4e37-82c3-393eef428677',
    'rmsUid': '01d8c8b1-e594-4e37-82c3-393eef428677',
    'stateful': false,
    'title': 'Связанные организации.Организация',
    requires: [
        'B4.model.RelatedOrganizationsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-01d8c8b1-e594-4e37-82c3-393eef428677-553a1fff-ac49-4e2c-bc06-fd1ae5518fbc',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '553a1fff-ac49-4e2c-bc06-fd1ae5518fbc',
        'text': 'Обновить'
    }, {
        'actionName': 'multiadd',
        'extraCls': 'cmp-style-01d8c8b1-e594-4e37-82c3-393eef428677-1bcf57c5-52d3-402a-923f-46a6681796e1',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'MultiAddition-RelatedOrganizationsListMultiAddByOrganizationEditor-InWindow',
        'rmsUid': '1bcf57c5-52d3-402a-923f-46a6681796e1',
        'text': 'Выбор'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Organization_Id',
                'dataIndexAbsoluteUid': 'FieldPath://ba084c30-4998-4494-a718-d6eca64c6140$42fbc98d-ab6c-474a-8a5e-74f8b1811518$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Organization.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'b7405679-38ac-4d94-884c-345c7afd65ba',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Организация.Идентификатор',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'RelatedOrg_Name',
                'dataIndexAbsoluteUid': 'FieldPath://ba084c30-4998-4494-a718-d6eca64c6140$21c4785e-e297-40c1-a26a-595bd3238a35$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                'dataIndexRelativePath': 'RelatedOrg.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '46d37f5c-5d79-44af-a495-791d4b6e7518',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Связанная организация',
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