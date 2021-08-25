Ext.define('B4.view.ObjectsOrdersList2', {
    'alias': 'widget.rms-objectsorderslist2',
    'dataSourceUid': '33d98787-d41a-4282-8f79-3b4f1046a7a1',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ObjectsOrdersList2Model',
    'rmsElementUid': 'e21449a3-6c79-4d88-a466-501c496fa133',
    'rmsUid': 'e21449a3-6c79-4d88-a466-501c496fa133',
    'stateful': false,
    'title': 'Заказы.Объект',
    requires: [
        'B4.model.ObjectsOrdersList2Model',
        'B4.ux.grid.plugin.StyleConditions',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-e21449a3-6c79-4d88-a466-501c496fa133-e29ca320-5454-4209-b5fd-69d1e43b48d2',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': 'e29ca320-5454-4209-b5fd-69d1e43b48d2',
        'text': 'Обновить'
    }, {
        'extraCls': 'cmp-style-e21449a3-6c79-4d88-a466-501c496fa133-b608817a-c7c5-4c6c-9e07-cbb9abf0bb0b',
        'handler': function(item, e) {
            try {
                var _self = this,
                    _args = Array.prototype.slice.call(arguments);
                var grid = this.getDataGrid && this.getDataGrid() ? this.getDataGrid() : (this.is && (this.is('grid') || this.is('treepanel')) ? this : (this.up ? this.up('grid') || this.up('treepanel') : null)),
                    sel = grid && grid.getSelectionModel().getSelection()[0],
                    fld = sel && sel.get('Zakaz_Id'),
                    grid1 = B4.utils.FormHelper.findNearestListView(typeof _self === 'undefined' ? this : _self),
                    ctxKey = (grid1 && grid1.ctxKey) || this.getCurrentContextKey(),
                    dataVariables = new B4.variables.Container();
                grid1 && grid1.data && grid1.data.getVariables().forEach(v => dataVariables.set(v.code, v.value));
                var inWindow = false;
                var parentComponentWithVersionAttribute = B4.utils.FormHelper.findNearestParentWithAttribute(grid1, 'versionScope');
                var parentComponentWithChangeSetAttribute = B4.utils.FormHelper.findNearestParentWithAttribute(grid1, 'changeSet');
                B4.Navigation.openForm("OrdersEditor", fld, inWindow, false, {
                    dataVariables: dataVariables,
                    RmsDataGridAlias: this.viewAlias,
                    RmsDataGridId: grid1 ? grid1.getId() : null,
                    ctxKey: ctxKey,
                    isDataGridEditor: !Ext.isEmpty(grid1),
                    versionScope: parentComponentWithVersionAttribute != null ? Ext.decode(Ext.encode(parentComponentWithVersionAttribute.versionScope)) : null,
                    changeSet: parentComponentWithChangeSetAttribute != null ? Ext.decode(Ext.encode(parentComponentWithChangeSetAttribute.changeSet)) : null,
                    maximizable: true,
                    viewStack: grid1 && grid1.viewStack ? [...grid1.viewStack] : []
                });
            } catch (_e__r__r) {
                console.warn("Ошибка в событии `Действие на строке списка (кнопка)` элемента `b608817a-c7c5-4c6c-9e07-cbb9abf0bb0b`");
                throw _e__r__r;
            }
        },
        'hidden': false,
        'iconCls': 'fad fa-clipboard-list-check',
        'ignoreMakeInactive': false,
        'itemId': 'ListViewRow',
        'rmsUid': 'b608817a-c7c5-4c6c-9e07-cbb9abf0bb0b',
        'text': 'Открыть заказ'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'Zakaz_Client_Organization_Name',
                'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$30ef3bf7-35e0-4a5c-9945-9fa7db560dc7$4082c604-c52d-4594-88ad-b59078285797$e0a08ecf-f833-461a-8b0d-8d7e5d4e4778$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                'dataIndexRelativePath': 'Zakaz.Client.Organization.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '0b2fa8fd-efe9-46ef-a517-808603ac2275',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Заказчик',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Zakaz_Number',
                'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$30ef3bf7-35e0-4a5c-9945-9fa7db560dc7$2f3de072-33f6-492c-8016-a55598f69f32',
                'dataIndexRelativePath': 'Zakaz.Number',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '00f99087-3480-4b69-b80a-006906b83439',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Номер',
                'width': 150,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Zakaz_Date',
                'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$30ef3bf7-35e0-4a5c-9945-9fa7db560dc7$94896f6f-f4a2-4c12-a701-0e988c92f462',
                'dataIndexRelativePath': 'Zakaz.Date',
                'decimalPrecision': 2,
                'filter': true,
                'ignoreTimeZoneInFilter': true,
                'menuDisabled': false,
                'renderer': B4.grid.Renderers.date,
                'rmsUid': '53e31121-480d-4a01-a43e-b778c3356566',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Дата',
                'width': 120,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Object_Id',
                'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$f9b75007-4df7-4f66-8407-9646b73f634d$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Object.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': 'b81dc3f5-189b-45d4-8c07-912978fc850d',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Объект.Идентификатор',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Zakaz_Id',
                'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$30ef3bf7-35e0-4a5c-9945-9fa7db560dc7$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'Zakaz.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': '000b7a0b-528d-444c-a4c8-a3732096f758',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Заказ.Идентификатор',
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