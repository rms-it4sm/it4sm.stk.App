Ext.define('B4.view.OrderOrganizationList', {
    'alias': 'widget.rms-orderorganizationlist',
    'dataSourceUid': 'e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrderOrganizationListModel',
    'rmsElementUid': 'd3820c7f-83ff-4c5a-b48f-6cc81381a422',
    'rmsUid': 'd3820c7f-83ff-4c5a-b48f-6cc81381a422',
    'stateful': false,
    'title': 'Организации.Заказ',
    requires: [
        'B4.model.OrderOrganizationListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-d3820c7f-83ff-4c5a-b48f-6cc81381a422-b626e762-edcf-4241-9de9-1ff28e086284',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'b626e762-edcf-4241-9de9-1ff28e086284',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-d3820c7f-83ff-4c5a-b48f-6cc81381a422-a77ef256-0c5a-4519-aef1-961c1519c5a3',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-OrderOrganizationEditor-InWindow',
        'rmsUid': 'a77ef256-0c5a-4519-aef1-961c1519c5a3',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-d3820c7f-83ff-4c5a-b48f-6cc81381a422-c627419e-66f2-446b-81bb-1ff48173affc',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-OrderOrganizationEditor-InWindow',
        'rmsUid': 'c627419e-66f2-446b-81bb-1ff48173affc',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-d3820c7f-83ff-4c5a-b48f-6cc81381a422-30359011-6db1-46e2-8e92-fd0dde71bbff',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '30359011-6db1-46e2-8e92-fd0dde71bbff',
        'text': 'Удалить'
    }],
    paging: false,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Organization_Organization_Name',
                'dataIndexAbsoluteUid': 'FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$6ba61f70-f527-49f0-8be6-6b3ad80631e0$e0a08ecf-f833-461a-8b0d-8d7e5d4e4778$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                'dataIndexRelativePath': 'Organization.Organization.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'e9a2560f-e833-4f5e-b71b-eb528853e39f',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Profile_Name',
                'dataIndexAbsoluteUid': 'FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$b3680cb2-895a-4302-b935-4f34a4fdbb84$f44c4209-af60-444a-a056-671a5255de8d',
                'dataIndexRelativePath': 'Profile.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '72c7e258-1b64-4267-8d76-5fa64baa1939',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Профиль',
                'width': 200,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$4ff1b371-5045-429f-b88e-9d6c6f52dd4e',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '21aa6105-7e06-49b5-bded-3d4bda34192c',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Zakaz_Id',
                'dataIndexAbsoluteUid': 'FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$f7ae25e3-ce68-4402-a491-414fcd634df3$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Zakaz.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'b887602f-423b-441d-a580-f7a98f3cae56',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Заказ.Идентификатор',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Organization_Id',
                'dataIndexAbsoluteUid': 'FieldPath://e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e$6ba61f70-f527-49f0-8be6-6b3ad80631e0$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Organization.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'a772b6cb-bfa7-4b87-91c5-840c1b1673d5',
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