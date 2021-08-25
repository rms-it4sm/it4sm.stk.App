Ext.define('B4.controller.PositionsTypesList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.PositionsTypesList',
        'B4.model.PositionsTypesListModel',
        'B4.aspects.RmsInlineGrid',
        'Ext.grid.plugin.CellEditing'],
    // псевдоним класса реестра
    viewAlias: 'rms-positionstypeslist',
    viewUid: '737bdcf7-5e44-44a4-96dc-b4bd3152a50a',
    viewDataName: 'PositionsTypesList',
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
        'cellEditPluginId': 'cellediting-positionstypeslist',
        'gridSelector': 'rms-positionstypeslist',
        'modelName': 'PositionsTypesListModel',
        'name': 'rmsinlinegridaspect',
        'xtype': 'rmsinlinegridaspect'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-positionstypeslist': {},
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