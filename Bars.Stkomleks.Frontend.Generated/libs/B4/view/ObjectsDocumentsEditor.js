Ext.define('B4.view.ObjectsDocumentsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-objectsdocumentseditor',
    title: 'Документ объекта',
    rmsUid: 'ebd25f86-9526-4b73-bb5b-329f5758440d',
    rmsElementUid: 'ebd25f86-9526-4b73-bb5b-329f5758440d',
    dataSourceUid: 'f83926a7-db81-4655-acb3-9a95778fe130',
    requires: [
        'B4.form.PickerField',
        'B4.model.FileInfo',
        'B4.model.OrdersObjectsListModel',
        'B4.view.OrdersObjectsList',
        'BarsUp.form.ImageField',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 235,
            width: 500
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'ObjectsDocuments_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'ObjectWork',
        'modelProperty': 'ObjectsDocuments_ObjectWork',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'File',
        'modelProperty': 'ObjectsDocuments_File',
        'type': 'ImageFileField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'ObjectsDocuments_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': 'ebd25f86-9526-4b73-bb5b-329f5758440d-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'ObjectsDocumentsEditor-container',
        'layout': {
            'type': 'anchor'
        },
        'region': 'Center',
        items: [{
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-ebd25f86-9526-4b73-bb5b-329f5758440d-df1bbc00-056b-4505-80e8-e64933f39671',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-ebd25f86-9526-4b73-bb5b-329f5758440d-c586083c-ec0a-489f-98dc-68464f7b389e',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://f83926a7-db81-4655-acb3-9a95778fe130$58f67435-6a62-4318-9ff7-af5953ffa9a6',
                    'editable': false,
                    'extraCls': 'cmp-style-ebd25f86-9526-4b73-bb5b-329f5758440d-bc491af1-a8fe-45bd-b9fb-b80dfe7fde76',
                    'fieldLabel': 'Объект',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrdersObjectsList',
                    'listViewCtl': 'B4.controller.OrdersObjectsList',
                    'maximizable': true,
                    'model': 'B4.model.OrdersObjectsListModel',
                    'modelProperty': 'ObjectsDocuments_ObjectWork',
                    'name': 'ObjectWork',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'bc491af1-a8fe-45bd-b9fb-b80dfe7fde76',
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
                'rmsUid': 'c586083c-ec0a-489f-98dc-68464f7b389e',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'df1bbc00-056b-4505-80e8-e64933f39671',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-ebd25f86-9526-4b73-bb5b-329f5758440d-3675d3ab-4544-4682-844f-21646b40f7a6',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-ebd25f86-9526-4b73-bb5b-329f5758440d-609c1325-2f40-41b0-906f-2a6152a7b3f5',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://f83926a7-db81-4655-acb3-9a95778fe130$76347bed-514a-4aef-861c-7cc3a41c8750',
                    'editable': false,
                    'extraCls': 'cmp-style-ebd25f86-9526-4b73-bb5b-329f5758440d-3c636c63-b29e-457a-a6f9-7805410c7efd',
                    'fieldLabel': 'Файл',
                    'labelAlign': 'top',
                    'modelProperty': 'ObjectsDocuments_File',
                    'name': 'File',
                    'previewConfig': {
                        'height': 200,
                        'hideFileInput': false,
                        'width': null
                    },
                    'rmsUid': '3c636c63-b29e-457a-a6f9-7805410c7efd',
                    'typeAhead': false,
                    'xtype': 'barsup.imagefield'
                }],
                'layout': 'anchor',
                'rmsUid': '609c1325-2f40-41b0-906f-2a6152a7b3f5',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '3675d3ab-4544-4682-844f-21646b40f7a6',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-ebd25f86-9526-4b73-bb5b-329f5758440d-476dbd2e-4f33-4763-baf7-13e5b480e70f',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-ebd25f86-9526-4b73-bb5b-329f5758440d-362c4ad2-4428-4e0c-bb55-2a3c83b6814a',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://f83926a7-db81-4655-acb3-9a95778fe130$21f62c7f-c180-4905-be66-eecf1438515e',
                    'extraCls': 'cmp-style-ebd25f86-9526-4b73-bb5b-329f5758440d-702cdb2a-2f51-4656-aa02-c13fc875c177',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'ObjectsDocuments_Comment',
                    'name': 'Comment',
                    'rmsUid': '702cdb2a-2f51-4656-aa02-c13fc875c177',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': '362c4ad2-4428-4e0c-bb55-2a3c83b6814a',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '476dbd2e-4f33-4763-baf7-13e5b480e70f',
            'xtype': 'container'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'ObjectsDocuments_Id',
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
            me.setTitle('Добавление документа');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        if (Ext.isNumber(entityId) && entityId > 0) {
            me.setTitle(rec.get('File_Name'));
        }
        return res;
    },
});