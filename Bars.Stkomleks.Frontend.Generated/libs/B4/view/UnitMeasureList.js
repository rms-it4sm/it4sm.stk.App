Ext.define('B4.view.UnitMeasureList', {
    'alias': 'widget.rms-unitmeasurelist',
    'dataSourceUid': '15100549-aaff-4972-981e-964ab1b0ecc6',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.UnitMeasureListModel',
    'rmsElementUid': '6dc6ab7d-deb8-4e55-8c90-4fac46f30702',
    'rmsUid': '6dc6ab7d-deb8-4e55-8c90-4fac46f30702',
    'stateful': false,
    'title': 'Единицы измерения',
    requires: [
        'B4.model.UnitMeasureListModel',
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
        'extraCls': 'cmp-style-6dc6ab7d-deb8-4e55-8c90-4fac46f30702-063719d8-c8f5-43c5-b5d3-ce3eee2566d8',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '063719d8-c8f5-43c5-b5d3-ce3eee2566d8',
        'text': 'Обновить'
    }, {
        'actionName': 'inline-add',
        'extraCls': 'cmp-style-6dc6ab7d-deb8-4e55-8c90-4fac46f30702-2761de58-7aed-4e47-b2f9-951f91c227df',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Add',
        'rmsUid': '2761de58-7aed-4e47-b2f9-951f91c227df',
        'text': 'Добавить',
        'xtype': 'b4addbutton'
    }, {
        'actionName': 'inline-edit',
        'extraCls': 'cmp-style-6dc6ab7d-deb8-4e55-8c90-4fac46f30702-18fc4696-368b-4ba3-9998-101fc84a0b62',
        'hidden': false,
        'iconCls': 'icon-edit',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'Edit',
        'rmsUid': '18fc4696-368b-4ba3-9998-101fc84a0b62',
        'text': 'Редактировать',
        'xtype': 'b4editbutton'
    }, {
        'actionName': 'save',
        'extraCls': 'cmp-style-6dc6ab7d-deb8-4e55-8c90-4fac46f30702-6636c2a4-6457-449d-aeaf-217dfbeb6936',
        'hidden': false,
        'iconCls': 'icon-save',
        'ignoreMakeInactive': false,
        'isForInline': true,
        'itemId': 'SaveAll',
        'rmsUid': '6636c2a4-6457-449d-aeaf-217dfbeb6936',
        'text': 'Сохранить',
        'xtype': 'b4savebutton'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-6dc6ab7d-deb8-4e55-8c90-4fac46f30702-a298764b-9fb7-42c5-b9c8-bc718b29659a',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'a298764b-9fb7-42c5-b9c8-bc718b29659a',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Nema',
                'dataIndexAbsoluteUid': 'FieldPath://15100549-aaff-4972-981e-964ab1b0ecc6$7e86e43d-0dab-4626-958f-c5f0b73c13e0',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '172ad929-8f47-4348-b547-f2556e6abd97',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'CutName',
                'dataIndexAbsoluteUid': 'FieldPath://15100549-aaff-4972-981e-964ab1b0ecc6$ec1108d2-98bb-48b7-ad5a-6185dc2ccf2a',
                'decimalPrecision': 2,
                'editor': {
                    'xtype': 'textfield'
                },
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '65cdd354-6cc7-4528-9e40-b44ab7c3f854',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Сокращенное наименование',
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
                'cellediting': 'cellediting-unitmeasurelist',
                'clicksToEdit': -1,
                'ptype': 'cellediting'
            }]
        });
        me.callParent(arguments);
    }
});