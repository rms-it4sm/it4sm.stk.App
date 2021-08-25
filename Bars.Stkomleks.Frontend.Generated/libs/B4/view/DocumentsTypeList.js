Ext.define('B4.view.DocumentsTypeList', {
    'alias': 'widget.rms-documentstypelist',
    'dataSourceUid': '99acad7b-98b7-44d0-8116-ae5e6a2f4dd5',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.DocumentsTypeListModel',
    'rmsElementUid': '7211ad48-2f3c-428f-988e-38a03c467294',
    'rmsUid': '7211ad48-2f3c-428f-988e-38a03c467294',
    'stateful': false,
    'title': 'Типы документов',
    requires: [
        'B4.model.DocumentsTypeListModel',
        'B4.ux.button.Add',
        'B4.ux.button.Edit',
        'B4.ux.button.Save',
        'B4.ux.grid.column.*',
        'Ext.ux.CheckColumn'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-7211ad48-2f3c-428f-988e-38a03c467294-d5b45409-c91f-42be-b98a-4c193138ba78',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'd5b45409-c91f-42be-b98a-4c193138ba78',
        'text': 'Обновить'
    }, {
        'actionName': 'inline-add',
        'extraCls': 'cmp-style-7211ad48-2f3c-428f-988e-38a03c467294-07f7a965-2aa3-45f9-9446-ffbaac474f59',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Add',
        'rmsUid': '07f7a965-2aa3-45f9-9446-ffbaac474f59',
        'text': 'Добавить',
        'xtype': 'b4addbutton'
    }, {
        'actionName': 'inline-edit',
        'extraCls': 'cmp-style-7211ad48-2f3c-428f-988e-38a03c467294-b4ad96df-78ab-43b5-8086-b3d31010a6ab',
        'hidden': false,
        'iconCls': 'icon-edit',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Edit',
        'rmsUid': 'b4ad96df-78ab-43b5-8086-b3d31010a6ab',
        'text': 'Редактировать',
        'xtype': 'b4editbutton'
    }, {
        'actionName': 'save',
        'extraCls': 'cmp-style-7211ad48-2f3c-428f-988e-38a03c467294-865db4ee-c3a6-4a1e-a0ef-2ffd6f3db5c4',
        'hidden': false,
        'iconCls': 'icon-save',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'SaveAll',
        'rmsUid': '865db4ee-c3a6-4a1e-a0ef-2ffd6f3db5c4',
        'text': 'Сохранить',
        'xtype': 'b4savebutton'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-7211ad48-2f3c-428f-988e-38a03c467294-be1a3d90-1c22-4afc-92b0-2f9396d53c03',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'be1a3d90-1c22-4afc-92b0-2f9396d53c03',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://99acad7b-98b7-44d0-8116-ae5e6a2f4dd5$916dab28-f962-427c-b442-8dd1a43355b8',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '6ac5f8dc-f67a-4f15-a839-aa38ccc37c8c',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'cellediting': 'cellediting-documentstypelist',
                'clicksToEdit': -1,
                'ptype': 'cellediting'
            }]
        });
        me.callParent(arguments);
    }
});