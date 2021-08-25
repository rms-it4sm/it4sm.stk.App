Ext.define('B4.view.CurrentPositionsDepartmentsList', {
    'alias': 'widget.rms-currentpositionsdepartmentslist',
    'dataSourceUid': '788a15f1-40ba-4144-b7a9-45ce08fb1ffc',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.CurrentPositionsDepartmentsListModel',
    'rmsElementUid': 'b70dd896-3c2d-42e2-ae24-fd54d7fa5a43',
    'rmsUid': 'b70dd896-3c2d-42e2-ae24-fd54d7fa5a43',
    'stateful': false,
    'title': 'Занимаемые должности.Подразделение',
    'wrapTextOnSelection': true,
    requires: [
        'B4.model.CurrentPositionsDepartmentsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-b70dd896-3c2d-42e2-ae24-fd54d7fa5a43-5c3d8c18-4ee0-4a56-9aea-a3375b8d9cfc',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '5c3d8c18-4ee0-4a56-9aea-a3375b8d9cfc',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-b70dd896-3c2d-42e2-ae24-fd54d7fa5a43-315980a7-fd7f-4c37-840e-be8d7904cc74',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-CurrentPositionsDepartmentsEditor-InWindow',
        'rmsUid': '315980a7-fd7f-4c37-840e-be8d7904cc74',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-b70dd896-3c2d-42e2-ae24-fd54d7fa5a43-80cb4ec4-4d70-4357-8b03-92d988bbc2d0',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-CurrentPositionsDepartmentsEditor-InWindow',
        'rmsUid': '80cb4ec4-4d70-4357-8b03-92d988bbc2d0',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-b70dd896-3c2d-42e2-ae24-fd54d7fa5a43-95a402f6-5765-4184-a3fe-199433e31cdb',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '95a402f6-5765-4184-a3fe-199433e31cdb',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Start',
                'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$970a73c8-7aa2-4627-aa61-f63efe1b404a',
                'decimalPrecision': 2,
                'filter': true,
                'ignoreTimeZoneInFilter': true,
                'menuDisabled': false,
                'renderer': B4.grid.Renderers.date,
                'rmsUid': '562f18fe-db14-4d90-96b4-5ca0fb309c6d',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Начало',
                'width': 150,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Finish',
                'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$38dc8ddd-3d66-42aa-a5b8-bf02e173b825',
                'decimalPrecision': 2,
                'filter': true,
                'ignoreTimeZoneInFilter': true,
                'menuDisabled': false,
                'renderer': B4.grid.Renderers.date,
                'rmsUid': '219ebdf0-7a0c-4ff0-9244-7b9ea8955d46',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Завершение',
                'width': 150,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Staff_Individual_FIO',
                'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$ae322edc-4521-4ff9-9d21-49d1aacb76da$2841e6bd-6760-4243-92b0-d26a48633898$9eb7280e-5e7f-4c39-b975-ad80302db2f6',
                'dataIndexRelativePath': 'Staff.Individual.FIO',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '7637c338-5995-4c80-814e-fc26d2d8c80c',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Сотрудник',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$7c4f9660-2d1a-45ef-92a6-23eba0557973',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'd34037dd-1a85-4f49-8af4-1cd4f740cf93',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'DepartmentPosition_Id',
                'dataIndexAbsoluteUid': 'FieldPath://788a15f1-40ba-4144-b7a9-45ce08fb1ffc$45701d0f-8b89-4f73-97ce-6b22afb0832e$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'DepartmentPosition.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': '27fc86ef-c007-4050-b64d-eccb0bc15a61',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Должность подразделения.Идентификатор',
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