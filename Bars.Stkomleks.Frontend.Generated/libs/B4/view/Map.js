Ext.define('B4.view.Map', {
    extend: 'B4.base.panel.View',
    alias: 'widget.rms-map',
    title: 'Карта',
    rmsUid: 'a5a9b3ff-b146-4ee9-a217-ff1db91e7271',
    rmsElementUid: 'a5a9b3ff-b146-4ee9-a217-ff1db91e7271',
    requires: [],
    'layout': {
        'type': 'anchor'
    },
    'region': 'Center',
    dockedItems: [{
        'dock': 'top',
        'items': [],
        'rmsUid': 'a5a9b3ff-b146-4ee9-a217-ff1db91e7271-Panel-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        'anchor': '100%',
        'dockedItems': [],
        'extraCls': 'cmp-style-a5a9b3ff-b146-4ee9-a217-ff1db91e7271-53800ed4-8b93-4ee1-a6ac-e3cf47c0ed16',
        'fieldLabel': null,
        'rmsUid': '53800ed4-8b93-4ee1-a6ac-e3cf47c0ed16',
        'title': null,
        'xtype': 'container'
    }],
    initComponent: function() {
        var me = this;
        me.callParent(arguments);
    }
});