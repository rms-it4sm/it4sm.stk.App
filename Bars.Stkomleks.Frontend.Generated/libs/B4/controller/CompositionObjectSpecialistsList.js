Ext.define('B4.controller.CompositionObjectSpecialistsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.CompositionObjectSpecialistsList',
        'B4.model.CompositionObjectSpecialistsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-compositionobjectspecialistslist',
    viewUid: '937c5337-375e-4581-8bd2-24c49f8e9bd7',
    viewDataName: 'CompositionObjectSpecialistsList',
    // набор описаний действий реестра
    actions: {
        'Addition-CompositionObjectSpecialistsEditor-InWindow': {
            'editor': 'CompositionObjectSpecialistsEditor',
            'editorAlias': 'rms-compositionobjectspecialistseditor',
            'editorUid': '77a6afbc-c73b-4ee9-af30-3fa36d6a8a37',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 235,
                'width': 600
            }
        },
        'Editing-CompositionObjectSpecialistsEditor-InWindow': {
            'editor': 'CompositionObjectSpecialistsEditor',
            'editorAlias': 'rms-compositionobjectspecialistseditor',
            'editorUid': '77a6afbc-c73b-4ee9-af30-3fa36d6a8a37',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 235,
                'width': 600
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-compositionobjectspecialistslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-CompositionObjectSpecialistsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-compositionobjectspecialistslist': {},
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