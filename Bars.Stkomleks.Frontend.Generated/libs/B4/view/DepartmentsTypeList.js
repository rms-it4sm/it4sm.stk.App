Ext.define('B4.view.DepartmentsTypeList', {
    'alias': 'widget.rms-departmentstypelist',
    'dataSourceUid': 'abec8327-350c-42a6-bbce-32cb76103d00',
    'enableColumnHide': false,
    'enableColumnMove': false,
    'enableColumnResize': false,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.DepartmentsTypeListModel',
    'rmsElementUid': '9b5801ef-5de5-4bf2-b517-99551e774036',
    'rmsUid': '9b5801ef-5de5-4bf2-b517-99551e774036',
    'stateful': false,
    'title': 'Виды подразделений',
    requires: [
        'B4.model.DepartmentsTypeListModel',
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
        'extraCls': 'cmp-style-9b5801ef-5de5-4bf2-b517-99551e774036-5d4cc514-7ad2-46ee-9166-738c996f5b31',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '5d4cc514-7ad2-46ee-9166-738c996f5b31',
        'text': 'Обновить'
    }, {
        'actionName': 'inline-add',
        'extraCls': 'cmp-style-9b5801ef-5de5-4bf2-b517-99551e774036-c362e212-1b49-49ab-b5da-303c884fecd4',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Add',
        'rmsUid': 'c362e212-1b49-49ab-b5da-303c884fecd4',
        'text': 'Добавить',
        'xtype': 'b4addbutton'
    }, {
        'actionName': 'inline-edit',
        'extraCls': 'cmp-style-9b5801ef-5de5-4bf2-b517-99551e774036-2c428999-0f75-4238-972f-c4d1fed962a6',
        'hidden': false,
        'iconCls': 'icon-edit',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Edit',
        'rmsUid': '2c428999-0f75-4238-972f-c4d1fed962a6',
        'text': 'Редактировать',
        'xtype': 'b4editbutton'
    }, {
        'actionName': 'save',
        'extraCls': 'cmp-style-9b5801ef-5de5-4bf2-b517-99551e774036-6c37a619-7cea-460c-9155-80bd22ef4ef2',
        'hidden': false,
        'iconCls': 'icon-save',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'SaveAll',
        'rmsUid': '6c37a619-7cea-460c-9155-80bd22ef4ef2',
        'text': 'Сохранить',
        'xtype': 'b4savebutton'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-9b5801ef-5de5-4bf2-b517-99551e774036-735d0013-c9d6-4920-ada0-32dec8b9129d',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '735d0013-c9d6-4920-ada0-32dec8b9129d',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://abec8327-350c-42a6-bbce-32cb76103d00$565ee7fe-e001-406e-b048-35966b4b3f67',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '14fdf4f4-b02f-4732-af42-6bac1b8f3f66',
                'sortable': false,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'cellediting': 'cellediting-departmentstypelist',
                'clicksToEdit': -1,
                'ptype': 'cellediting'
            }]
        });
        me.callParent(arguments);
    }
});