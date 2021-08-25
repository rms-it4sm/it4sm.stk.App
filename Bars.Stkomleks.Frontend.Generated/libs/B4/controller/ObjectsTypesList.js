Ext.define('B4.controller.ObjectsTypesList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.ObjectsTypesList',
        'B4.model.ObjectsTypesListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-objectstypeslist',
    viewUid: 'fc7e521c-af45-4f93-8368-b267ae1c7667',
    viewDataName: 'ObjectsTypesList',
    // набор описаний действий реестра
    actions: {
        'Addition-ObjectsTypesEditor-InWindow': {
            'editor': 'ObjectsTypesEditor',
            'editorAlias': 'rms-objectstypeseditor',
            'editorUid': '88f43eeb-7601-4451-bc70-14cfe8179b08',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 498,
                'width': 500
            }
        },
        'Editing-ObjectsTypesEditor-InWindow': {
            'editor': 'ObjectsTypesEditor',
            'editorAlias': 'rms-objectstypeseditor',
            'editorUid': '88f43eeb-7601-4451-bc70-14cfe8179b08',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 498,
                'width': 500
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-objectstypeslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-ObjectsTypesEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-objectstypeslist': {},
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