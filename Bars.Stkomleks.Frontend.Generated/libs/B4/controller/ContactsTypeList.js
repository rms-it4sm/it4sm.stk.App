Ext.define('B4.controller.ContactsTypeList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ContactsTypeList',
        'B4.model.ContactsTypeListModel',
        'B4.aspects.RmsInlineGrid',
        'Ext.grid.plugin.CellEditing'],
    // псевдоним класса реестра
    viewAlias: 'rms-contactstypelist',
    viewUid: '48303e21-0e2e-4ecc-9c5a-1f32519b2ff9',
    viewDataName: 'ContactsTypeList',
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
        'cellEditPluginId': 'cellediting-contactstypelist',
        'gridSelector': 'rms-contactstypelist',
        'modelName': 'ContactsTypeListModel',
        'name': 'rmsinlinegridaspect',
        'xtype': 'rmsinlinegridaspect'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-contactstypelist': {},
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