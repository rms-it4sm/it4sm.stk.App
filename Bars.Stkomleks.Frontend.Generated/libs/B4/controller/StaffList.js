Ext.define('B4.controller.StaffList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.StaffList',
        'B4.model.StaffListModel',
        'B4.aspects.StateContextMenu'],
    // псевдоним класса реестра
    viewAlias: 'rms-stafflist',
    viewUid: '23f0a883-68a9-4383-992d-974be0e55c0c',
    viewDataName: 'StaffList',
    // набор описаний действий реестра
    actions: {
        'Addition-StaffEditor-InWindow': {
            'editor': 'StaffEditor',
            'editorAlias': 'rms-staffeditor',
            'editorUid': '20f3ec7c-e4f4-41e3-b814-2d79b589ae80',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 235,
                'width': 500
            }
        },
        'Editing-StaffEditor-InWindow': {
            'editor': 'StaffEditor',
            'editorAlias': 'rms-staffeditor',
            'editorUid': '20f3ec7c-e4f4-41e3-b814-2d79b589ae80',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 235,
                'width': 500
            }
        }
    },
    aspects: [{
        'gridSelector': 'rms-stafflist',
        'menuSelector': 'rmsStaffListStateMenu',
        'name': 'rmsStaffListStateAspect',
        'stateType': 'bars.stkomleks.staff',
        'xtype': 'b4_state_contextmenu'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-stafflist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-StaffEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-stafflist': {},
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