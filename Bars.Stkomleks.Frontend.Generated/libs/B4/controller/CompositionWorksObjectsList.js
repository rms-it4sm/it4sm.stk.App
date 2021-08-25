Ext.define('B4.controller.CompositionWorksObjectsList', {
    extend: 'B4.base.registry.Controller',
    requires: [
        'B4.view.CompositionWorksObjectsList',
        'B4.model.CompositionWorksObjectsListModel',
        'B4.aspects.StateContextMenu'],
    // псевдоним класса реестра
    viewAlias: 'rms-compositionworksobjectslist',
    viewUid: '565aaf50-2e83-44ea-af8d-48f5646a28d6',
    viewDataName: 'CompositionWorksObjectsList',
    // набор описаний действий реестра
    actions: {
        'Addition-CompositionWorksObjectsEditor-InWindow': {
            'editor': 'CompositionWorksObjectsEditor',
            'editorAlias': 'rms-compositionworksobjectseditor',
            'editorUid': '4e04503b-095f-40ac-a590-d3b44110768f',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 315,
                'width': 800
            }
        },
        'Editing-CompositionWorksObjectsEditor-InWindow': {
            'editor': 'CompositionWorksObjectsEditor',
            'editorAlias': 'rms-compositionworksobjectseditor',
            'editorUid': '4e04503b-095f-40ac-a590-d3b44110768f',
            'hideToolbar': false,
            'maximizable': true,
            'mode': 'InWindow',
            'size': {
                'height': 315,
                'width': 800
            }
        }
    },
    aspects: [{
        'gridSelector': 'rms-compositionworksobjectslist',
        'menuSelector': 'rmsCompositionWorksObjectsListStateMenu',
        'name': 'rmsCompositionWorksObjectsListStateAspect',
        'stateType': 'bars.stkomleks.compositionworksobjects',
        'xtype': 'b4_state_contextmenu'
    }],
    init: function() {
        var me = this;
        me.control({
            scope: me,
            'rms-compositionworksobjectslist': {
                'itemdblclick': function(sender, record) {
                    if (!sender.panel || sender.panel.isDestroyed == true) return;
                    // Не открываем редактирование, если спрятан верхний тулбар
                    if (sender.panel.dockedItems && !sender.panel.dockedItems.items.filter(x => x.dock == 'top' && x.xtype == 'toolbar').length) return;
                    this.defaultEditActionHandler(false, 'Editing-CompositionWorksObjectsEditor-InWindow', sender.panel, record);
                }
            }
        });
        me.control({
            scope: me,
            'rms-compositionworksobjectslist': {},
        });
        me.callParent(arguments);
    },
    applyCtxFilterParams: function(view, ctxParams) {
        var column = null;
    },
    onViewConnected: function(view) {
        this.callParent(arguments);
        view.getStore().on({
            'beforeload': function(curStore, operation) {
                if (!curStore.sorters.getByProperty('ObjectElement_TypeElement_Name')) {
                    curStore.sorters.insert(0, {
                        property: 'ObjectElement_TypeElement_Name',
                        direction: 'ASC'
                    });
                    return false;
                }
                return true;
            }
        });
    },
});