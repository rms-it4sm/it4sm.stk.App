Ext.define('B4.controller.ResponsiblePersonsOrderList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ResponsiblePersonsOrderList',
        'B4.model.ResponsiblePersonsOrderListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-responsiblepersonsorderlist',
    viewUid: 'ade124d1-dfa2-4ebc-abe4-958e13868259',
    viewDataName: 'ResponsiblePersonsOrderList',
    // набор описаний действий реестра
    actions: {
        'Addition-ResponsiblePersonsOrderEditor-InWindow': {
            'editor': 'ResponsiblePersonsOrderEditor',
            'editorAlias': 'rms-responsiblepersonsordereditor',
            'editorUid': '67d498ae-2835-45e6-972f-62b96a4979aa',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 205,
                'width': 500
            }
        },
        'Editing-ResponsiblePersonsOrderEditor-InWindow': {
            'editor': 'ResponsiblePersonsOrderEditor',
            'editorAlias': 'rms-responsiblepersonsordereditor',
            'editorUid': '67d498ae-2835-45e6-972f-62b96a4979aa',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 205,
                'width': 500
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-responsiblepersonsorderlist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-ResponsiblePersonsOrderEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-responsiblepersonsorderlist': {},
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