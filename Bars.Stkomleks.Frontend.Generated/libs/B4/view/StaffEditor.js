Ext.define('B4.view.StaffEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-staffeditor',
    title: 'Сотрудник',
    rmsUid: '20f3ec7c-e4f4-41e3-b814-2d79b589ae80',
    rmsElementUid: '20f3ec7c-e4f4-41e3-b814-2d79b589ae80',
    dataSourceUid: '0b83a4c4-1b8b-49d6-b16b-dcb3a373a391',
    requires: [
        'B4.form.PickerField',
        'B4.model.IndividualsListModel',
        'B4.model.OrganizationListModel',
        'B4.view.IndividualsList',
        'B4.view.OrganizationList',
        'BarsUp.versioning.plugin.PickerField'],
    statics: {
        windowSize: {
            height: 235,
            width: 500
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'Staff_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Organization',
        'modelProperty': 'Staff_Organization',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Individual',
        'modelProperty': 'Staff_Individual',
        'type': 'SelectorField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'Staff_Comment',
        'type': 'TextAreaField'
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
        'rmsUid': '20f3ec7c-e4f4-41e3-b814-2d79b589ae80-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'StaffEditor-container',
        'layout': {
            'type': 'anchor'
        },
        'region': 'Center',
        items: [{
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-20f3ec7c-e4f4-41e3-b814-2d79b589ae80-b82d24b6-f5fa-4de5-8fc5-e172bfe2c0d8',
            'hidden': true,
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-20f3ec7c-e4f4-41e3-b814-2d79b589ae80-274a6d8c-78be-4579-b1f0-fa521abc61e0',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://0b83a4c4-1b8b-49d6-b16b-dcb3a373a391$877ada62-82d4-4fca-8574-61c4290187d5',
                    'editable': false,
                    'extraCls': 'cmp-style-20f3ec7c-e4f4-41e3-b814-2d79b589ae80-8ea33522-4469-417c-aa77-ea5f9b462805',
                    'fieldLabel': 'Организация',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.OrganizationList',
                    'listViewCtl': 'B4.controller.OrganizationList',
                    'maximizable': true,
                    'model': 'B4.model.OrganizationListModel',
                    'modelProperty': 'Staff_Organization',
                    'name': 'Organization',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': '8ea33522-4469-417c-aa77-ea5f9b462805',
                    'textProperty': 'Name',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Организация',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '274a6d8c-78be-4579-b1f0-fa521abc61e0',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'b82d24b6-f5fa-4de5-8fc5-e172bfe2c0d8',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-20f3ec7c-e4f4-41e3-b814-2d79b589ae80-fc44963c-afd6-46c0-befe-b8309fdc60ad',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-20f3ec7c-e4f4-41e3-b814-2d79b589ae80-48073c9a-6abe-484c-9488-4b13d6cedf60',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://0b83a4c4-1b8b-49d6-b16b-dcb3a373a391$2841e6bd-6760-4243-92b0-d26a48633898',
                    'editable': false,
                    'extraCls': 'cmp-style-20f3ec7c-e4f4-41e3-b814-2d79b589ae80-a4ebc6df-c58b-4297-8a7c-04610638ae05',
                    'fieldLabel': 'Физ лицо',
                    'idProperty': 'Id',
                    'isContextAware': true,
                    'isForChoiceOnly': true,
                    'labelAlign': 'top',
                    'listView': 'B4.view.IndividualsList',
                    'listViewCtl': 'B4.controller.IndividualsList',
                    'maximizable': true,
                    'model': 'B4.model.IndividualsListModel',
                    'modelProperty': 'Staff_Individual',
                    'name': 'Individual',
                    'plugins': [{
                        'ptype': 'versioningpickerfieldplugin'
                    }],
                    'rmsUid': 'a4ebc6df-c58b-4297-8a7c-04610638ae05',
                    'textProperty': 'FIO',
                    'typeAhead': false,
                    'windowCfg': {
                        'border': false,
                        'height': 550,
                        'maximizable': true,
                        'title': 'Физ лицо',
                        'width': 600
                    },
                    'xtype': 'b4pickerfield'
                }],
                'layout': 'anchor',
                'rmsUid': '48073c9a-6abe-484c-9488-4b13d6cedf60',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'fc44963c-afd6-46c0-befe-b8309fdc60ad',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-20f3ec7c-e4f4-41e3-b814-2d79b589ae80-f377a62c-b047-4e00-ba83-5d7a1b104cc2',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-20f3ec7c-e4f4-41e3-b814-2d79b589ae80-7ff52d33-6fd8-4dcb-9690-cd73bed5a58c',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://0b83a4c4-1b8b-49d6-b16b-dcb3a373a391$0fc2221c-b809-4739-a087-7a9acf5438c5',
                    'extraCls': 'cmp-style-20f3ec7c-e4f4-41e3-b814-2d79b589ae80-e3905ff8-9e8e-44e6-93fb-13dac3103cf5',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'Staff_Comment',
                    'name': 'Comment',
                    'rmsUid': 'e3905ff8-9e8e-44e6-93fb-13dac3103cf5',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': '7ff52d33-6fd8-4dcb-9690-cd73bed5a58c',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'f377a62c-b047-4e00-ba83-5d7a1b104cc2',
            'xtype': 'container'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'Staff_Id',
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
            me.setTitle('Добавление сотрудника');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
});