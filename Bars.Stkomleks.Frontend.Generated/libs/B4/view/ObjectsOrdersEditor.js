Ext.define('B4.view.ObjectsOrdersEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-objectsorderseditor',
    title: 'Объект заказа',
    rmsUid: '6185abdb-13fa-4e36-a62b-20d4a979c7ec',
    rmsElementUid: '6185abdb-13fa-4e36-a62b-20d4a979c7ec',
    dataSourceUid: '33d98787-d41a-4282-8f79-3b4f1046a7a1',
    requires: [
        'B4.form.PickerField',
        'B4.form.SelectField',
        'B4.model.OrdersListModel',
        'B4.view.OrdersList',
        'B4.view.OrdersObjectsEditor',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {}
    },
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
        'type': 'EditorField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '6185abdb-13fa-4e36-a62b-20d4a979c7ec-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'ObjectsOrdersEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-6185abdb-13fa-4e36-a62b-20d4a979c7ec-0f05df00-2bfc-4f01-b3e0-b17cdfa8e61d',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-6185abdb-13fa-4e36-a62b-20d4a979c7ec-ef088fea-61d5-4f5a-a8f9-10dac531a935',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$30ef3bf7-35e0-4a5c-9945-9fa7db560dc7',
                    'editable': false,
                    'extraCls': 'cmp-style-6185abdb-13fa-4e36-a62b-20d4a979c7ec-f974f997-c8e5-4942-82dd-c6ce4a07669e',
                    'fieldLabel': 'Заказ',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrdersList',
                    'listViewCtl': 'B4.controller.OrdersList',
                    'maximizable': true,
                    'model': 'B4.model.OrdersListModel',
                    'modelProperty': 'ObjectsOrders_Zakaz',
                    'name': 'Zakaz',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'f974f997-c8e5-4942-82dd-c6ce4a07669e',
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
                'rmsUid': 'ef088fea-61d5-4f5a-a8f9-10dac531a935',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '0f05df00-2bfc-4f01-b3e0-b17cdfa8e61d',
            'xtype': 'container'
        }, {
            'dataIndexAbsoluteUid': 'FieldPath://33d98787-d41a-4282-8f79-3b4f1046a7a1$f9b75007-4df7-4f66-8407-9646b73f634d',
            'dockedItems': null,
            'extraCls': 'cmp-style-6185abdb-13fa-4e36-a62b-20d4a979c7ec-3d9f7801-7c6c-436e-a4b9-c1019a944061',
            'fieldLabel': 'Объект.Создание',
            'header': false,
            'idProperty': 'Id',
            'labelAlign': 'top',
            'modelProperty': 'ObjectsOrders_Object',
            'name': 'Object',
            'rmsUid': '3d9f7801-7c6c-436e-a4b9-c1019a944061',
            'tbar': null,
            'title': null,
            'xtype': 'rms-ordersobjectseditor'
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
        me.callParent(arguments);
        me.submitTimeout = 20;
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Создание объекта');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
});