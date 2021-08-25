Ext.define('B4.controller.DepartmentsPositionsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.DepartmentsPositionsList',
        'B4.model.DepartmentsPositionsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-departmentspositionslist',
    viewUid: 'e426d6c0-7d71-41fd-9a08-4914f84af209',
    viewDataName: 'DepartmentsPositionsList',
    // набор описаний действий реестра
    actions: {
        'Addition-DepartmentsPositionsEditor-InWindow': {
            'editor': 'DepartmentsPositionsEditor',
            'editorAlias': 'rms-departmentspositionseditor',
            'editorUid': '23beb68e-9c91-43c1-a435-257bf4e15d1b',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 500,
                'width': 700
            }
        },
        'Editing-DepartmentsPositionsEditor-InWindow': {
            'editor': 'DepartmentsPositionsEditor',
            'editorAlias': 'rms-departmentspositionseditor',
            'editorUid': '23beb68e-9c91-43c1-a435-257bf4e15d1b',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 500,
                'width': 700
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-departmentspositionslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-DepartmentsPositionsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-departmentspositionslist': {},
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