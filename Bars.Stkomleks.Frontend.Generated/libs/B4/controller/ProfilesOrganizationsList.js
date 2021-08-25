Ext.define('B4.controller.ProfilesOrganizationsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ProfilesOrganizationsList',
        'B4.model.ProfilesOrganizationsListModel',
        'B4.aspects.RmsInlineGrid',
        'Ext.grid.plugin.CellEditing'],
    // псевдоним класса реестра
    viewAlias: 'rms-profilesorganizationslist',
    viewUid: '11e97eb6-e81f-43ad-9fbd-1dca834a10a5',
    viewDataName: 'ProfilesOrganizationsList',
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
        'cellEditPluginId': 'cellediting-profilesorganizationslist',
        'gridSelector': 'rms-profilesorganizationslist',
        'modelName': 'ProfilesOrganizationsListModel',
        'name': 'rmsinlinegridaspect',
        'xtype': 'rmsinlinegridaspect'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-profilesorganizationslist': {},
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