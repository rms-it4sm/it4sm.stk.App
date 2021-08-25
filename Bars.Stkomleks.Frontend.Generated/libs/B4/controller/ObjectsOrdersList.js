Ext.define('B4.controller.ObjectsOrdersList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ObjectsOrdersList',
        'B4.model.ObjectsOrdersListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-objectsorderslist',
    viewUid: '142d32b3-378a-44b6-8622-b6a199d85947',
    viewDataName: 'ObjectsOrdersList',
    // набор описаний действий реестра
    actions: {
        'Addition-ObjectsOrdersEditor-InWindow': {
            'editor': 'ObjectsOrdersEditor',
            'editorAlias': 'rms-objectsorderseditor',
            'editorUid': '6185abdb-13fa-4e36-a62b-20d4a979c7ec',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow'
        },
        'MultiAddition-ObjectsOrdersListMultiAddByZakazEditor-InWindow': {
            'editor': 'ObjectsOrdersListMultiAddByZakazEditor',
            'editorAlias': 'rms-objectsorderslistmultiaddbyzakazeditor',
            'editorUid': '4be82f55-200d-54ab-7f7d-a49288cbd00e',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 700,
                'width': 800
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-objectsorderslist': {
                'itemdblclick': function(sender, record, item, index) {
                    try {
                        var _self = this,
                            _args = Array.prototype.slice.call(arguments);
                        var grid = this.getDataGrid && this.getDataGrid() ? this.getDataGrid() : (this.is && (this.is('grid') || this.is('treepanel')) ? this : (this.up ? this.up('grid') || this.up('treepanel') : null)),
                            sel = grid && grid.getSelectionModel().getSelection()[0],
                            fld = sel && sel.get('Id'),
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
                        console.warn("Ошибка в событии `Двойной клик на строке` элемента `142d32b3-378a-44b6-8622-b6a199d85947`");
                        throw _e__r__r;
                    }
                }
            }
        });
        me.control({
            scope: me,
            'rms-objectsorderslist': {},
        });
        me.callParent(arguments);
    },
    applyCtxFilterParams: function(view, ctxParams) {
        var column = null;
    },
    onViewConnected: function(view) {
        this.callParent(arguments);
    },
});