Ext.define('B4.controller.ObjectProductsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ObjectProductsList',
        'B4.model.ObjectProductsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-objectproductslist',
    viewUid: '218a4715-916c-405e-8a50-bbc28a353328',
    viewDataName: 'ObjectProductsList',
    // набор описаний действий реестра
    actions: {
        'Addition-ObjectProductsEditor-InWindow': {
            'editor': 'ObjectProductsEditor',
            'editorAlias': 'rms-objectproductseditor',
            'editorUid': '59e2e72a-5563-4787-bd22-7bdb89882368',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 600,
                'width': 800
            }
        },
        'Editing-ObjectProductsEditor-InWindow': {
            'editor': 'ObjectProductsEditor',
            'editorAlias': 'rms-objectproductseditor',
            'editorUid': '59e2e72a-5563-4787-bd22-7bdb89882368',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 600,
                'width': 800
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-objectproductslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-ObjectProductsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-objectproductslist': {},
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