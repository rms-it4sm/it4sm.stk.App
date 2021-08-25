Ext.define('B4.view.TypesWorkTypesObjectsList', {
    'alias': 'widget.rms-typesworktypesobjectslist',
    'dataSourceUid': 'ceb87fbf-759c-4e7f-bc92-3a605d913ad5',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.TypesWorkTypesObjectsListModel',
    'rmsElementUid': 'b82a0d6b-eb8d-4bc0-8c3a-5a7d9bc46c18',
    'rmsUid': 'b82a0d6b-eb8d-4bc0-8c3a-5a7d9bc46c18',
    'stateful': false,
    'title': 'Виды работ.Тип объекта',
    'wrapTextOnSelection': true,
    requires: [
        'B4.model.TypesWorkTypesObjectsListModel'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-b82a0d6b-eb8d-4bc0-8c3a-5a7d9bc46c18-df1a3e76-d8fb-4da0-9033-eae5eba5c272',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'df1a3e76-d8fb-4da0-9033-eae5eba5c272',
        'text': 'Обновить'
    }, {
        'actionName': 'multiadd',
        'extraCls': 'cmp-style-b82a0d6b-eb8d-4bc0-8c3a-5a7d9bc46c18-9ec9a8b2-fbc7-42e1-9afa-fc49346bd080',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'MultiAddition-TypesWorkTypesObjectsListMultiAddByObjectTypeEditor-InWindow',
        'rmsUid': '9ec9a8b2-fbc7-42e1-9afa-fc49346bd080',
        'text': 'Выбрать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-b82a0d6b-eb8d-4bc0-8c3a-5a7d9bc46c18-43a8ae87-b6a3-415c-88cd-939da432cf5c',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '43a8ae87-b6a3-415c-88cd-939da432cf5c',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'WorkType_Name',
                'dataIndexAbsoluteUid': 'FieldPath://ceb87fbf-759c-4e7f-bc92-3a605d913ad5$a027f406-10c4-4310-9fc3-d6f6fe0739de$a9294408-1e36-4617-9972-07c45c83ce2d',
                'dataIndexRelativePath': 'WorkType.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '3cdc2151-0b89-4cf1-ad88-1bee050680ff',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Виды работ',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'ObjectType_Id',
                'dataIndexAbsoluteUid': 'FieldPath://ceb87fbf-759c-4e7f-bc92-3a605d913ad5$851be698-95e0-465e-b419-95da45ec8f8b$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'ObjectType.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': '7bf62962-0c01-4bd1-84be-e6aec8532801',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Тип объекта.Идентификатор',
                'xtype': 'gridcolumn'
            }],
            plugins: []
        });
        me.callParent(arguments);
    }
});