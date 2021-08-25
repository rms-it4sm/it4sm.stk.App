Ext.define('B4.view.ProductsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-productseditor',
    title: 'Комплектация',
    rmsUid: '153ded49-b5ae-4c43-bdb2-a835368c2cf2',
    rmsElementUid: '153ded49-b5ae-4c43-bdb2-a835368c2cf2',
    dataSourceUid: '59c0f660-c442-4e9a-8772-a97243000d48',
    requires: [
        'B4.form.PickerField',
        'B4.model.ObjectProductsListModel',
        'B4.model.OrganizationProfilesList2Model',
        'B4.view.ObjectProductsList',
        'B4.view.OrganizationProfilesList2',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 360,
            width: 500
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'Products_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'ObjectSpecification',
        'modelProperty': 'Products_ObjectSpecification',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Supplier',
        'modelProperty': 'Products_Supplier',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Product',
        'modelProperty': 'Products_Product',
        'type': 'TextField'
    }, {
        'dataIndex': 'Code',
        'modelProperty': 'Products_Code',
        'type': 'TextField'
    }, {
        'dataIndex': 'Quantity',
        'modelProperty': 'Products_Quantity',
        'type': 'NumberField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'Products_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '153ded49-b5ae-4c43-bdb2-a835368c2cf2-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'ProductsEditor-container',
        'layout': {
            'type': 'anchor'
        },
        'region': 'Center',
        items: [{
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-40b7d8b7-c16c-4b3e-b55b-6e563c962be0',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-40fb48cf-c828-4b7a-a066-4625e27642c0',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$3dcb8175-9311-4543-9aed-da77478ece62',
                    'editable': false,
                    'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-a4fcea41-0bd7-4e57-b40f-84be3a26bdd6',
                    'fieldLabel': 'Спецификация объекта',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.ObjectProductsList',
                    'listViewCtl': 'B4.controller.ObjectProductsList',
                    'maximizable': true,
                    'model': 'B4.model.ObjectProductsListModel',
                    'modelProperty': 'Products_ObjectSpecification',
                    'name': 'ObjectSpecification',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'a4fcea41-0bd7-4e57-b40f-84be3a26bdd6',
                    'textProperty': 'Code',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Спецификация объекта',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '40fb48cf-c828-4b7a-a066-4625e27642c0',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '40b7d8b7-c16c-4b3e-b55b-6e563c962be0',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-af5bb469-7e4e-4a5d-a670-bbfa8101c48d',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-5bdf2746-7bee-4347-a905-1135e860dd55',
                'flex': 1,
                'items': [{
                    '$SelectorFilter': {
                        "Group": 2,
                        "Operand": 0,
                        "DataIndex": null,
                        "DataIndexType": null,
                        "Value": null,
                        "Filters": [{
                            "Group": 0,
                            "Operand": 0,
                            "DataIndex": "FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$5258c478-6f02-425d-a14e-025882b1b6c0$f44c4209-af60-444a-a056-671a5255de8d",
                            "DataIndexType": null,
                            "Value": "Производитель",
                            "Filters": null,
                            "IsEmpty": false
                        }],
                        "IsEmpty": false
                    },
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$45a5ab39-ea3e-4bf8-bb76-4e063c9b11e4',
                    'editable': false,
                    'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-5c01b211-328b-4411-af83-92a396fb1415',
                    'fieldLabel': 'Поставщик',
                    'hiddenListFields': [
                        'Profile_Name'],
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrganizationProfilesList2',
                    'listViewCtl': 'B4.controller.OrganizationProfilesList2',
                    'maximizable': true,
                    'model': 'B4.model.OrganizationProfilesList2Model',
                    'modelProperty': 'Products_Supplier',
                    'name': 'Supplier',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '5c01b211-328b-4411-af83-92a396fb1415',
                    'textProperty': 'Organization_Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Поставщик',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '5bdf2746-7bee-4347-a905-1135e860dd55',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'af5bb469-7e4e-4a5d-a670-bbfa8101c48d',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-8929253e-0293-4a46-a9f2-9b2867183f44',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-50af92bd-eedb-4ada-ba8b-a1ec9323b829',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$73f245ed-c7e5-4328-a973-ba959aba22f9',
                    'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-698065ac-da84-461b-954d-e6bf595e4b6a',
                    'fieldLabel': 'Товар',
                    'labelAlign': 'top',
                    'modelProperty': 'Products_Product',
                    'name': 'Product',
                    'rmsUid': '698065ac-da84-461b-954d-e6bf595e4b6a',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': '50af92bd-eedb-4ada-ba8b-a1ec9323b829',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '8929253e-0293-4a46-a9f2-9b2867183f44',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-bb2715fc-286e-4f5a-b2f5-56fac75ea2c3',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-db019710-7ccf-4a4d-9205-44b9572c089d',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$456f9a5a-a1e3-4657-8c32-0998de5c8ef0',
                    'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-134ea4b8-c2e4-4074-ae90-7f31bb973ffe',
                    'fieldLabel': 'Артикул',
                    'labelAlign': 'top',
                    'modelProperty': 'Products_Code',
                    'name': 'Code',
                    'rmsUid': '134ea4b8-c2e4-4074-ae90-7f31bb973ffe',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'db019710-7ccf-4a4d-9205-44b9572c089d',
                'width': 150,
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-cb179ee0-e59d-41ee-b15a-9d3fbdeee197',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$fb54ae14-ffe8-4bda-9f02-635d225baa9a',
                    'decimalPrecision': 2,
                    'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-b4bf1062-5fcf-4b02-b950-931c203c39e1',
                    'fieldLabel': 'Количество',
                    'labelAlign': 'top',
                    'modelProperty': 'Products_Quantity',
                    'name': 'Quantity',
                    'rmsUid': 'b4bf1062-5fcf-4b02-b950-931c203c39e1',
                    'step': 1,
                    'xtype': 'numberfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'cb179ee0-e59d-41ee-b15a-9d3fbdeee197',
                'width': 150,
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'bb2715fc-286e-4f5a-b2f5-56fac75ea2c3',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-b5484cb6-dc5c-4611-afb1-be4c7401fe24',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-c02518d7-630e-4a11-8043-1d02aafeab99',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://59c0f660-c442-4e9a-8772-a97243000d48$c195a5ca-a120-48b0-b8e3-cb89ab12a514',
                    'extraCls': 'cmp-style-153ded49-b5ae-4c43-bdb2-a835368c2cf2-5513760a-45b7-40bf-a245-aab20206ea14',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'Products_Comment',
                    'name': 'Comment',
                    'rmsUid': '5513760a-45b7-40bf-a245-aab20206ea14',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': 'c02518d7-630e-4a11-8043-1d02aafeab99',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'b5484cb6-dc5c-4611-afb1-be4c7401fe24',
            'xtype': 'container'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'Products_Id',
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
            me.setTitle('Добавление товара');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        if (Ext.isNumber(entityId) && entityId > 0) {
            var _titleValue = Ext.String.format('{0}', rec.get('Product'));
            me.setTitle(_titleValue);
        }
        return res;
    },
});