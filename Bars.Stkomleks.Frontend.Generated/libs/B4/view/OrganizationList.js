Ext.define('B4.view.OrganizationList', {
    'alias': 'widget.rms-organizationlist',
    'dataSourceUid': '242b06d2-b239-47ad-b75a-cbf88a4b987b',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrganizationListModel',
    'rmsElementUid': '0bd08e33-3c9d-4a0a-9c2b-26b65bec5f67',
    'rmsUid': '0bd08e33-3c9d-4a0a-9c2b-26b65bec5f67',
    'stateful': false,
    'title': 'Организации',
    requires: [
        'B4.form.StateContextMenuColumn',
        'B4.model.OrganizationListModel',
        'B4.ux.grid.plugin.StyleConditions',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-0bd08e33-3c9d-4a0a-9c2b-26b65bec5f67-bbda4400-7351-4b87-8e68-1837ec84c097',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'bbda4400-7351-4b87-8e68-1837ec84c097',
        'text': 'Обновить'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-0bd08e33-3c9d-4a0a-9c2b-26b65bec5f67-107e95b2-9687-4a99-acf5-2ed4832a9ae7',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-OrganizationEditor-InWindow',
        'rmsUid': '107e95b2-9687-4a99-acf5-2ed4832a9ae7',
        'text': 'Добавить'
    }, {
        'actionName': 'edit',
        'extraCls': 'cmp-style-0bd08e33-3c9d-4a0a-9c2b-26b65bec5f67-4929fef0-4b08-4fa5-ad1e-a83bfbbe997c',
        'hidden': false,
        'iconCls': 'icon-pencil',
        'ignoreMakeInactive': false,
        'itemId': 'Editing-OrganizationEditor-InWindow',
        'rmsUid': '4929fef0-4b08-4fa5-ad1e-a83bfbbe997c',
        'text': 'Редактировать'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-0bd08e33-3c9d-4a0a-9c2b-26b65bec5f67-8a874f81-cdab-408f-a55d-05da58b3013e',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': '8a874f81-cdab-408f-a55d-05da58b3013e',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': '_State',
                'dataIndexAbsoluteUid': 'FieldPath://242b06d2-b239-47ad-b75a-cbf88a4b987b$e4e972d9-7d07-4948-800b-58ca8794b4ad',
                'stateTypeId': 'bars.stkomleks.organization',
                'xtype': 'b4statecontextmenucolumn'
            }, {
                'dataIndex': 'Name',
                'dataIndexAbsoluteUid': 'FieldPath://242b06d2-b239-47ad-b75a-cbf88a4b987b$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '5f31e805-105e-4050-8f0c-206e67390122',
                'sortable': true,
                'text': 'Наименование',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'FullName',
                'dataIndexAbsoluteUid': 'FieldPath://242b06d2-b239-47ad-b75a-cbf88a4b987b$597802ac-f55b-40ee-98da-f63d361ae48c',
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '15c5cdb0-05de-4ad3-92d8-daed5fe5de5b',
                'sortable': true,
                'text': 'Полное наименование',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Comment',
                'dataIndexAbsoluteUid': 'FieldPath://242b06d2-b239-47ad-b75a-cbf88a4b987b$344fe108-25f3-42b4-a688-72a4f911da37',
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': 'c311ec24-1523-4070-9ad2-4294efb0756a',
                'sortable': true,
                'text': 'Описание',
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
            }]
        });
        me.callParent(arguments);
    }
});