Ext.define('B4.view.CompositionWorksObjectsList', {
    'alias': 'widget.rms-compositionworksobjectslist',
    'dataSourceUid': 'cd655c91-5a8f-427c-ab3a-d4c44234cb06',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'groupField': 'ObjectElement_TypeElement_Name',
    'model': 'B4.model.CompositionWorksObjectsListModel',
    'rmsElementUid': '565aaf50-2e83-44ea-af8d-48f5646a28d6',
    'rmsUid': '565aaf50-2e83-44ea-af8d-48f5646a28d6',
    'stateful': false,
    'title': 'Работы.Объект',
    requires: [
        'B4.enums.TypesWorkPerformers',
        'B4.form.StateContextMenuColumn',
        'B4.model.CompositionWorksObjectsListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-565aaf50-2e83-44ea-af8d-48f5646a28d6-7a122cba-0549-476d-9a37-c23b9cdeb3f3',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '7a122cba-0549-476d-9a37-c23b9cdeb3f3',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-565aaf50-2e83-44ea-af8d-48f5646a28d6-4e2d2b76-9499-46f4-bd36-251985798035',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-CompositionWorksObjectsEditor-InWindow',
        'rmsUid': '4e2d2b76-9499-46f4-bd36-251985798035',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-565aaf50-2e83-44ea-af8d-48f5646a28d6-626b9c6b-ec6d-421c-b3fc-9b32b7632b9c',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-CompositionWorksObjectsEditor-InWindow',
        'rmsUid': '626b9c6b-ec6d-421c-b3fc-9b32b7632b9c',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-565aaf50-2e83-44ea-af8d-48f5646a28d6-bd87ddd0-ea2e-408f-becb-5cfbf645f618',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'bd87ddd0-ea2e-408f-becb-5cfbf645f618',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': '_State',
                'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$b8bdda97-46ef-4226-a0de-d71feda83cf3',
                'stateTypeId': 'bars.stkomleks.compositionworksobjects',
                'xtype': 'b4statecontextmenucolumn'
            }, {
                'dataIndex': 'ObjectElement_TypeElement_Name',
                'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$f6e6872c-d834-499f-b973-c3085925579a$6937d6ae-a06f-4475-a391-7b5aced09f7f$b90e9798-469f-4de2-a64a-577dbe42640d',
                'dataIndexRelativePath': 'ObjectElement.TypeElement.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'cf95128a-d732-48ac-a82b-cd81c1517bce',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Элемент',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'WorkType_WorkType_Name',
                'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$57b675f7-b7f9-4d88-b390-9185e48c5d6a$a027f406-10c4-4310-9fc3-d6f6fe0739de$a9294408-1e36-4617-9972-07c45c83ce2d',
                'dataIndexRelativePath': 'WorkType.WorkType.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '6dbe1798-155d-4457-8a9b-df32a81cb2b3',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Вид работы',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'PlanStart',
                'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$d5cc7e14-1d82-4846-b79a-a4c19a61a2f5',
                'decimalPrecision': 2,
                'filter': true,
                'ignoreTimeZoneInFilter': true,
                'menuDisabled': false,
                'renderer': B4.grid.Renderers.date,
                'rmsUid': 'f8c6e65b-b91a-427d-a24d-2c98e85fc4d0',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Начало (план)',
                'width': 120,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'PlanFinish',
                'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$3f80730d-eb09-48e7-a2cc-62cbc1533c16',
                'decimalPrecision': 2,
                'filter': true,
                'ignoreTimeZoneInFilter': true,
                'menuDisabled': false,
                'renderer': B4.grid.Renderers.date,
                'rmsUid': '4851cfa6-c576-428f-936c-98388616914e',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Завершение (план)',
                'width': 140,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'MethodWork',
                'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$96ec58e2-95d0-45d4-a271-875601604621',
                'decimalPrecision': 2,
                'enumName': 'B4.enums.TypesWorkPerformers',
                'filter': true,
                'menuDisabled': false,
                'rmsUid': '0f7c8317-2603-4024-a218-c518fca508c1',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Способ выполнения',
                'width': 150,
                'xtype': 'b4enumcolumn'
            }, {
                'dataIndex': 'Executor',
                'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$87250b9a-b480-488b-9aa3-eba693e483af',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '61d3623a-a678-4bed-af95-7fb20ef4fc0f',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Исполнитель',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$10f45f46-c87b-4130-a5db-673007a24530',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 2,
                'menuDisabled': false,
                'rmsUid': '52cffedf-e02a-4165-832d-e803a707febc',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'ObjectWork_Id',
                'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$e5e6c0c3-2740-40ee-9e6b-c98d69124498$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'ObjectWork.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'dfd4b652-60e2-4cb5-b706-07b52983a8af',
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