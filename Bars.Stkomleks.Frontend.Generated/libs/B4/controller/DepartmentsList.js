Ext.define('B4.controller.DepartmentsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.DepartmentsList',
        'B4.model.DepartmentsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-departmentslist',
    viewUid: 'bdc47f6f-8733-41c3-a5d1-5d42d7af5594',
    viewDataName: 'DepartmentsList',
    // набор описаний действий реестра
    actions: {
        'Addition-DepartmentsEditor-InWindow': {
            'editor': 'DepartmentsEditor',
            'editorAlias': 'rms-departmentseditor',
            'editorUid': '130c4db5-a9b3-4c6f-b37e-01182825968c',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 600,
                'width': 600
            }
        },
        'Editing-DepartmentsEditor-InWindow': {
            'editor': 'DepartmentsEditor',
            'editorAlias': 'rms-departmentseditor',
            'editorUid': '130c4db5-a9b3-4c6f-b37e-01182825968c',
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
            'rms-departmentslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-DepartmentsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-departmentslist': {},
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