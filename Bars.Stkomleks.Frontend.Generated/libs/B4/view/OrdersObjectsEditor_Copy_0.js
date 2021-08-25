Ext.define('B4.view.OrdersObjectsEditor_Copy_0', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-ordersobjectseditor_copy_0',
    title: 'Объект.Изменение',
    rmsUid: 'd0c2a2f2-1963-47b7-8908-491cb7e146fb',
    rmsElementUid: 'd0c2a2f2-1963-47b7-8908-491cb7e146fb',
    dataSourceUid: 'aa6ab35e-8dca-491d-8261-0bf3c834ab3b',
    requires: [
        'B4.form.SelectField',
        'B4.view.CompositionObjectSpecialistsList',
        'B4.view.CompositionWorksObjectsList',
        'B4.view.ObjectProductsList',
        'B4.view.ObjectsDocumentsList',
        'B4.view.ObjectsOrdersList2',
        'B4.view.OrdersObjectsEditor'],
    statics: {
        windowSize: {
            height: 768,
            width: 1040
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'OrdersObjects_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'OrdersObjectsEditor',
        'modelProperty': 'OrdersObjectsEditor',
        'type': 'Form'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'items': [{
                'iconCls': 'fas fs-exchange-alt',
                'itemId': 'btnState',
                'menu': [],
                'text': 'Статус',
                'xtype': 'button'
            }],
            'xtype': 'buttongroup'
        }, {
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': 'd0c2a2f2-1963-47b7-8908-491cb7e146fb-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'OrdersObjectsEditor_Copy_0-container',
        'autoScroll': true,
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-867a7758-54ea-49cf-9247-66509b53b4d2',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-1b68dba7-4101-49f8-b4d1-7be2e1666e99',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dockedItems': null,
                    'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-7ac403e4-faf4-4360-9f50-df22ba53258b',
                    'flex': 1,
                    'header': false,
                    'idProperty': 'Id',
                    'modelProperty': 'OrdersObjectsEditor',
                    'name': 'OrdersObjectsEditor',
                    'region': 'Center',
                    'rmsUid': '7ac403e4-faf4-4360-9f50-df22ba53258b',
                    'tbar': null,
                    'title': null,
                    'xtype': 'rms-ordersobjectseditor'
                }],
                'layout': 'anchor',
                'rmsUid': '1b68dba7-4101-49f8-b4d1-7be2e1666e99',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '867a7758-54ea-49cf-9247-66509b53b4d2',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-a7490370-2042-43eb-8cda-c3a847bab32c',
            'fieldLabel': 'Панель закладок',
            'flex': 1,
            'header': false,
            'items': [{
                'dockedItems': [],
                'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-20003a88-1d05-488d-b6d4-45b2a48206ec',
                'fieldLabel': 'Заказы',
                'flex': 1,
                'iconCls': 'fad fa-clipboard-list-check',
                'items': [{
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
                                "DataIndex": "FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$f9b75007-4df7-4f66-8407-9646b73f634d$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@OrdersObjects_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-59e97e65-fbf0-44b6-8e99-3d95e98e21e3',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'ObjectsOrdersList2',
                    'region': 'Center',
                    'rmsUid': '59e97e65-fbf0-44b6-8e99-3d95e98e21e3',
                    'title': null,
                    'xtype': 'rms-objectsorderslist2'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '20003a88-1d05-488d-b6d4-45b2a48206ec',
                'title': 'Заказы',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-099e3673-e4c9-493b-a2ec-380075f89c64',
                'fieldLabel': 'Спецификация',
                'flex': 1,
                'iconCls': 'fad fa-store-alt',
                'items': [{
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
                                "DataIndex": "FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$834b602a-f4f4-4943-be32-d82c58e50ce7$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@OrdersObjects_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-fabd707c-82b8-44ed-9cdd-260f478ef401',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'ObjectProductsList',
                    'region': 'Center',
                    'rmsUid': 'fabd707c-82b8-44ed-9cdd-260f478ef401',
                    'title': null,
                    'xtype': 'rms-objectproductslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '099e3673-e4c9-493b-a2ec-380075f89c64',
                'title': 'Спецификация',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-3ae9ca09-7bf8-42a2-a452-da2bd2d42b10',
                'fieldLabel': 'Специалисты',
                'flex': 1,
                'hidden': true,
                'iconCls': 'fad fa-user-hard-hat',
                'items': [{
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
                                "DataIndex": "FieldPath://e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2$4dfa5472-c553-43e8-b2e7-af1b34fab335$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@OrdersObjects_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-33c89400-fcc8-47e0-bf6d-14ed0d4f4855',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'CompositionObjectSpecialistsList',
                    'region': 'Center',
                    'rmsUid': '33c89400-fcc8-47e0-bf6d-14ed0d4f4855',
                    'title': null,
                    'xtype': 'rms-compositionobjectspecialistslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '3ae9ca09-7bf8-42a2-a452-da2bd2d42b10',
                'title': 'Специалисты',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-870c57c5-c968-406e-ae85-a3337b5f35ca',
                'fieldLabel': 'Работы',
                'flex': 1,
                'iconCls': 'fad fa-digging',
                'items': [{
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
                                "DataIndex": "FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$e5e6c0c3-2740-40ee-9e6b-c98d69124498$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@OrdersObjects_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-78b27a1d-5b0d-49af-97e1-ccb97222cdba',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'CompositionWorksObjectsList',
                    'region': 'Center',
                    'rmsUid': '78b27a1d-5b0d-49af-97e1-ccb97222cdba',
                    'title': null,
                    'xtype': 'rms-compositionworksobjectslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '870c57c5-c968-406e-ae85-a3337b5f35ca',
                'title': 'Работы',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-9e93016b-e70e-4459-8a93-357650944dd1',
                'fieldLabel': 'Документы',
                'flex': 1,
                'iconCls': 'fad fa-file-alt',
                'items': [{
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
                                "DataIndex": "FieldPath://f83926a7-db81-4655-acb3-9a95778fe130$58f67435-6a62-4318-9ff7-af5953ffa9a6$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@OrdersObjects_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-d0c2a2f2-1963-47b7-8908-491cb7e146fb-34547090-ec5b-4be1-b5eb-6771419a6a2b',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'ObjectsDocumentsList',
                    'region': 'Center',
                    'rmsUid': '34547090-ec5b-4be1-b5eb-6771419a6a2b',
                    'title': null,
                    'xtype': 'rms-objectsdocumentslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '9e93016b-e70e-4459-8a93-357650944dd1',
                'title': 'Документы',
                'xtype': 'container'
            }],
            'layout': {
                'type': 'fit'
            },
            'region': 'Center',
            'rmsUid': 'a7490370-2042-43eb-8cda-c3a847bab32c',
            'title': null,
            'xtype': 'tabpanel'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'OrdersObjects_Id',
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
        me.grid_ObjectsOrdersList2 = me.down('rms-objectsorderslist2[name=ObjectsOrdersList2]');
        me.grid_ObjectProductsList = me.down('rms-objectproductslist[name=ObjectProductsList]');
        me.grid_CompositionObjectSpecialistsList = me.down('rms-compositionobjectspecialistslist[name=CompositionObjectSpecialistsList]');
        me.grid_CompositionWorksObjectsList = me.down('rms-compositionworksobjectslist[name=CompositionWorksObjectsList]');
        me.grid_ObjectsDocumentsList = me.down('rms-objectsdocumentslist[name=ObjectsDocumentsList]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
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