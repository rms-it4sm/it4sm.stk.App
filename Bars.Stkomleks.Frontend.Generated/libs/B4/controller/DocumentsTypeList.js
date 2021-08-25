Ext.define('B4.controller.DocumentsTypeList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.DocumentsTypeList',
        'B4.model.DocumentsTypeListModel',
        'B4.aspects.RmsInlineGrid',
        'Ext.grid.plugin.CellEditing'],
    // псевдоним класса реестра
    viewAlias: 'rms-documentstypelist',
    viewUid: '7211ad48-2f3c-428f-988e-38a03c467294',
    viewDataName: 'DocumentsTypeList',
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
        'cellEditPluginId': 'cellediting-documentstypelist',
        'gridSelector': 'rms-documentstypelist',
        'modelName': 'DocumentsTypeListModel',
        'name': 'rmsinlinegridaspect',
        'xtype': 'rmsinlinegridaspect'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-documentstypelist': {},
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