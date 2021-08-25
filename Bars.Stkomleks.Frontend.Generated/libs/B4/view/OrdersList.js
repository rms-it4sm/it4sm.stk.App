Ext.define('B4.view.OrdersList', {
    'alias': 'widget.rms-orderslist',
    'dataSourceUid': 'cac4cb82-577f-4682-bbd7-bf7d70fbfee1',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrdersListModel',
    'rmsElementUid': 'd93953ac-6978-4661-a1b4-39b7805429ac',
    'rmsUid': 'd93953ac-6978-4661-a1b4-39b7805429ac',
    'stateful': false,
    'title': 'Заказы',
    requires: [
        'B4.form.StateContextMenuColumn',
        'B4.model.OrdersListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-d93953ac-6978-4661-a1b4-39b7805429ac-eb0c060c-2e5b-47b6-9661-43f482836c0f',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'eb0c060c-2e5b-47b6-9661-43f482836c0f',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-d93953ac-6978-4661-a1b4-39b7805429ac-5c5e8777-f502-402a-8fb4-8d873d0f9264',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-OrdersEditor-InWindow',
        'rmsUid': '5c5e8777-f502-402a-8fb4-8d873d0f9264',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-d93953ac-6978-4661-a1b4-39b7805429ac-6fa8b590-b3bc-4663-ac64-6949917fb99d',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-OrdersEditor-Default',
        'rmsUid': '6fa8b590-b3bc-4663-ac64-6949917fb99d',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-d93953ac-6978-4661-a1b4-39b7805429ac-eb396442-26f4-44ea-969d-60703a567e99',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'eb396442-26f4-44ea-969d-60703a567e99',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': '_State',
                'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$2c5ce838-ae20-45bb-8cf8-65848eb4fbec',
                'stateTypeId': 'bars.stkomleks.zakaz',
                'xtype': 'b4statecontextmenucolumn'
            }, {
                'dataIndex': 'Number',
                'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$2f3de072-33f6-492c-8016-a55598f69f32',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '55baa0cd-c5f0-4e29-9a9e-553925b75c84',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Номер',
                'width': 150,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Date',
                'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$94896f6f-f4a2-4c12-a701-0e988c92f462',
                'decimalPrecision': 2,
                'filter': true,
                'ignoreTimeZoneInFilter': true,
                'menuDisabled': false,
                'renderer': B4.grid.Renderers.date,
                'rmsUid': '07847f0a-a5cf-48c1-9937-3dc2468dc640',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Дата',
                'width': 120,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Client_Organization_Name',
                'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$4082c604-c52d-4594-88ad-b59078285797$e0a08ecf-f833-461a-8b0d-8d7e5d4e4778$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                'dataIndexRelativePath': 'Client.Organization.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'd2cb28e1-bfd5-4c52-9232-5edb91dbfd07',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Заказчик',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Manager_Individual_FIO',
                'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$3ee53bb5-bb60-47aa-8a69-41594431f6e0$2841e6bd-6760-4243-92b0-d26a48633898$9eb7280e-5e7f-4c39-b975-ad80302db2f6',
                'dataIndexRelativePath': 'Manager.Individual.FIO',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'b0776bd1-7390-4635-a11a-3201a130119d',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Менеджер',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://cac4cb82-577f-4682-bbd7-bf7d70fbfee1$01be0595-d7b3-4466-bf15-f9110b6fa65f',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '057829d4-a0b3-467c-9c77-e4a64a471a2f',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
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