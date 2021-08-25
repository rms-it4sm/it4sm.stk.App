Ext.define('B4.view.StaffList', {
    'alias': 'widget.rms-stafflist',
    'dataSourceUid': '0b83a4c4-1b8b-49d6-b16b-dcb3a373a391',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.StaffListModel',
    'rmsElementUid': '23f0a883-68a9-4383-992d-974be0e55c0c',
    'rmsUid': '23f0a883-68a9-4383-992d-974be0e55c0c',
    'stateful': false,
    'title': 'Сотрудники.Организация',
    'wrapTextOnSelection': true,
    requires: [
        'B4.form.StateContextMenuColumn',
        'B4.model.StaffListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-23f0a883-68a9-4383-992d-974be0e55c0c-8e82df8e-45be-4e2c-b9af-89214ee5a827',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '8e82df8e-45be-4e2c-b9af-89214ee5a827',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-23f0a883-68a9-4383-992d-974be0e55c0c-1911fe15-c18b-4a85-894c-ab0536d7a612',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-StaffEditor-InWindow',
        'rmsUid': '1911fe15-c18b-4a85-894c-ab0536d7a612',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-23f0a883-68a9-4383-992d-974be0e55c0c-f5f4d26a-7154-4e57-b635-a4ae049f1ed0',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-StaffEditor-InWindow',
        'rmsUid': 'f5f4d26a-7154-4e57-b635-a4ae049f1ed0',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-23f0a883-68a9-4383-992d-974be0e55c0c-ea155341-a251-455b-bee1-1ec855c55f1e',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'ea155341-a251-455b-bee1-1ec855c55f1e',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': '_State',
                'dataIndexAbsoluteUid': 'FieldPath://0b83a4c4-1b8b-49d6-b16b-dcb3a373a391$35c9fe0e-04ae-4d01-a79d-3926deb694e0',
                'stateTypeId': 'bars.stkomleks.staff',
                'xtype': 'b4statecontextmenucolumn'
            }, {
                'dataIndex': 'Individual_FIO',
                'dataIndexAbsoluteUid': 'FieldPath://0b83a4c4-1b8b-49d6-b16b-dcb3a373a391$2841e6bd-6760-4243-92b0-d26a48633898$9eb7280e-5e7f-4c39-b975-ad80302db2f6',
                'dataIndexRelativePath': 'Individual.FIO',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '498505c6-84b4-480f-a87b-d738613a2ff4',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Физ лицо',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://0b83a4c4-1b8b-49d6-b16b-dcb3a373a391$0fc2221c-b809-4739-a087-7a9acf5438c5',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '91ed3aa5-213c-40b8-88e6-bfd48ca8719f',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Organization_Id',
                'dataIndexAbsoluteUid': 'FieldPath://0b83a4c4-1b8b-49d6-b16b-dcb3a373a391$877ada62-82d4-4fca-8574-61c4290187d5$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Organization.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'c3b470de-8054-484a-81b1-c3f4e090e951',
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
            }]
        });
        me.callParent(arguments);
    }
});