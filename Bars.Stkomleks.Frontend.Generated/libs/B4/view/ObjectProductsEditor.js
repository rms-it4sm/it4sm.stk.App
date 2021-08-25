Ext.define('B4.view.ObjectProductsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-objectproductseditor',
    title: 'Элемент объекта',
    rmsUid: '59e2e72a-5563-4787-bd22-7bdb89882368',
    rmsElementUid: '59e2e72a-5563-4787-bd22-7bdb89882368',
    dataSourceUid: 'c4895819-2171-42e1-bde2-d4fa83104bbd',
    requires: [
        'B4.form.PickerField',
        'B4.model.OrdersObjectsListModel',
        'B4.model.ProductsTypesListModel',
        'B4.model.UnitMeasureListModel',
        'B4.view.OrdersObjectsList',
        'B4.view.ProductsList',
        'B4.view.ProductsTypesList',
        'B4.view.UnitMeasureList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 600,
            width: 800
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'ObjectProducts_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'ObjectOrder',
        'modelProperty': 'ObjectProducts_ObjectOrder',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Code',
        'modelProperty': 'ObjectProducts_Code',
        'type': 'TextField'
    }, {
        'dataIndex': 'TypeElement',
        'modelProperty': 'ObjectProducts_TypeElement',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Quantity',
        'modelProperty': 'ObjectProducts_Quantity',
        'type': 'NumberField'
    }, {
        'dataIndex': 'UnitMeasure',
        'modelProperty': 'ObjectProducts_UnitMeasure',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'ObjectProducts_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '59e2e72a-5563-4787-bd22-7bdb89882368-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'ObjectProductsEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-fe59a202-e238-44f5-a2b8-1afa43b2d1b2',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-9fcaae74-97db-4005-8910-4d4b9636687b',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$834b602a-f4f4-4943-be32-d82c58e50ce7',
                    'editable': false,
                    'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-3cf94cb1-42e9-4254-afca-c28c08e691ec',
                    'fieldLabel': 'Объект',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrdersObjectsList',
                    'listViewCtl': 'B4.controller.OrdersObjectsList',
                    'maximizable': true,
                    'model': 'B4.model.OrdersObjectsListModel',
                    'modelProperty': 'ObjectProducts_ObjectOrder',
                    'name': 'ObjectOrder',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '3cf94cb1-42e9-4254-afca-c28c08e691ec',
                    'textProperty': 'Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Объект',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '9fcaae74-97db-4005-8910-4d4b9636687b',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'fe59a202-e238-44f5-a2b8-1afa43b2d1b2',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-3148e128-8795-495c-9c6e-df86668ea8d8',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-eef2836f-2c5b-4320-9f04-2839dbe6972e',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$3b80eac1-dd79-421e-a6ea-301b5a8fa395',
                    'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-cbc724ed-f3cb-4bdf-a0c4-ae359b86385d',
                    'fieldLabel': 'Код',
                    'labelAlign': 'top',
                    'modelProperty': 'ObjectProducts_Code',
                    'name': 'Code',
                    'rmsUid': 'cbc724ed-f3cb-4bdf-a0c4-ae359b86385d',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'eef2836f-2c5b-4320-9f04-2839dbe6972e',
                'width': 150,
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-58cb3547-d79b-41d9-a76a-d47cdff122f2',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$6937d6ae-a06f-4475-a391-7b5aced09f7f',
                    'editable': false,
                    'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-43f0269e-c14c-4220-acbd-88f6319e957d',
                    'fieldLabel': 'Тип элемента',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.ProductsTypesList',
                    'listViewCtl': 'B4.controller.ProductsTypesList',
                    'maximizable': true,
                    'model': 'B4.model.ProductsTypesListModel',
                    'modelProperty': 'ObjectProducts_TypeElement',
                    'name': 'TypeElement',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '43f0269e-c14c-4220-acbd-88f6319e957d',
                    'textProperty': 'Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Тип элемента',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '58cb3547-d79b-41d9-a76a-d47cdff122f2',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '3148e128-8795-495c-9c6e-df86668ea8d8',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-1287c225-64f2-492b-9115-55bdd281b76f',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-c7b19e70-d2c7-455d-b10a-3f135f7563e4',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$ba306dc3-b0fd-4722-b546-acec6b81d4bf',
                    'decimalPrecision': 2,
                    'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-dbd3ce47-2b79-4a9b-834c-4201d5ad71a1',
                    'fieldLabel': 'Количество',
                    'labelAlign': 'top',
                    'modelProperty': 'ObjectProducts_Quantity',
                    'name': 'Quantity',
                    'rmsUid': 'dbd3ce47-2b79-4a9b-834c-4201d5ad71a1',
                    'step': 1,
                    'xtype': 'numberfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'c7b19e70-d2c7-455d-b10a-3f135f7563e4',
                'width': 150,
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-dd85e401-17d0-4e5a-812e-facb3de2485a',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$6f5c0ee8-5e92-42ad-8883-eba7cf11b2ab',
                    'editable': false,
                    'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-ae31252f-4c9d-47e3-a3b3-ea28b0c91aa4',
                    'fieldLabel': 'Ед. изм.',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.UnitMeasureList',
                    'listViewCtl': 'B4.controller.UnitMeasureList',
                    'maximizable': true,
                    'model': 'B4.model.UnitMeasureListModel',
                    'modelProperty': 'ObjectProducts_UnitMeasure',
                    'name': 'UnitMeasure',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'ae31252f-4c9d-47e3-a3b3-ea28b0c91aa4',
                    'textProperty': 'CutName',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Ед. изм.',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'dd85e401-17d0-4e5a-812e-facb3de2485a',
                'width': 150,
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '1287c225-64f2-492b-9115-55bdd281b76f',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-9e8db3e0-b30d-4e49-bd2f-945038ff0eee',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-cc48d15c-a798-4196-80f5-a449266caa34',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$593432ba-2fc0-4d71-9ed9-d67fd0a9970f',
                    'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-10141fa8-9345-49e2-9689-d39c659d81a4',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'ObjectProducts_Comment',
                    'name': 'Comment',
                    'rmsUid': '10141fa8-9345-49e2-9689-d39c659d81a4',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': 'cc48d15c-a798-4196-80f5-a449266caa34',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '9e8db3e0-b30d-4e49-bd2f-945038ff0eee',
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
                        "DataIndex": "FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$3dcb8175-9311-4543-9aed-da77478ece62$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                        "DataIndexType": null,
                        "Value": "@ObjectProducts_Id",
                        "Filters": null,
                        "IsEmpty": false
                    }],
                    "IsEmpty": false
                }
            },
            'closable': false,
            'extraCls': 'cmp-style-59e2e72a-5563-4787-bd22-7bdb89882368-f45b14ca-05ee-4b0a-9f79-58bd22eadf0f',
            'flex': 1,
            'inlineCascadeSave': false,
            'name': 'ProductsList',
            'region': 'Center',
            'rmsUid': 'f45b14ca-05ee-4b0a-9f79-58bd22eadf0f',
            'title': 'Товары',
            'xtype': 'rms-productslist'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'ObjectProducts_Id',
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
        me.grid_ProductsList = me.down('rms-productslist[name=ProductsList]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Добавить элемент');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        if (Ext.isNumber(entityId) && entityId > 0) {
            var _titleValue = Ext.String.format('{0}', rec.get('TypeElement_Name'));
            me.setTitle(_titleValue);
        }
        return res;
    },
});