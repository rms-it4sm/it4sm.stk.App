Ext.define('B4.view.ObjectsOrdersListMultiAddByZakazEditor', {
    extend: 'B4.base.form.MultiAddView',
    alias: 'widget.rms-objectsorderslistmultiaddbyzakazeditor',
    title: '',
    rmsUid: '4be82f55-200d-54ab-7f7d-a49288cbd00e',
    rmsElementUid: '4be82f55-200d-54ab-7f7d-a49288cbd00e',
    dataSourceUid: '33d98787-d41a-4282-8f79-3b4f1046a7a1',
    requires: [
        'B4.form.PickerField',
        'B4.model.OrdersListModel',
        'B4.model.OrdersObjectsListModel',
        'B4.view.OrdersList',
        'B4.view.OrdersObjectsList',
        'B4.view.OrdersObjectsList2',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {},
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'ObjectsOrders_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Zakaz',
        'modelProperty': 'ObjectsOrders_Zakaz',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Object',
        'modelProperty': 'ObjectsOrders_Object',
        'type': 'SelectorField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Выбрать'
        }],
        'rmsUid': '4be82f55-200d-54ab-7f7d-a49288cbd00e-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'ObjectsOrdersListMultiAddByZakazEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'maximizable': true,
        items: [{
            'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$30ef3bf7-35e0-4a5c-9945-9fa7db560dc7',
            'editable': false,
            'extraCls': 'cmp-style-4be82f55-200d-54ab-7f7d-a49288cbd00e-d1f930be-a7aa-6faa-bc4f-1ee7902ff55e',
            'fieldLabel': 'Заказ',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.OrdersList',
            'listViewCtl': 'B4.controller.OrdersList',
            'model': 'B4.model.OrdersListModel',
            'modelProperty': 'ObjectsOrders_Zakaz',
            'name': 'Zakaz',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': 'd1f930be-a7aa-6faa-bc4f-1ee7902ff55e',
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
        }, {
            'closable': false,
            'dockedItems': null,
            'extraCls': 'cmp-style-4be82f55-200d-54ab-7f7d-a49288cbd00e-03d0bd85-eabf-8530-3dcd-c4ae446780dc',
            'flex': 1,
            'getSelected': function() {
                var selModel = this.getSelectionModel(),
                    selected = selModel && selModel.getSelection && selModel.getSelection(),
                    view = this.getView(),
                    checked = view && view.getChecked && view.getChecked();
                return checked || selected;
            },
            'header': false,
            'modelProperty': 'ObjectsOrders_Object_Registry',
            'name': 'OrdersObjectsList2',
            'rmsUid': '03d0bd85-eabf-8530-3dcd-c4ae446780dc',
            'rootVisible': false,
            'stateful': false,
            'tbar': null,
            'title': null,
            'xtype': 'rms-ordersobjectslist2'
        }, {
            'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$f9b75007-4df7-4f66-8407-9646b73f634d',
            'editable': false,
            'extraCls': 'cmp-style-4be82f55-200d-54ab-7f7d-a49288cbd00e-896813d8-7b87-e74b-2185-d568ade68d51',
            'fieldLabel': 'Объект',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.OrdersObjectsList',
            'listViewCtl': 'B4.controller.OrdersObjectsList',
            'model': 'B4.model.OrdersObjectsListModel',
            'modelProperty': 'ObjectsOrders_Object',
            'name': 'Object',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': '896813d8-7b87-e74b-2185-d568ade68d51',
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
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'ObjectsOrders_Id',
                'name': 'Id',
                'xtype': 'hidden'
            }],
            'xtype': 'panel'
        }]
    }],
    plugins: [],
    initComponent: function() {
        var me = this;
        var tempXtypeName = null;
        Ext.each(this.items[0].items, function(item, index) {
            if (item['modelProperty'] == 'ObjectsOrders_Object_Registry') {
                tempXtypeName = item['xtype'];
            }
        });
        var templist = Ext.create('widget.' + tempXtypeName);
        if (templist && !templist.is('treepanel')) {
            var selModel = Ext.create('Ext.selection.CheckboxModel', {
                mode: 'MULTI',
                checkOnly: true,
                pruneRemoved: false
            });
            Ext.each(this.items[0].items, function(item, index) {
                if (item['xtype'] == tempXtypeName) {
                    item['selModel'] = selModel;
                }
            });
        }
        templist.destroy();
        templist = null;
        me.callParent(arguments);
        me.submitTimeout = 120;
        var registry = me.down('[modelProperty=ObjectsOrders_Object_Registry]');
        registry.getStore().on({
            'beforeload': function(curStore, operation) {
                const params = operation.getParams() || {};
                params.multiAddUid = '36888e22-6eb1-466a-956c-78abc60d0544';
                operation.setParams(params);
            }
        });
        if (registry.is('treepanel')) {
            registry.on('load', function(sender, store, records, successful, eOpts) {
                registry.store.getRootNode().cascadeBy(function(node) {
                    node.set({
                        checked: false
                    });
                });
            });
            registry.loadData(true);
        }
        me.grid_OrdersObjectsList2 = me.down('rms-ordersobjectslist2[name=OrdersObjectsList2]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
    'getEditorValues': function() {
        var me = this;
        var record = me.getRecord();
        var values = {};
        var editor = me.down('[modelProperty=ObjectsOrders_Zakaz]'),
            editorValue = editor.value || null,
            registry = me.down('[modelProperty=ObjectsOrders_Object_Registry]'),
            selected = registry.getSelected();
        values.records = [];
        if (Ext.isArray(selected)) {
            selected.forEach(function(item) {
                var model = {
                    Zakaz: {},
                    Object: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.Zakaz[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.Zakaz = null;
                }
                model.Object[editor.idProperty] = item.get(editor.idProperty);
                values.records.push(model);
            });
        } else if (Ext.isObject(selected)) {
            Ext.Object.each(selected, function(key, value, myself) {
                var model = {
                    Zakaz: {},
                    Object: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.Zakaz[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.Zakaz = null;
                }
                model.Object[editor.idProperty] = value.get(editor.idProperty);
                values.records.push(model);
            });
        }
        return values;
    }
});