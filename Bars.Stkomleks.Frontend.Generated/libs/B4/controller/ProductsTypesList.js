Ext.define('B4.controller.ProductsTypesList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ProductsTypesList',
        'B4.model.ProductsTypesListModel',
        'B4.aspects.RmsInlineGrid',
        'Ext.grid.plugin.CellEditing'],
    // псевдоним класса реестра
    viewAlias: 'rms-productstypeslist',
    viewUid: '5af375bb-5a64-4d0c-a176-bea50230e573',
    viewDataName: 'ProductsTypesList',
    // набор описаний действий реестра
    actions: {
        'Add': {
            'actionName': 'inline-add',
            'IsInline': true
        },
        'Edit': {
            'actionName': 'inline-edit',
            'IsInline': true
        },
        'SaveAll': {
            'actionName': 'inline-save',
            'IsInline': true
        }
    },
    aspects: [{
        'cellEditPluginId': 'cellediting-productstypeslist',
        'gridSelector': 'rms-productstypeslist',
        'modelName': 'ProductsTypesListModel',
        'name': 'rmsinlinegridaspect',
        'xtype': 'rmsinlinegridaspect'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-productstypeslist': {},
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