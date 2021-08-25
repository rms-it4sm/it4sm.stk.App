Ext.define('B4.view.DepartmentsPositionsList', {
    'alias': 'widget.rms-departmentspositionslist',
    'dataSourceUid': '1cbc241a-85e4-47db-964b-6bec69dec86c',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.DepartmentsPositionsListModel',
    'rmsElementUid': 'e426d6c0-7d71-41fd-9a08-4914f84af209',
    'rmsUid': 'e426d6c0-7d71-41fd-9a08-4914f84af209',
    'stateful': false,
    'title': 'Должности.Подразделение',
    'wrapTextOnSelection': true,
    requires: [
        'B4.model.DepartmentsPositionsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-e426d6c0-7d71-41fd-9a08-4914f84af209-01dbb461-fe9c-4db6-8f6d-8b368769fda7',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '01dbb461-fe9c-4db6-8f6d-8b368769fda7',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-e426d6c0-7d71-41fd-9a08-4914f84af209-8bed812c-46ed-40d2-a33c-8999e73a1d2f',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-DepartmentsPositionsEditor-InWindow',
        'rmsUid': '8bed812c-46ed-40d2-a33c-8999e73a1d2f',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-e426d6c0-7d71-41fd-9a08-4914f84af209-1f790d98-22a2-41c7-9908-5b432ad80961',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-DepartmentsPositionsEditor-InWindow',
        'rmsUid': '1f790d98-22a2-41c7-9908-5b432ad80961',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-e426d6c0-7d71-41fd-9a08-4914f84af209-0f4b8380-6a80-4717-8ad9-5a9b05341856',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '0f4b8380-6a80-4717-8ad9-5a9b05341856',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Type_Name',
                'dataIndexAbsoluteUid': 'FieldPath://1cbc241a-85e4-47db-964b-6bec69dec86c$f176197f-28ae-4253-a228-0f5ef5df9aea$a4db7755-81d6-415e-83ff-dc5e999fc018',
                'dataIndexRelativePath': 'Type.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '64246d85-29e6-48be-afc7-b9f8c8287d26',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Вид',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Position',
                'dataIndexAbsoluteUid': 'FieldPath://1cbc241a-85e4-47db-964b-6bec69dec86c$ac773733-14e9-4469-920f-500782bb6cef',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'fa18b37a-52a2-4203-a55a-27d29f5e0af6',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Должность',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Department_Id',
                'dataIndexAbsoluteUid': 'FieldPath://1cbc241a-85e4-47db-964b-6bec69dec86c$403e67cf-fb18-4e44-8066-e9987352fdc0$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Department.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': '8037acd6-44d3-4bf8-927b-fdde53ab0e3b',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Подразделение.Идентификатор',
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