Ext.define('B4.view.WorksTypesList', {
    'alias': 'widget.rms-workstypeslist',
    'dataSourceUid': '7a874dff-d4b4-49ed-8be9-977056ad8fc9',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.WorksTypesListModel',
    'rmsElementUid': '3d27e730-89af-4b87-ae03-d40ba7d251e5',
    'rmsUid': '3d27e730-89af-4b87-ae03-d40ba7d251e5',
    'stateful': false,
    'title': 'Виды работ',
    requires: [
        'B4.model.WorksTypesListModel',
        'B4.ux.button.Add',
        'B4.ux.button.Edit',
        'B4.ux.button.Save',
        'B4.ux.grid.column.*',
        'B4.ux.grid.plugin.StyleConditions',
        'BarsUp.filter.ExtGridPlugin',
        'Ext.ux.CheckColumn'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-3d27e730-89af-4b87-ae03-d40ba7d251e5-35d23095-4824-45ee-b3dc-30d4d6990bb8',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '35d23095-4824-45ee-b3dc-30d4d6990bb8',
        'text': 'Обновить'
    }, {
        'actionName': 'inline-add',
        'extraCls': 'cmp-style-3d27e730-89af-4b87-ae03-d40ba7d251e5-7144570b-a04a-441c-8311-f8f3e699b589',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Add',
        'rmsUid': '7144570b-a04a-441c-8311-f8f3e699b589',
        'text': 'Добавить',
        'xtype': 'b4addbutton'
    }, {
        'actionName': 'inline-edit',
        'extraCls': 'cmp-style-3d27e730-89af-4b87-ae03-d40ba7d251e5-cd0c535f-0f8a-4815-bd44-7cb4a814dfaa',
        'hidden': false,
        'iconCls': 'icon-edit',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Edit',
        'rmsUid': 'cd0c535f-0f8a-4815-bd44-7cb4a814dfaa',
        'text': 'Редактировать',
        'xtype': 'b4editbutton'
    }, {
        'actionName': 'save',
        'extraCls': 'cmp-style-3d27e730-89af-4b87-ae03-d40ba7d251e5-968455b0-e655-47e9-928e-740abb73c90f',
        'hidden': false,
        'iconCls': 'icon-save',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'SaveAll',
        'rmsUid': '968455b0-e655-47e9-928e-740abb73c90f',
        'text': 'Сохранить',
        'xtype': 'b4savebutton'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-3d27e730-89af-4b87-ae03-d40ba7d251e5-4dc0365c-a8ce-48d2-9aed-f83a8510f29c',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '4dc0365c-a8ce-48d2-9aed-f83a8510f29c',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://7a874dff-d4b4-49ed-8be9-977056ad8fc9$a9294408-1e36-4617-9972-07c45c83ce2d',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'e06a800b-b7ab-4b89-becd-52c3a0d48d6b',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
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
            }, {
                'cellediting': 'cellediting-workstypeslist',
                'clicksToEdit': -1,
                'ptype': 'cellediting'
            }]
        });
        me.callParent(arguments);
    }
});