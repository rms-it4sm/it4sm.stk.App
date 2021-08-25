Ext.define('B4.controller.UnitMeasureList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.UnitMeasureList',
        'B4.model.UnitMeasureListModel',
        'B4.aspects.RmsInlineGrid',
        'Ext.grid.plugin.CellEditing'],
    // псевдоним класса реестра
    viewAlias: 'rms-unitmeasurelist',
    viewUid: '6dc6ab7d-deb8-4e55-8c90-4fac46f30702',
    viewDataName: 'UnitMeasureList',
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
        'cellEditPluginId': 'cellediting-unitmeasurelist',
        'gridSelector': 'rms-unitmeasurelist',
        'modelName': 'UnitMeasureListModel',
        'name': 'rmsinlinegridaspect',
        'xtype': 'rmsinlinegridaspect'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-unitmeasurelist': {},
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