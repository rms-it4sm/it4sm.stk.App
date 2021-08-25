Ext.define('B4.controller.OrganizationList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.OrganizationList',
        'B4.model.OrganizationListModel',
        'B4.aspects.StateContextMenu'],
    // псевдоним класса реестра
    viewAlias: 'rms-organizationlist',
    viewUid: '0bd08e33-3c9d-4a0a-9c2b-26b65bec5f67',
    viewDataName: 'OrganizationList',
    // набор описаний действий реестра
    actions: {
        'Addition-OrganizationEditor-InWindow': {
            'editor': 'OrganizationEditor',
            'editorAlias': 'rms-organizationeditor',
            'editorUid': '7bfd891d-f74e-48c4-9141-e68896e91cc3',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 600,
                'width': 700
            }
        },
        'Editing-OrganizationEditor-InWindow': {
            'editor': 'OrganizationEditor',
            'editorAlias': 'rms-organizationeditor',
            'editorUid': '7bfd891d-f74e-48c4-9141-e68896e91cc3',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 600,
                'width': 700
            }
        }
    },
    aspects: [{
        'gridSelector': 'rms-organizationlist',
        'menuSelector': 'rmsOrganizationListStateMenu',
        'name': 'rmsOrganizationListStateAspect',
        'stateType': 'bars.stkomleks.organization',
        'xtype': 'b4_state_contextmenu'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-organizationlist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-OrganizationEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-organizationlist': {},
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