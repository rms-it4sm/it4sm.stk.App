Ext.define('B4.view.FundingProgramsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-fundingprogramseditor',
    title: 'Программа финансирования',
    rmsUid: 'b26c9636-0eb1-412a-be11-c01993a415e2',
    rmsElementUid: 'b26c9636-0eb1-412a-be11-c01993a415e2',
    dataSourceUid: '60a5fdca-979f-4332-9a9e-9a1fbd66665a',
    requires: [
        'B4.view.OrganizationFundingProgramsList2'],
    statics: {
        windowSize: {
            height: 500,
            width: 600
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'FundingPrograms_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Name',
        'modelProperty': 'FundingPrograms_Name',
        'type': 'TextField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'FundingPrograms_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': 'b26c9636-0eb1-412a-be11-c01993a415e2-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'FundingProgramsEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-b26c9636-0eb1-412a-be11-c01993a415e2-6644a2de-2892-421f-854c-47c24423f876',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-b26c9636-0eb1-412a-be11-c01993a415e2-6357860f-654a-46b5-8969-719afc3fd7cf',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://60a5fdca-979f-4332-9a9e-9a1fbd66665a$5b06b53c-a325-441c-862c-df36a87d0ea8',
                    'extraCls': 'cmp-style-b26c9636-0eb1-412a-be11-c01993a415e2-a4fb2f2c-d3cc-4618-9927-7dfb3d2e130f',
                    'fieldLabel': 'Наименование',
                    'labelAlign': 'top',
                    'modelProperty': 'FundingPrograms_Name',
                    'name': 'Name',
                    'rmsUid': 'a4fb2f2c-d3cc-4618-9927-7dfb3d2e130f',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': '6357860f-654a-46b5-8969-719afc3fd7cf',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '6644a2de-2892-421f-854c-47c24423f876',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-b26c9636-0eb1-412a-be11-c01993a415e2-882fd1cf-d2d0-437c-8a6e-b3c2b3d2c981',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-b26c9636-0eb1-412a-be11-c01993a415e2-a051e1a3-6e7e-4497-8656-ae813d68c15b',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://60a5fdca-979f-4332-9a9e-9a1fbd66665a$362312bc-a43c-4cd7-8545-9e944431d1cb',
                    'extraCls': 'cmp-style-b26c9636-0eb1-412a-be11-c01993a415e2-16ca362f-e0ed-4abb-9ebc-68219710c8f3',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'FundingPrograms_Comment',
                    'name': 'Comment',
                    'rmsUid': '16ca362f-e0ed-4abb-9ebc-68219710c8f3',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': 'a051e1a3-6e7e-4497-8656-ae813d68c15b',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '882fd1cf-d2d0-437c-8a6e-b3c2b3d2c981',
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
                        "DataIndex": "FieldPath://0de41a18-2d17-4f59-b60b-e39e0559c240$f95a256b-5ae1-40f4-aa65-89e63c58f335$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                        "DataIndexType": null,
                        "Value": "@FundingPrograms_Id",
                        "Filters": null,
                        "IsEmpty": false
                    }],
                    "IsEmpty": false
                }
            },
            'closable': false,
            'extraCls': 'cmp-style-b26c9636-0eb1-412a-be11-c01993a415e2-c9c0bad9-cce1-48e5-a1ed-220dd4a9b952',
            'flex': 1,
            'inlineCascadeSave': false,
            'name': 'OrganizationFundingProgramsList2',
            'region': 'Center',
            'rmsUid': 'c9c0bad9-cce1-48e5-a1ed-220dd4a9b952',
            'title': 'Оганизации',
            'xtype': 'rms-organizationfundingprogramslist2'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'FundingPrograms_Id',
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
        me.grid_OrganizationFundingProgramsList2 = me.down('rms-organizationfundingprogramslist2[name=OrganizationFundingProgramsList2]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Добавление программы');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        if (Ext.isNumber(entityId) && entityId > 0) {
            var _titleValue = Ext.String.format('{0}', rec.get('Name'));
            me.setTitle(_titleValue);
        }
        return res;
    },
});