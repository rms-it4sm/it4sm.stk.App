Ext.define('B4.view.ObjectsTypesEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-objectstypeseditor',
    title: 'Тип объекта',
    rmsUid: '88f43eeb-7601-4451-bc70-14cfe8179b08',
    rmsElementUid: '88f43eeb-7601-4451-bc70-14cfe8179b08',
    dataSourceUid: '0140e24b-1df6-4672-8302-a2a0cada0e53',
    requires: [
        'B4.view.TypesWorkTypesObjectsList',
        'BarsUp.form.field.Color'],
    statics: {
        windowSize: {
            height: 498,
            width: 500
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'ObjectsTypes_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Name',
        'modelProperty': 'ObjectsTypes_Name',
        'type': 'TextField'
    }, {
        'dataIndex': 'IconObjectType',
        'modelProperty': 'ObjectsTypes_IconObjectType',
        'type': 'TextField'
    }, {
        'dataIndex': 'ColorIconObjectType',
        'modelProperty': 'ObjectsTypes_ColorIconObjectType',
        'type': 'ColorFieldAdvancedControl'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '88f43eeb-7601-4451-bc70-14cfe8179b08-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'ObjectsTypesEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-88f43eeb-7601-4451-bc70-14cfe8179b08-4a49beda-3b0f-431b-9a3e-92b4755bb238',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-88f43eeb-7601-4451-bc70-14cfe8179b08-ca4a6169-9dc3-4370-97d3-3861cbdc670a',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://0140e24b-1df6-4672-8302-a2a0cada0e53$dfde2099-4a59-4d2f-8d32-43143b4ec043',
                    'extraCls': 'cmp-style-88f43eeb-7601-4451-bc70-14cfe8179b08-a543d799-f327-40a3-b39f-c0a7e2dd658b',
                    'fieldLabel': 'Наименование',
                    'labelAlign': 'top',
                    'modelProperty': 'ObjectsTypes_Name',
                    'name': 'Name',
                    'rmsUid': 'a543d799-f327-40a3-b39f-c0a7e2dd658b',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'ca4a6169-9dc3-4370-97d3-3861cbdc670a',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '4a49beda-3b0f-431b-9a3e-92b4755bb238',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-88f43eeb-7601-4451-bc70-14cfe8179b08-9d8e80d1-6a63-40f0-abd7-9baea034bcd3',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-88f43eeb-7601-4451-bc70-14cfe8179b08-a43b6c5a-0195-4ac8-906a-4e07dfd416c9',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://0140e24b-1df6-4672-8302-a2a0cada0e53$378de02a-7f1a-4c7b-95b3-50300ef739fc',
                    'extraCls': 'cmp-style-88f43eeb-7601-4451-bc70-14cfe8179b08-03c3dd4d-f056-4e5a-b0dd-47fd23e69b09',
                    'fieldLabel': 'Иконка',
                    'labelAlign': 'top',
                    'modelProperty': 'ObjectsTypes_IconObjectType',
                    'name': 'IconObjectType',
                    'rmsUid': '03c3dd4d-f056-4e5a-b0dd-47fd23e69b09',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'a43b6c5a-0195-4ac8-906a-4e07dfd416c9',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-88f43eeb-7601-4451-bc70-14cfe8179b08-3fe7537b-430f-40f6-b92d-b9cf6a8f468a',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://0140e24b-1df6-4672-8302-a2a0cada0e53$636a1f06-c235-4cd7-b3e3-3bdbf248e0cf',
                    'extraCls': 'cmp-style-88f43eeb-7601-4451-bc70-14cfe8179b08-cf8e7da9-9ef1-41ff-90ce-f71ec541f58e',
                    'fieldLabel': 'Цвет',
                    'labelAlign': 'top',
                    'modelProperty': 'ObjectsTypes_ColorIconObjectType',
                    'name': 'ColorIconObjectType',
                    'rmsUid': 'cf8e7da9-9ef1-41ff-90ce-f71ec541f58e',
                    'xtype': 'bars.colorfield'
                }],
                'layout': 'anchor',
                'rmsUid': '3fe7537b-430f-40f6-b92d-b9cf6a8f468a',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '9d8e80d1-6a63-40f0-abd7-9baea034bcd3',
            'xtype': 'container'
        }, {
            '$EntityFilter': {
                'LinkFilter': {
                    "Group": 3,
                    "Operand": 0,
                    "DataIndex": null,
                    "DataIndexType": null,
                    "Value": null,
                    "Filters": [{
                        "Group": 0,
                        "Operand": 0,
                        "DataIndex": "FieldPath://ceb87fbf-759c-4e7f-bc92-3a605d913ad5$851be698-95e0-465e-b419-95da45ec8f8b$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                        "DataIndexType": null,
                        "Value": "@ObjectsTypes_Id",
                        "Filters": null,
                        "IsEmpty": false
                    }],
                    "IsEmpty": false
                }
            },
            'closable': false,
            'extraCls': 'cmp-style-88f43eeb-7601-4451-bc70-14cfe8179b08-d9897e33-543c-44b4-a708-0f4bb84082c3',
            'flex': 1,
            'inlineCascadeSave': false,
            'name': 'TypesWorkTypesObjectsList',
            'region': 'Center',
            'rmsUid': 'd9897e33-543c-44b4-a708-0f4bb84082c3',
            'title': 'Виды работ',
            'xtype': 'rms-typesworktypesobjectslist'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'ObjectsTypes_Id',
                'name': 'Id',
                'xtype': 'hidden'
            }],
            'xtype': 'panel'
        }]
    }],
    plugins: [],
    initComponent: function() {
        var me = this;
        me.callParent(arguments);
        me.submitTimeout = 20;
        me.grid_TypesWorkTypesObjectsList = me.down('rms-typesworktypesobjectslist[name=TypesWorkTypesObjectsList]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Добавление типа объекта');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        if (Ext.isNumber(entityId) && entityId > 0) {
            me.setTitle(rec.get('Name'));
        }
        return res;
    },
});