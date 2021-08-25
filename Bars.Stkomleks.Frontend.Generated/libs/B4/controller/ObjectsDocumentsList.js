Ext.define('B4.controller.ObjectsDocumentsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ObjectsDocumentsList',
        'B4.model.ObjectsDocumentsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-objectsdocumentslist',
    viewUid: '4bf4ac40-fac3-4c39-ac42-cfb6999a05b8',
    viewDataName: 'ObjectsDocumentsList',
    // набор описаний действий реестра
    actions: {
        'Addition-ObjectsDocumentsEditor-InWindow': {
            'editor': 'ObjectsDocumentsEditor',
            'editorAlias': 'rms-objectsdocumentseditor',
            'editorUid': 'ebd25f86-9526-4b73-bb5b-329f5758440d',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 235,
                'width': 500
            }
        },
        'Editing-ObjectsDocumentsEditor-InWindow': {
            'editor': 'ObjectsDocumentsEditor',
            'editorAlias': 'rms-objectsdocumentseditor',
            'editorUid': 'ebd25f86-9526-4b73-bb5b-329f5758440d',
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
            'rms-objectsdocumentslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-ObjectsDocumentsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-objectsdocumentslist': {},
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