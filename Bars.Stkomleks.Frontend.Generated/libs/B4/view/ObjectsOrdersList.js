Ext.define('B4.view.ObjectsOrdersList', {
    'alias': 'widget.rms-objectsorderslist',
    'dataSourceUid': '33d98787-d41a-4282-8f79-3b4f1046a7a1',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.ObjectsOrdersListModel',
    'rmsElementUid': '142d32b3-378a-44b6-8622-b6a199d85947',
    'rmsUid': '142d32b3-378a-44b6-8622-b6a199d85947',
    'stateful': false,
    'title': 'Объекты.Заказа',
    requires: [
        'B4.model.ObjectsOrdersListModel',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-142d32b3-378a-44b6-8622-b6a199d85947-61c35ea0-0ce1-43f7-9b51-4576314c9d07',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '61c35ea0-0ce1-43f7-9b51-4576314c9d07',
        'text': 'Обновить'
    }, {
        'actionName': 'multiadd',
        'extraCls': 'cmp-style-142d32b3-378a-44b6-8622-b6a199d85947-36888e22-6eb1-466a-956c-78abc60d0544',
        'hidden': false,
        'iconCls': 'fas fa-check-circle',
        'ignoreMakeInactive': false,
        'itemId': 'MultiAddition-ObjectsOrdersListMultiAddByZakazEditor-InWindow',
        'rmsUid': '36888e22-6eb1-466a-956c-78abc60d0544',
        'text': 'Выбрать объект'
    }, {
        'actionName': 'add',
        'extraCls': 'cmp-style-142d32b3-378a-44b6-8622-b6a199d85947-6d7d0691-d974-44a4-97a3-42289eddc8a4',
        'hidden': false,
        'iconCls': 'icon-add',
        'ignoreMakeInactive': false,
        'itemId': 'Addition-ObjectsOrdersEditor-InWindow',
        'rmsUid': '6d7d0691-d974-44a4-97a3-42289eddc8a4',
        'text': 'Создать объект'
    }, {
        'extraCls': 'cmp-style-142d32b3-378a-44b6-8622-b6a199d85947-3aad0557-ef34-4829-84cb-bebccb7a5ad5',
        'handler': function(item, e) {
            try {
                var _self = this,
                    _args = Array.prototype.slice.call(arguments);
                var grid = this.getDataGrid && this.getDataGrid() ? this.getDataGrid() : (this.is && (this.is('grid') || this.is('treepanel')) ? this : (this.up ? this.up('grid') || this.up('treepanel') : null)),
                    sel = grid && grid.getSelectionModel().getSelection()[0],
                    fld = sel && sel.get('Object_Id'),
                    grid1 = B4.utils.FormHelper.findNearestListView(typeof _self === 'undefined' ? this : _self),
                    ctxKey = (grid1 && grid1.ctxKey) || this.getCurrentContextKey(),
                    dataVariables = new B4.variables.Container();
                grid1 && grid1.data && grid1.data.getVariables().forEach(v => dataVariables.set(v.code, v.value));
                var inWindow = false;
                var parentComponentWithVersionAttribute = B4.utils.FormHelper.findNearestParentWithAttribute(grid1, 'versionScope');
                var parentComponentWithChangeSetAttribute = B4.utils.FormHelper.findNearestParentWithAttribute(grid1, 'changeSet');
                B4.Navigation.openForm("OrdersObjectsEditor_Copy_0", fld, inWindow, false, {
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
                console.warn("Ошибка в событии `Действие на строке списка (кнопка)` элемента `3aad0557-ef34-4829-84cb-bebccb7a5ad5`");
                throw _e__r__r;
            }
        },
        'hidden': false,
        'iconCls': 'fas fa-pencil-alt',
        'ignoreMakeInactive': false,
        'itemId': 'ListViewRow',
        'rmsUid': '3aad0557-ef34-4829-84cb-bebccb7a5ad5',
        'text': 'Открыть объект'
    }, {
        'actionName': 'delete',
        'extraCls': 'cmp-style-142d32b3-378a-44b6-8622-b6a199d85947-e7b4c311-1f50-42a0-a0c3-e5c910684586',
        'hidden': false,
        'iconCls': 'icon-delete',
        'ignoreMakeInactive': false,
        'itemId': 'Deletion',
        'rmsUid': 'e7b4c311-1f50-42a0-a0c3-e5c910684586',
        'text': 'Удалить'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
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
                'rmsUid': '866209b8-d883-47f5-877c-63123a3e6ca3',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Заказ.Идентификатор',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Object_State_Name',
                'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$f9b75007-4df7-4f66-8407-9646b73f634d$d547b8fb-bba6-4d6d-aac0-9000a3d5a1a7$BarsUp.Modules.States.State, BarsUp.Modules.States/Name',
                'dataIndexRelativePath': 'Object.State.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': 'ad231022-eb3e-4f7e-92c4-a5b0a519f219',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Статус',
                'width': 120,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Object_Type_Name',
                'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$f9b75007-4df7-4f66-8407-9646b73f634d$a861dd69-8067-4c54-a160-4086f003580f$dfde2099-4a59-4d2f-8d32-43143b4ec043',
                'dataIndexRelativePath': 'Object.Type.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '12aae422-d51c-47b8-94c5-06a27264a18d',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Тип',
                'width': 200,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Object_Name',
                'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$f9b75007-4df7-4f66-8407-9646b73f634d$8abbde9d-6cd1-4f40-84e7-9d387c970f1b',
                'dataIndexRelativePath': 'Object.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '0d3bca4b-753f-49cf-8c50-819f1f1ced9a',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
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
                'rmsUid': '4d727803-39d5-4c66-9464-09c4e6735518',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Объект.Идентификатор',
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