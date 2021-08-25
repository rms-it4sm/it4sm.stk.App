Ext.define('B4.controller.OrganizationProfilesList2', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.OrganizationProfilesList2',
        'B4.model.OrganizationProfilesList2Model'],
    // псевдоним класса реестра
    viewAlias: 'rms-organizationprofileslist2',
    viewUid: 'e0e0f8f2-1a95-477b-9208-680d865acb04',
    viewDataName: 'OrganizationProfilesList2',
    // набор описаний действий реестра
    actions: {},
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-organizationprofileslist2': {},
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