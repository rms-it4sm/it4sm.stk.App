Ext.define('B4.controller.OrganizationFundingProgramsList2', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.OrganizationFundingProgramsList2',
        'B4.model.OrganizationFundingProgramsList2Model'],
    // псевдоним класса реестра
    viewAlias: 'rms-organizationfundingprogramslist2',
    viewUid: 'dbf839ff-91bd-4f87-a390-154f8db2a097',
    viewDataName: 'OrganizationFundingProgramsList2',
    // набор описаний действий реестра
    actions: {},
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-organizationfundingprogramslist2': {},
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