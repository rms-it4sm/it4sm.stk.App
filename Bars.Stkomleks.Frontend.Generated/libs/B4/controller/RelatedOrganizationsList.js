Ext.define('B4.controller.RelatedOrganizationsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.RelatedOrganizationsList',
        'B4.model.RelatedOrganizationsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-relatedorganizationslist',
    viewUid: '01d8c8b1-e594-4e37-82c3-393eef428677',
    viewDataName: 'RelatedOrganizationsList',
    // набор описаний действий реестра
    actions: {
        'MultiAddition-RelatedOrganizationsListMultiAddByOrganizationEditor-InWindow': {
            'editor': 'RelatedOrganizationsListMultiAddByOrganizationEditor',
            'editorAlias': 'rms-relatedorganizationslistmultiaddbyorganizationeditor',
            'editorUid': '1a966ea7-1e15-5145-e7f8-e3b91e3056ae',
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
            'rms-relatedorganizationslist': {},
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