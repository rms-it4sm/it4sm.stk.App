Ext.define('B4.controller.WorksTypesList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.WorksTypesList',
        'B4.model.WorksTypesListModel',
        'B4.aspects.RmsInlineGrid',
        'Ext.grid.plugin.CellEditing'],
    // псевдоним класса реестра
    viewAlias: 'rms-workstypeslist',
    viewUid: '3d27e730-89af-4b87-ae03-d40ba7d251e5',
    viewDataName: 'WorksTypesList',
    // набор описаний действий реестра
    actions: {
        'Add': {
            'actionName': 'inline-add',
            'IsInline': true
        },
        'Edit': {
            'actionName': 'inline-edit',
            'IsInline': true
        },
        'SaveAll': {
            'actionName': 'inline-save',
            'IsInline': true
        }
    },
    aspects: [{
        'cellEditPluginId': 'cellediting-workstypeslist',
        'gridSelector': 'rms-workstypeslist',
        'modelName': 'WorksTypesListModel',
        'name': 'rmsinlinegridaspect',
        'xtype': 'rmsinlinegridaspect'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-workstypeslist': {},
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