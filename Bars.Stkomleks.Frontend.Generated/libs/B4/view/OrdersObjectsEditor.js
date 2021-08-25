Ext.define('B4.view.OrdersObjectsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-ordersobjectseditor',
    title: 'Объект.Создание',
    rmsUid: '395dbab2-e4ab-4846-b876-dbf8b577d6d9',
    rmsElementUid: '395dbab2-e4ab-4846-b876-dbf8b577d6d9',
    dataSourceUid: 'aa6ab35e-8dca-491d-8261-0bf3c834ab3b',
    requires: [
        'B4.form.PickerField',
        'B4.model.ObjectsTypesListModel',
        'B4.model.OrdersListModel',
        'B4.view.ObjectsTypesList',
        'B4.view.OrdersList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 500,
            width: 800
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'OrdersObjects_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Zakaz',
        'modelProperty': 'OrdersObjects_Zakaz',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Type',
        'modelProperty': 'OrdersObjects_Type',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Name',
        'modelProperty': 'OrdersObjects_Name',
        'type': 'TextField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'OrdersObjects_Comment',
        'type': 'TextAreaField'
    }, {
        'dataIndex': 'Lon',
        'modelProperty': 'OrdersObjects_Lon',
        'type': 'HiddenField'
    }, {
        'dataIndex': 'Lat',
        'modelProperty': 'OrdersObjects_Lat',
        'type': 'HiddenField'
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
        'rmsUid': '395dbab2-e4ab-4846-b876-dbf8b577d6d9-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'OrdersObjectsEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-8e595a72-3f05-4b1e-aeaf-2781678806d4',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-43c8a2f4-122d-4b50-a649-2b1a42684630',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dockedItems': [],
                    'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-9c6c20bb-7115-4d08-bb0b-81814d714ef4',
                    'items': [{
                        'defaults': {
                            'margin': '5 5 5 5'
                        },
                        'dockedItems': [],
                        'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-48970320-6a5b-4700-95e6-70dd275f23c4',
                        'flex': 1,
                        'items': [{
                            'anchor': '100%',
                            'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$b059c2ef-ece8-4541-8ca6-11a818c0a53a',
                            'editable': false,
                            'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-faa15d75-45a3-402c-ba44-7328200f8326',
                            'fieldLabel': 'Заказ',
                            'idProperty': 'Id',
                            'isContextAware': true,
                            'labelAlign': 'top',
                            'listView': 'B4.view.OrdersList',
                            'listViewCtl': 'B4.controller.OrdersList',
                            'maximizable': true,
                            'model': 'B4.model.OrdersListModel',
                            'modelProperty': 'OrdersObjects_Zakaz',
                            'name': 'Zakaz',
                            'plugins': [{
                                'ptype': 'versioningpickerfieldplugin'
                            }],
                            'rmsUid': 'faa15d75-45a3-402c-ba44-7328200f8326',
                            'textProperty': 'Number',
                            'typeAhead': false,
                            'windowCfg': {
                                'border': false,
                                'height': 550,
                                'maximizable': true,
                                'title': 'Заказ',
                                'width': 600
                            },
                            'xtype': 'b4pickerfield'
                        }],
                        'layout': 'anchor',
                        'rmsUid': '48970320-6a5b-4700-95e6-70dd275f23c4',
                        'xtype': 'container'
                    }],
                    'layout': 'hbox',
                    'rmsUid': '9c6c20bb-7115-4d08-bb0b-81814d714ef4',
                    'xtype': 'container'
                }, {
                    'anchor': '100%',
                    'dockedItems': [],
                    'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-abf88e01-30b7-4f4d-bc8d-cac4b109047b',
                    'items': [{
                        'defaults': {
                            'margin': '5 5 5 5'
                        },
                        'dockedItems': [],
                        'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-d2ad9e08-d462-429f-99a0-c928a8e58c7b',
                        'flex': 1,
                        'items': [{
                            'anchor': '100%',
                            'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$a861dd69-8067-4c54-a160-4086f003580f',
                            'editable': false,
                            'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-0f18129a-9cc4-4822-9706-7b4c8d14676c',
                            'fieldLabel': 'Тип',
                            'hiddenListFields': [
                                'IconObjectType',
                                'ColorIconObjectType'],
                            'idProperty': 'Id',
                            'isContextAware': true,
                            'isForChoiceOnly': true,
                            'labelAlign': 'top',
                            'listView': 'B4.view.ObjectsTypesList',
                            'listViewCtl': 'B4.controller.ObjectsTypesList',
                            'maximizable': true,
                            'model': 'B4.model.ObjectsTypesListModel',
                            'modelProperty': 'OrdersObjects_Type',
                            'name': 'Type',
                            'plugins': [{
                                'ptype': 'versioningpickerfieldplugin'
                            }],
                            'rmsUid': '0f18129a-9cc4-4822-9706-7b4c8d14676c',
                            'textProperty': 'Name',
                            'typeAhead': false,
                            'windowCfg': {
                                'border': false,
                                'height': 550,
                                'maximizable': true,
                                'title': 'Тип',
                                'width': 600
                            },
                            'xtype': 'b4pickerfield'
                        }],
                        'layout': 'anchor',
                        'rmsUid': 'd2ad9e08-d462-429f-99a0-c928a8e58c7b',
                        'xtype': 'container'
                    }],
                    'layout': 'hbox',
                    'rmsUid': 'abf88e01-30b7-4f4d-bc8d-cac4b109047b',
                    'xtype': 'container'
                }, {
                    'anchor': '100%',
                    'dockedItems': [],
                    'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-cf3c2d82-b612-4fe2-89c5-327b247c92a2',
                    'items': [{
                        'defaults': {
                            'margin': '5 5 5 5'
                        },
                        'dockedItems': [],
                        'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-bb38df8d-856a-40f6-a730-6019a8ea0e44',
                        'flex': 1,
                        'items': [{
                            'anchor': '100%',
                            'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$8abbde9d-6cd1-4f40-84e7-9d387c970f1b',
                            'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-150c18a2-54b7-4d5b-b5fb-b2d3ae7ab13c',
                            'fieldLabel': 'Наименование',
                            'labelAlign': 'top',
                            'modelProperty': 'OrdersObjects_Name',
                            'name': 'Name',
                            'rmsUid': '150c18a2-54b7-4d5b-b5fb-b2d3ae7ab13c',
                            'xtype': 'textfield'
                        }],
                        'layout': 'anchor',
                        'rmsUid': 'bb38df8d-856a-40f6-a730-6019a8ea0e44',
                        'xtype': 'container'
                    }],
                    'layout': 'hbox',
                    'rmsUid': 'cf3c2d82-b612-4fe2-89c5-327b247c92a2',
                    'xtype': 'container'
                }, {
                    'anchor': '100%',
                    'dockedItems': [],
                    'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-c2031991-7fc0-4f2f-b3af-f36df3b65731',
                    'items': [{
                        'defaults': {
                            'margin': '5 5 5 5'
                        },
                        'dockedItems': [],
                        'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-c3216fb5-8b12-4f7c-9337-58c195b009ca',
                        'flex': 1,
                        'items': [{
                            'anchor': '100%',
                            'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$00da65d1-e495-4651-acbe-a299e13fef87',
                            'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-c2f57d34-eddd-48ee-b6f6-208376814756',
                            'fieldLabel': 'Описание',
                            'labelAlign': 'top',
                            'modelProperty': 'OrdersObjects_Comment',
                            'name': 'Comment',
                            'rmsUid': 'c2f57d34-eddd-48ee-b6f6-208376814756',
                            'xtype': 'textarea'
                        }],
                        'layout': 'anchor',
                        'rmsUid': 'c3216fb5-8b12-4f7c-9337-58c195b009ca',
                        'xtype': 'container'
                    }],
                    'layout': 'hbox',
                    'rmsUid': 'c2031991-7fc0-4f2f-b3af-f36df3b65731',
                    'xtype': 'container'
                }],
                'layout': 'anchor',
                'rmsUid': '43c8a2f4-122d-4b50-a649-2b1a42684630',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-41894cea-a523-44d3-bc08-7a0f6de9e21e',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dockedItems': [],
                    'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-1bbced63-0486-4b82-836b-7892e393b6d2',
                    'fieldLabel': 'Карта',
                    'height': 400,
                    'items': [{
                        'anchor': '100%',
                        'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$56d3d3eb-5e2b-4b4e-aab3-b82e2d50bb04',
                        'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-8bb2e4f1-bf2d-4361-9606-af21cceb166a',
                        'labelAlign': 'top',
                        'modelProperty': 'OrdersObjects_Lon',
                        'name': 'Lon',
                        'rmsUid': '8bb2e4f1-bf2d-4361-9606-af21cceb166a',
                        'xtype': 'hiddenfield'
                    }, {
                        'anchor': '100%',
                        'dataIndexAbsoluteUid': 'FieldPath://aa6ab35e-8dca-491d-8261-0bf3c834ab3b$b090549f-a003-44b9-95c3-f1f9021c9717',
                        'extraCls': 'cmp-style-395dbab2-e4ab-4846-b876-dbf8b577d6d9-62f42c68-2733-4d24-b244-269f4f5d73be',
                        'labelAlign': 'top',
                        'modelProperty': 'OrdersObjects_Lat',
                        'name': 'Lat',
                        'rmsUid': '62f42c68-2733-4d24-b244-269f4f5d73be',
                        'xtype': 'hiddenfield'
                    }],
                    'layout': {
                        'align': 'stretchmax',
                        'type': null
                    },
                    'minHeight': 200,
                    'region': 'Center',
                    'rmsUid': '1bbced63-0486-4b82-836b-7892e393b6d2',
                    'title': 'Карта',
                    'xtype': 'container'
                }],
                'layout': 'anchor',
                'rmsUid': '41894cea-a523-44d3-bc08-7a0f6de9e21e',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '8e595a72-3f05-4b1e-aeaf-2781678806d4',
            'xtype': 'container'
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
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Добавление объекта');
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