Ext.define('B4.view.TypesWorkTypesObjectsListMultiAddByObjectTypeEditor', {
    extend: 'B4.base.form.MultiAddView',
    alias: 'widget.rms-typesworktypesobjectslistmultiaddbyobjecttypeeditor',
    title: '',
    rmsUid: '29f93965-1a12-ded8-53ec-b1b5d225fe54',
    rmsElementUid: '29f93965-1a12-ded8-53ec-b1b5d225fe54',
    dataSourceUid: 'ceb87fbf-759c-4e7f-bc92-3a605d913ad5',
    requires: [
        'B4.form.PickerField',
        'B4.model.ObjectsTypesListModel',
        'B4.model.WorksTypesListModel',
        'B4.view.ObjectsTypesList',
        'B4.view.WorksTypesList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {},
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'TypesWorkTypesObjects_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'ObjectType',
        'modelProperty': 'TypesWorkTypesObjects_ObjectType',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'WorkType',
        'modelProperty': 'TypesWorkTypesObjects_WorkType',
        'type': 'SelectorField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Выбрать'
        }],
        'rmsUid': '29f93965-1a12-ded8-53ec-b1b5d225fe54-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'TypesWorkTypesObjectsListMultiAddByObjectTypeEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'maximizable': true,
        items: [{
            'dataIndexAbsoluteUid': 'FieldPath://ceb87fbf-759c-4e7f-bc92-3a605d913ad5$851be698-95e0-465e-b419-95da45ec8f8b',
            'editable': false,
            'extraCls': 'cmp-style-29f93965-1a12-ded8-53ec-b1b5d225fe54-ebdd5fe9-9210-f16b-7757-e1f143f913ff',
            'fieldLabel': 'Тип объекта',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.ObjectsTypesList',
            'listViewCtl': 'B4.controller.ObjectsTypesList',
            'model': 'B4.model.ObjectsTypesListModel',
            'modelProperty': 'TypesWorkTypesObjects_ObjectType',
            'name': 'ObjectType',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': 'ebdd5fe9-9210-f16b-7757-e1f143f913ff',
            'textProperty': 'Name',
            'typeAhead': false,
            'windowCfg': {
                'border': false,
                'height': 550,
                'maximizable': true,
                'title': 'Тип объекта',
                'width': 600
            },
            'xtype': 'b4pickerfield'
        }, {
            'closable': false,
            'dockedItems': null,
            'extraCls': 'cmp-style-29f93965-1a12-ded8-53ec-b1b5d225fe54-911df279-1631-50bf-34e8-29f9e4fd4972',
            'flex': 1,
            'getSelected': function() {
                var selModel = this.getSelectionModel(),
                    selected = selModel && selModel.getSelection && selModel.getSelection(),
                    view = this.getView(),
                    checked = view && view.getChecked && view.getChecked();
                return checked || selected;
            },
            'header': false,
            'modelProperty': 'TypesWorkTypesObjects_WorkType_Registry',
            'name': 'WorksTypesList',
            'rmsUid': '911df279-1631-50bf-34e8-29f9e4fd4972',
            'rootVisible': false,
            'stateful': false,
            'tbar': null,
            'title': null,
            'xtype': 'rms-workstypeslist'
        }, {
            'dataIndexAbsoluteUid': 'FieldPath://ceb87fbf-759c-4e7f-bc92-3a605d913ad5$a027f406-10c4-4310-9fc3-d6f6fe0739de',
            'editable': false,
            'extraCls': 'cmp-style-29f93965-1a12-ded8-53ec-b1b5d225fe54-1399e726-b041-b66e-68e9-9f46ac1eeba5',
            'fieldLabel': 'Вид работы',
            'hidden': true,
            'idProperty': 'Id',
            'isContextAware': true,
            'labelAlign': 'top',
            'listView': 'B4.view.WorksTypesList',
            'listViewCtl': 'B4.controller.WorksTypesList',
            'model': 'B4.model.WorksTypesListModel',
            'modelProperty': 'TypesWorkTypesObjects_WorkType',
            'name': 'WorkType',
            'plugins': [{
                'ptype': 'versioningpickerfieldplugin'
            }],
            'rmsUid': '1399e726-b041-b66e-68e9-9f46ac1eeba5',
            'textProperty': 'Name',
            'typeAhead': false,
            'windowCfg': {
                'border': false,
                'height': 550,
                'maximizable': true,
                'title': 'Вид работы',
                'width': 600
            },
            'xtype': 'b4pickerfield'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'TypesWorkTypesObjects_Id',
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
            if (item['modelProperty'] == 'TypesWorkTypesObjects_WorkType_Registry') {
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
        var registry = me.down('[modelProperty=TypesWorkTypesObjects_WorkType_Registry]');
        registry.getStore().on({
            'beforeload': function(curStore, operation) {
                const params = operation.getParams() || {};
                params.multiAddUid = '9ec9a8b2-fbc7-42e1-9afa-fc49346bd080';
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
        me.grid_WorksTypesList = me.down('rms-workstypeslist[name=WorksTypesList]');
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
        var editor = me.down('[modelProperty=TypesWorkTypesObjects_ObjectType]'),
            editorValue = editor.value || null,
            registry = me.down('[modelProperty=TypesWorkTypesObjects_WorkType_Registry]'),
            selected = registry.getSelected();
        values.records = [];
        if (Ext.isArray(selected)) {
            selected.forEach(function(item) {
                var model = {
                    ObjectType: {},
                    WorkType: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.ObjectType[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.ObjectType = null;
                }
                model.WorkType[editor.idProperty] = item.get(editor.idProperty);
                values.records.push(model);
            });
        } else if (Ext.isObject(selected)) {
            Ext.Object.each(selected, function(key, value, myself) {
                var model = {
                    ObjectType: {},
                    WorkType: {},
                };
                if (Ext.isObject(editorValue)) {
                    model.ObjectType[editor.idProperty] = editor.value[editor.idProperty];
                } else {
                    model.ObjectType = null;
                }
                model.WorkType[editor.idProperty] = value.get(editor.idProperty);
                values.records.push(model);
            });
        }
        return values;
    }
});