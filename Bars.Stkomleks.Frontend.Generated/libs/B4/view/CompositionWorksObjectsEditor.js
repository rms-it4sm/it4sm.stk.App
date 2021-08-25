Ext.define('B4.view.CompositionWorksObjectsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-compositionworksobjectseditor',
    title: 'Работа объекта',
    rmsUid: '4e04503b-095f-40ac-a590-d3b44110768f',
    rmsElementUid: '4e04503b-095f-40ac-a590-d3b44110768f',
    dataSourceUid: 'cd655c91-5a8f-427c-ab3a-d4c44234cb06',
    requires: [
        'B4.enums.TypesWorkPerformers',
        'B4.form.EnumCombo',
        'B4.form.PickerField',
        'B4.model.DepartmentsListModel',
        'B4.model.ObjectProductsListModel',
        'B4.model.OrdersObjectsListModel',
        'B4.model.OrganizationProfilesList2Model',
        'B4.model.TypesWorkTypesObjectsListModel',
        'B4.view.DepartmentsList',
        'B4.view.ObjectProductsList',
        'B4.view.OrdersObjectsList',
        'B4.view.OrganizationProfilesList2',
        'B4.view.TypesWorkTypesObjectsList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 315,
            width: 800
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'CompositionWorksObjects_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'ObjectWork',
        'modelProperty': 'CompositionWorksObjects_ObjectWork',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'WorkType',
        'modelProperty': 'CompositionWorksObjects_WorkType',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'ObjectElement',
        'modelProperty': 'CompositionWorksObjects_ObjectElement',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'PlanStart',
        'modelProperty': 'CompositionWorksObjects_PlanStart',
        'type': 'DateField'
    }, {
        'dataIndex': 'PlanFinish',
        'modelProperty': 'CompositionWorksObjects_PlanFinish',
        'type': 'DateField'
    }, {
        'dataIndex': 'MethodWork',
        'modelProperty': 'CompositionWorksObjects_MethodWork',
        'type': 'DropdownField'
    }, {
        'dataIndex': 'ContractorWork',
        'modelProperty': 'CompositionWorksObjects_ContractorWork',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Brigade',
        'modelProperty': 'CompositionWorksObjects_Brigade',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'CompositionWorksObjects_Comment',
        'type': 'TextAreaField'
    }, {
        'dataIndex': 'Executor',
        'modelProperty': 'CompositionWorksObjects_Executor',
        'type': 'TextField'
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
        'rmsUid': '4e04503b-095f-40ac-a590-d3b44110768f-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'CompositionWorksObjectsEditor-container',
        'layout': {
            'type': 'anchor'
        },
        'region': 'Center',
        items: [{
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-f5250521-c4ba-4d91-8cb6-abec0f3a7b26',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-7fb6a39c-dce2-430d-94b7-1cc23b8d951f',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$e5e6c0c3-2740-40ee-9e6b-c98d69124498',
                    'editable': false,
                    'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-2b8b0c57-d464-4752-9361-5696f0af7042',
                    'fieldLabel': 'Объект',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrdersObjectsList',
                    'listViewCtl': 'B4.controller.OrdersObjectsList',
                    'maximizable': true,
                    'model': 'B4.model.OrdersObjectsListModel',
                    'modelProperty': 'CompositionWorksObjects_ObjectWork',
                    'name': 'ObjectWork',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '2b8b0c57-d464-4752-9361-5696f0af7042',
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
                'rmsUid': '7fb6a39c-dce2-430d-94b7-1cc23b8d951f',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'f5250521-c4ba-4d91-8cb6-abec0f3a7b26',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-51f7d009-fb2c-42d7-8e15-b4eb10d12a72',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-24be1626-47a7-4f57-8f4c-d1161d7e69b3',
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
                            "DataIndex": "FieldPath://ceb87fbf-759c-4e7f-bc92-3a605d913ad5$851be698-95e0-465e-b419-95da45ec8f8b$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                            "DataIndexType": null,
                            "Value": "@2b8b0c57-d464-4752-9361-5696f0af7042_Type_Id",
                            "Filters": null,
                            "IsEmpty": false
                        }],
                        "IsEmpty": false
                    },
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$57b675f7-b7f9-4d88-b390-9185e48c5d6a',
                    'editable': false,
                    'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-a762a472-885d-4ce8-8109-14fb441047cb',
                    'fieldLabel': 'Вид работы',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.TypesWorkTypesObjectsList',
                    'listViewCtl': 'B4.controller.TypesWorkTypesObjectsList',
                    'maximizable': true,
                    'model': 'B4.model.TypesWorkTypesObjectsListModel',
                    'modelProperty': 'CompositionWorksObjects_WorkType',
                    'name': 'WorkType',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'a762a472-885d-4ce8-8109-14fb441047cb',
                    'textProperty': 'WorkType_Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 600,
                        'maximizable': true,
                        'title': 'Вид работы',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '24be1626-47a7-4f57-8f4c-d1161d7e69b3',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-b350bb16-d7dc-40bf-9a50-05c4b746c762',
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
                            "DataIndex": "FieldPath://c4895819-2171-42e1-bde2-d4fa83104bbd$834b602a-f4f4-4943-be32-d82c58e50ce7$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                            "DataIndexType": null,
                            "Value": "@2b8b0c57-d464-4752-9361-5696f0af7042_Id",
                            "Filters": null,
                            "IsEmpty": false
                        }],
                        "IsEmpty": false
                    },
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$f6e6872c-d834-499f-b973-c3085925579a',
                    'editable': false,
                    'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-f45a5a1f-42d8-4cb7-b20c-7c4d1aab7c29',
                    'fieldLabel': 'Элемент объекта',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.ObjectProductsList',
                    'listViewCtl': 'B4.controller.ObjectProductsList',
                    'maximizable': true,
                    'model': 'B4.model.ObjectProductsListModel',
                    'modelProperty': 'CompositionWorksObjects_ObjectElement',
                    'name': 'ObjectElement',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'f45a5a1f-42d8-4cb7-b20c-7c4d1aab7c29',
                    'textProperty': 'TypeElement_Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Элемент объекта',
                        'width': 700
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'b350bb16-d7dc-40bf-9a50-05c4b746c762',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '51f7d009-fb2c-42d7-8e15-b4eb10d12a72',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-b91223a4-96c2-471f-b866-68e52f36869a',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-947b990d-258e-4682-8169-39acd8d0d015',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$d5cc7e14-1d82-4846-b79a-a4c19a61a2f5',
                    'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-6b7a114e-df05-4f5a-a3dd-b2070e1ba00c',
                    'fieldLabel': 'Начало (план)',
                    'format': 'd.m.Y',
                    'labelAlign': 'top',
                    'modelProperty': 'CompositionWorksObjects_PlanStart',
                    'name': 'PlanStart',
                    'rmsUid': '6b7a114e-df05-4f5a-a3dd-b2070e1ba00c',
                    'xtype': 'datefield'
                }],
                'layout': 'anchor',
                'rmsUid': '947b990d-258e-4682-8169-39acd8d0d015',
                'width': 150,
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-0816a833-2e20-4079-88cd-2b18854753e2',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$3f80730d-eb09-48e7-a2cc-62cbc1533c16',
                    'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-fa84fbec-e92b-4435-adeb-6d1d185cdc63',
                    'fieldLabel': 'Завершение (план)',
                    'format': 'd.m.Y',
                    'labelAlign': 'top',
                    'modelProperty': 'CompositionWorksObjects_PlanFinish',
                    'name': 'PlanFinish',
                    'rmsUid': 'fa84fbec-e92b-4435-adeb-6d1d185cdc63',
                    'xtype': 'datefield'
                }],
                'layout': 'anchor',
                'rmsUid': '0816a833-2e20-4079-88cd-2b18854753e2',
                'width': 150,
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-9fc692ac-2adb-4fa2-aaa3-755a571b5912',
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$96ec58e2-95d0-45d4-a271-875601604621',
                    'enumName': 'B4.enums.TypesWorkPerformers',
                    'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-e1d5e4c4-3020-4ea2-84c7-17d4e228ade9',
                    'fieldLabel': 'Способ выполнения',
                    'labelAlign': 'top',
                    'modelProperty': 'CompositionWorksObjects_MethodWork',
                    'name': 'MethodWork',
                    'queryMode': 'local',
                    'rmsUid': 'e1d5e4c4-3020-4ea2-84c7-17d4e228ade9',
                    'xtype': 'b4enumcombo'
                }],
                'layout': 'anchor',
                'rmsUid': '9fc692ac-2adb-4fa2-aaa3-755a571b5912',
                'width': 200,
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-81e27f38-258d-4516-be9f-707b21ced0cf',
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
                            "Value": "Подрядчик",
                            "Filters": null,
                            "IsEmpty": false
                        }],
                        "IsEmpty": false
                    },
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$099d9765-3b40-4a3a-a495-856053b6a5b6',
                    'editable': false,
                    'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-b6a092b6-cd49-4b7b-b0d1-0c0c9b25b988',
                    'fieldLabel': 'Подрядчик',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrganizationProfilesList2',
                    'listViewCtl': 'B4.controller.OrganizationProfilesList2',
                    'maximizable': true,
                    'model': 'B4.model.OrganizationProfilesList2Model',
                    'modelProperty': 'CompositionWorksObjects_ContractorWork',
                    'name': 'ContractorWork',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'b6a092b6-cd49-4b7b-b0d1-0c0c9b25b988',
                    'textProperty': 'Organization_Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Подрядчик',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }, {
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$fba91bbb-26f1-4766-9e96-88d0969c671e',
                    'editable': false,
                    'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-d7aa4ba2-32fc-4a4f-9a3a-32c7519cc054',
                    'fieldLabel': 'Бригада',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.DepartmentsList',
                    'listViewCtl': 'B4.controller.DepartmentsList',
                    'maximizable': true,
                    'model': 'B4.model.DepartmentsListModel',
                    'modelProperty': 'CompositionWorksObjects_Brigade',
                    'name': 'Brigade',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'd7aa4ba2-32fc-4a4f-9a3a-32c7519cc054',
                    'textProperty': 'Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Бригада',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '81e27f38-258d-4516-be9f-707b21ced0cf',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'b91223a4-96c2-471f-b866-68e52f36869a',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-af4dbeb7-5467-4e91-97bb-dea9e78f2c57',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-7ca95d8f-dddc-4245-971d-2964ad1cc2cd',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$10f45f46-c87b-4130-a5db-673007a24530',
                    'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-c0d4d8ce-0805-435a-bb42-f91a379fce3e',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'CompositionWorksObjects_Comment',
                    'name': 'Comment',
                    'rmsUid': 'c0d4d8ce-0805-435a-bb42-f91a379fce3e',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': '7ca95d8f-dddc-4245-971d-2964ad1cc2cd',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'af4dbeb7-5467-4e91-97bb-dea9e78f2c57',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dataIndexAbsoluteUid': 'FieldPath://cd655c91-5a8f-427c-ab3a-d4c44234cb06$87250b9a-b480-488b-9aa3-eba693e483af',
            'extraCls': 'cmp-style-4e04503b-095f-40ac-a590-d3b44110768f-186250b8-243c-46dd-8485-aecd9df9c34d',
            'fieldLabel': 'Исполнитель',
            'hidden': true,
            'labelAlign': 'top',
            'modelProperty': 'CompositionWorksObjects_Executor',
            'name': 'Executor',
            'rmsUid': '186250b8-243c-46dd-8485-aecd9df9c34d',
            'xtype': 'textfield'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'CompositionWorksObjects_Id',
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
            me.setTitle('Добавление работы');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
});