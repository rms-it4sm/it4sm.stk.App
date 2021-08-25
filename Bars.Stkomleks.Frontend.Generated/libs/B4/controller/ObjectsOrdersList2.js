Ext.define('B4.controller.ObjectsOrdersList2', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ObjectsOrdersList2',
        'B4.model.ObjectsOrdersList2Model'],
    // псевдоним класса реестра
    viewAlias: 'rms-objectsorderslist2',
    viewUid: 'e21449a3-6c79-4d88-a466-501c496fa133',
    viewDataName: 'ObjectsOrdersList2',
    // набор описаний действий реестра
    actions: {},
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-objectsorderslist2': {},
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