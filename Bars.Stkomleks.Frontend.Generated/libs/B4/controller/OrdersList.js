Ext.define('B4.controller.OrdersList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.OrdersList',
        'B4.model.OrdersListModel',
        'B4.aspects.StateContextMenu'],
    // псевдоним класса реестра
    viewAlias: 'rms-orderslist',
    viewUid: 'd93953ac-6978-4661-a1b4-39b7805429ac',
    viewDataName: 'OrdersList',
    // набор описаний действий реестра
    actions: {
        'Addition-OrdersEditor-InWindow': {
            'editor': 'OrdersEditor',
            'editorAlias': 'rms-orderseditor',
            'editorUid': 'b3d0c6e3-6410-4c8b-b359-da6efc0248e9',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 600,
                'width': 700
            }
        },
        'Editing-OrdersEditor-Default': {
            'editor': 'OrdersEditor',
            'editorAlias': 'rms-orderseditor',
            'editorUid': 'b3d0c6e3-6410-4c8b-b359-da6efc0248e9',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'Default',
            'redirectTo': 'OrdersEditor/Edit/{id}/',
            'size': {
                'height': 600,
                'width': 700
            }
        }
    },
    aspects: [{
        'gridSelector': 'rms-orderslist',
        'menuSelector': 'rmsOrdersListStateMenu',
        'name': 'rmsOrdersListStateAspect',
        'stateType': 'bars.stkomleks.zakaz',
        'xtype': 'b4_state_contextmenu'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-orderslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-OrdersEditor-Default', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-orderslist': {},
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