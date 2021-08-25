Ext.define('B4.view.DepartmentsList', {
    'alias': 'widget.rms-departmentslist',
    'dataSourceUid': '493d5e72-6f08-4da0-9fa7-bfd88e202a82',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.DepartmentsListModel',
    'rmsElementUid': 'bdc47f6f-8733-41c3-a5d1-5d42d7af5594',
    'rmsUid': 'bdc47f6f-8733-41c3-a5d1-5d42d7af5594',
    'stateful': false,
    'title': 'Подразделения.Организация',
    requires: [
        'B4.model.DepartmentsListModel',
        'B4.ux.grid.plugin.StyleConditions',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-bdc47f6f-8733-41c3-a5d1-5d42d7af5594-27661cbf-b1d4-4b4e-a5f8-4b1222935d29',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '27661cbf-b1d4-4b4e-a5f8-4b1222935d29',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-bdc47f6f-8733-41c3-a5d1-5d42d7af5594-c32cc702-fdee-4471-af38-785b07caf883',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-DepartmentsEditor-InWindow',
        'rmsUid': 'c32cc702-fdee-4471-af38-785b07caf883',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-bdc47f6f-8733-41c3-a5d1-5d42d7af5594-65f71078-208c-4157-a170-15ad5aa14a7a',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-DepartmentsEditor-InWindow',
        'rmsUid': '65f71078-208c-4157-a170-15ad5aa14a7a',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-bdc47f6f-8733-41c3-a5d1-5d42d7af5594-ef4b210b-d932-4ef5-8397-0a3495e3c791',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'ef4b210b-d932-4ef5-8397-0a3495e3c791',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://493d5e72-6f08-4da0-9fa7-bfd88e202a82$31eb0ef3-24ba-477d-a32e-31fa9d658932',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '12957709-1018-44d5-b00a-6f45fd58876e',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Type_Name',
                'dataIndexAbsoluteUid': 'FieldPath://493d5e72-6f08-4da0-9fa7-bfd88e202a82$f4affac2-1b88-4f95-8f8c-ad4c66ba22bd$565ee7fe-e001-406e-b048-35966b4b3f67',
                'dataIndexRelativePath': 'Type.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '41cfa364-2925-44a2-a571-02328fb371e0',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Вид',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://493d5e72-6f08-4da0-9fa7-bfd88e202a82$d577bb47-5437-47b1-8c10-65d243db1f04',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'b75abce6-1085-4c04-947d-5978bcfb680e',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Organization_Id',
                'dataIndexAbsoluteUid': 'FieldPath://493d5e72-6f08-4da0-9fa7-bfd88e202a82$4232236c-1a3f-44b0-9871-c455627e996f$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Organization.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'c427a2cd-e03b-4dfc-b39c-2e7b1c350fad',
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
            }, {
                'conditions': [],
                'ptype': 'gridStyleConditions'
            }]
        });
        me.callParent(arguments);
    }
});