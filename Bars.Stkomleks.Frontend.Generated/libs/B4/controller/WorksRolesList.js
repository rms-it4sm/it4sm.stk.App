Ext.define('B4.controller.WorksRolesList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.WorksRolesList',
        'B4.model.WorksRolesListModel',
        'B4.aspects.RmsInlineGrid',
        'Ext.grid.plugin.CellEditing'],
    // псевдоним класса реестра
    viewAlias: 'rms-worksroleslist',
    viewUid: '3cc7cd9d-1d25-4a00-a4fe-f9bcf904f1ab',
    viewDataName: 'WorksRolesList',
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
        'cellEditPluginId': 'cellediting-worksroleslist',
        'gridSelector': 'rms-worksroleslist',
        'modelName': 'WorksRolesListModel',
        'name': 'rmsinlinegridaspect',
        'xtype': 'rmsinlinegridaspect'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-worksroleslist': {},
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