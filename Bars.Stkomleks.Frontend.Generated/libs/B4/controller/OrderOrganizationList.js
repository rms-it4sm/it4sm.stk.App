Ext.define('B4.controller.OrderOrganizationList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.OrderOrganizationList',
        'B4.model.OrderOrganizationListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-orderorganizationlist',
    viewUid: 'd3820c7f-83ff-4c5a-b48f-6cc81381a422',
    viewDataName: 'OrderOrganizationList',
    // набор описаний действий реестра
    actions: {
        'Addition-OrderOrganizationEditor-InWindow': {
            'editor': 'OrderOrganizationEditor',
            'editorAlias': 'rms-orderorganizationeditor',
            'editorUid': '51b898b7-bab8-4c73-b0d3-856ce114d842',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 600,
                'width': 600
            }
        },
        'Editing-OrderOrganizationEditor-InWindow': {
            'editor': 'OrderOrganizationEditor',
            'editorAlias': 'rms-orderorganizationeditor',
            'editorUid': '51b898b7-bab8-4c73-b0d3-856ce114d842',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 600,
                'width': 600
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-orderorganizationlist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-OrderOrganizationEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-orderorganizationlist': {},
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