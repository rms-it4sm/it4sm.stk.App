Ext.define('B4.controller.IndividualsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.IndividualsList',
        'B4.model.IndividualsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-individualslist',
    viewUid: '33f0a694-0fd2-4fee-9b06-8b6a2d5f9fa4',
    viewDataName: 'IndividualsList',
    // набор описаний действий реестра
    actions: {
        'Addition-IndividualsEditor-InWindow': {
            'editor': 'IndividualsEditor',
            'editorAlias': 'rms-individualseditor',
            'editorUid': '2efed10a-d54e-46b9-ac19-6b9792c2fb9e',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 295,
                'width': 600
            }
        },
        'Editing-IndividualsEditor-InWindow': {
            'editor': 'IndividualsEditor',
            'editorAlias': 'rms-individualseditor',
            'editorUid': '2efed10a-d54e-46b9-ac19-6b9792c2fb9e',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 295,
                'width': 600
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-individualslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-IndividualsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-individualslist': {},
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