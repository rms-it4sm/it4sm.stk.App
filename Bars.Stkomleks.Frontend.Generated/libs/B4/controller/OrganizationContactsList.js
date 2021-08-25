Ext.define('B4.controller.OrganizationContactsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.OrganizationContactsList',
        'B4.model.OrganizationContactsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-organizationcontactslist',
    viewUid: 'a2b814e9-17f9-4573-ac19-8787d7ae0bb4',
    viewDataName: 'OrganizationContactsList',
    // набор описаний действий реестра
    actions: {
        'Addition-OrganizationContactsEditor-InWindow': {
            'editor': 'OrganizationContactsEditor',
            'editorAlias': 'rms-organizationcontactseditor',
            'editorUid': 'ecb21833-eea4-4cc6-abf7-af8875eff7fe',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 235,
                'width': 500
            }
        },
        'Editing-OrganizationContactsEditor-InWindow': {
            'editor': 'OrganizationContactsEditor',
            'editorAlias': 'rms-organizationcontactseditor',
            'editorUid': 'ecb21833-eea4-4cc6-abf7-af8875eff7fe',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 235,
                'width': 500
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-organizationcontactslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-OrganizationContactsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-organizationcontactslist': {},
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