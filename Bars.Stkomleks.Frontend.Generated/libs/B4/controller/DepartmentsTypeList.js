Ext.define('B4.controller.DepartmentsTypeList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.DepartmentsTypeList',
        'B4.model.DepartmentsTypeListModel',
        'B4.aspects.RmsInlineGrid',
        'Ext.grid.plugin.CellEditing'],
    // псевдоним класса реестра
    viewAlias: 'rms-departmentstypelist',
    viewUid: '9b5801ef-5de5-4bf2-b517-99551e774036',
    viewDataName: 'DepartmentsTypeList',
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
        'cellEditPluginId': 'cellediting-departmentstypelist',
        'gridSelector': 'rms-departmentstypelist',
        'modelName': 'DepartmentsTypeListModel',
        'name': 'rmsinlinegridaspect',
        'xtype': 'rmsinlinegridaspect'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-departmentstypelist': {},
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