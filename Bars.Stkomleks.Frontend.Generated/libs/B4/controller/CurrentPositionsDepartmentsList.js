Ext.define('B4.controller.CurrentPositionsDepartmentsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.CurrentPositionsDepartmentsList',
        'B4.model.CurrentPositionsDepartmentsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-currentpositionsdepartmentslist',
    viewUid: 'b70dd896-3c2d-42e2-ae24-fd54d7fa5a43',
    viewDataName: 'CurrentPositionsDepartmentsList',
    // набор описаний действий реестра
    actions: {
        'Addition-CurrentPositionsDepartmentsEditor-InWindow': {
            'editor': 'CurrentPositionsDepartmentsEditor',
            'editorAlias': 'rms-currentpositionsdepartmentseditor',
            'editorUid': '5384176d-011e-4051-a1ad-61487308dd00',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 295,
                'width': 500
            }
        },
        'Editing-CurrentPositionsDepartmentsEditor-InWindow': {
            'editor': 'CurrentPositionsDepartmentsEditor',
            'editorAlias': 'rms-currentpositionsdepartmentseditor',
            'editorUid': '5384176d-011e-4051-a1ad-61487308dd00',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 295,
                'width': 500
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-currentpositionsdepartmentslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-CurrentPositionsDepartmentsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-currentpositionsdepartmentslist': {},
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