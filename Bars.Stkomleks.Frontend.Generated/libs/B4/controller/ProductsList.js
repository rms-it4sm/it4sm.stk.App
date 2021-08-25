Ext.define('B4.controller.ProductsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ProductsList',
        'B4.model.ProductsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-productslist',
    viewUid: 'b27e985c-2128-4576-a925-287ab689ba48',
    viewDataName: 'ProductsList',
    // набор описаний действий реестра
    actions: {
        'Addition-ProductsEditor-InWindow': {
            'editor': 'ProductsEditor',
            'editorAlias': 'rms-productseditor',
            'editorUid': '153ded49-b5ae-4c43-bdb2-a835368c2cf2',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 360,
                'width': 500
            }
        },
        'Editing-ProductsEditor-InWindow': {
            'editor': 'ProductsEditor',
            'editorAlias': 'rms-productseditor',
            'editorUid': '153ded49-b5ae-4c43-bdb2-a835368c2cf2',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 360,
                'width': 500
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-productslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-ProductsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-productslist': {},
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