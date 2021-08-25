Ext.define('B4.view.ResponsiblePersonsOrderList', {
    'alias': 'widget.rms-responsiblepersonsorderlist',
    'dataSourceUid': 'ad3b2737-f4d5-4495-b388-44a6dfd03bd9',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ResponsiblePersonsOrderListModel',
    'rmsElementUid': 'ade124d1-dfa2-4ebc-abe4-958e13868259',
    'rmsUid': 'ade124d1-dfa2-4ebc-abe4-958e13868259',
    'stateful': false,
    'title': 'Ответственные лица. Организация заказа',
    requires: [
        'B4.model.ResponsiblePersonsOrderListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-ade124d1-dfa2-4ebc-abe4-958e13868259-8650124c-b66e-488c-824f-8506bec13d52',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '8650124c-b66e-488c-824f-8506bec13d52',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-ade124d1-dfa2-4ebc-abe4-958e13868259-42b0fad9-76b1-4a4b-8e06-dc22e16214b2',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-ResponsiblePersonsOrderEditor-InWindow',
        'rmsUid': '42b0fad9-76b1-4a4b-8e06-dc22e16214b2',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-ade124d1-dfa2-4ebc-abe4-958e13868259-3c67c4e5-f3e2-4ed2-9f83-6c658e451c60',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-ResponsiblePersonsOrderEditor-InWindow',
        'rmsUid': '3c67c4e5-f3e2-4ed2-9f83-6c658e451c60',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-ade124d1-dfa2-4ebc-abe4-958e13868259-7b3a06d6-f3e0-4fa7-9354-37b74ad342cd',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '7b3a06d6-f3e0-4fa7-9354-37b74ad342cd',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Staff_Individual_FIO',
                'dataIndexAbsoluteUid': 'FieldPath://ad3b2737-f4d5-4495-b388-44a6dfd03bd9$d72d7037-1006-4e36-9322-acb7fac2c8ea$2841e6bd-6760-4243-92b0-d26a48633898$9eb7280e-5e7f-4c39-b975-ad80302db2f6',
                'dataIndexRelativePath': 'Staff.Individual.FIO',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'ef4a0466-5616-4e78-b8fb-63f669f7aa67',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Сотрудник',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Appointment',
                'dataIndexAbsoluteUid': 'FieldPath://ad3b2737-f4d5-4495-b388-44a6dfd03bd9$7194780a-1ae7-4273-a332-85e86223a895',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '65da21ff-9f96-4e38-b8c6-dbd1b2cc1b7c',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Назначение',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'OrderOrganization_Id',
                'dataIndexAbsoluteUid': 'FieldPath://ad3b2737-f4d5-4495-b388-44a6dfd03bd9$2173306f-90af-4867-96b1-ff443b3bc289$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'OrderOrganization.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'be1bdef2-73e0-419b-b224-3307bcc7549c',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Организация заказа.Идентификатор',
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