Ext.define('B4.controller.FundingProgramsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.FundingProgramsList',
        'B4.model.FundingProgramsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-fundingprogramslist',
    viewUid: '98fb8f30-8450-4f6b-b523-c7bbbb613896',
    viewDataName: 'FundingProgramsList',
    // набор описаний действий реестра
    actions: {
        'Addition-FundingProgramsEditor-InWindow': {
            'editor': 'FundingProgramsEditor',
            'editorAlias': 'rms-fundingprogramseditor',
            'editorUid': 'b26c9636-0eb1-412a-be11-c01993a415e2',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 500,
                'width': 600
            }
        },
        'Editing-FundingProgramsEditor-InWindow': {
            'editor': 'FundingProgramsEditor',
            'editorAlias': 'rms-fundingprogramseditor',
            'editorUid': 'b26c9636-0eb1-412a-be11-c01993a415e2',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 500,
                'width': 600
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-fundingprogramslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-FundingProgramsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-fundingprogramslist': {},
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