Ext.define('B4.controller.OrganizationFundingProgramsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.OrganizationFundingProgramsList',
        'B4.model.OrganizationFundingProgramsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-organizationfundingprogramslist',
    viewUid: 'e8cec20f-24a8-4cc3-9a21-ebf7a34c9d41',
    viewDataName: 'OrganizationFundingProgramsList',
    // набор описаний действий реестра
    actions: {
        'MultiAddition-OrganizationFundingProgramsListMultiAddByOrganizationEditor-InWindow': {
            'editor': 'OrganizationFundingProgramsListMultiAddByOrganizationEditor',
            'editorAlias': 'rms-organizationfundingprogramslistmultiaddbyorganizationeditor',
            'editorUid': 'c2a5c600-80de-0cf0-9304-42a9df7ae60e',
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
            'rms-organizationfundingprogramslist': {},
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