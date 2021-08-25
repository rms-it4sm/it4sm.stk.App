Ext.define('B4.controller.OrdersObjectsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.OrdersObjectsList',
        'B4.model.OrdersObjectsListModel',
        'B4.aspects.StateContextMenu'],
    // псевдоним класса реестра
    viewAlias: 'rms-ordersobjectslist',
    viewUid: '503f008d-4c32-4e29-a3e4-536c5dbab2a4',
    viewDataName: 'OrdersObjectsList',
    // набор описаний действий реестра
    actions: {
        'Editing-OrdersObjectsEditor_Copy_0-Default': {
            'editor': 'OrdersObjectsEditor_Copy_0',
            'editorAlias': 'rms-ordersobjectseditor_copy_0',
            'editorUid': 'd0c2a2f2-1963-47b7-8908-491cb7e146fb',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'Default',
            'redirectTo': 'OrdersObjectsEditor_Copy_0/Edit/{id}/',
            'size': {
                'height': 768,
                'width': 1040
            }
        }
    },
    aspects: [{
        'gridSelector': 'rms-ordersobjectslist',
        'menuSelector': 'rmsOrdersObjectsListStateMenu',
        'name': 'rmsOrdersObjectsListStateAspect',
        'stateType': 'bars.stkomleks.ordersobjects',
        'xtype': 'b4_state_contextmenu'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-ordersobjectslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-OrdersObjectsEditor_Copy_0-Default', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-ordersobjectslist': {},
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