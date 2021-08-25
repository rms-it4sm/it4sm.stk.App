Ext.define('B4.controller.OrganizationProfilesList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.OrganizationProfilesList',
        'B4.model.OrganizationProfilesListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-organizationprofileslist',
    viewUid: '48cb21c4-9e41-4893-8056-c81344d7e489',
    viewDataName: 'OrganizationProfilesList',
    // набор описаний действий реестра
    actions: {
        'MultiAddition-OrganizationProfilesListMultiAddByOrganizationEditor-InWindow': {
            'editor': 'OrganizationProfilesListMultiAddByOrganizationEditor',
            'editorAlias': 'rms-organizationprofileslistmultiaddbyorganizationeditor',
            'editorUid': '83ebe89f-a43d-17d2-5f92-8ac69dd34e43',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 500,
                'width': 500
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-organizationprofileslist': {},
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