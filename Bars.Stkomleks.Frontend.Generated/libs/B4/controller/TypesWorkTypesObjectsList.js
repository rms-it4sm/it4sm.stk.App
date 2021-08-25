Ext.define('B4.controller.TypesWorkTypesObjectsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.TypesWorkTypesObjectsList',
        'B4.model.TypesWorkTypesObjectsListModel'],
    // псевдоним класса реестра
    viewAlias: 'rms-typesworktypesobjectslist',
    viewUid: 'b82a0d6b-eb8d-4bc0-8c3a-5a7d9bc46c18',
    viewDataName: 'TypesWorkTypesObjectsList',
    // набор описаний действий реестра
    actions: {
        'MultiAddition-TypesWorkTypesObjectsListMultiAddByObjectTypeEditor-InWindow': {
            'editor': 'TypesWorkTypesObjectsListMultiAddByObjectTypeEditor',
            'editorAlias': 'rms-typesworktypesobjectslistmultiaddbyobjecttypeeditor',
            'editorUid': '29f93965-1a12-ded8-53ec-b1b5d225fe54',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 500,
                'width': 500
            }
        }
    },
    aspects: [],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-typesworktypesobjectslist': {},
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