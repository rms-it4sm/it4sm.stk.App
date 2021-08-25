Ext.define('B4.view.IndividualsEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-individualseditor',
    title: 'Физическое лицо',
    rmsUid: '2efed10a-d54e-46b9-ac19-6b9792c2fb9e',
    rmsElementUid: '2efed10a-d54e-46b9-ac19-6b9792c2fb9e',
    dataSourceUid: '49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d',
    requires: [],
    statics: {
        windowSize: {
            height: 295,
            width: 600
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'Individuals_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Surname',
        'modelProperty': 'Individuals_Surname',
        'type': 'TextField'
    }, {
        'dataIndex': 'Name',
        'modelProperty': 'Individuals_Name',
        'type': 'TextField'
    }, {
        'dataIndex': 'Patronymic',
        'modelProperty': 'Individuals_Patronymic',
        'type': 'TextField'
    }, {
        'dataIndex': 'FIO',
        'modelProperty': 'Individuals_FIO',
        'type': 'TextField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'Individuals_Comment',
        'type': 'TextAreaField'
    }],
    dockedItems: [{
        'dock': 'top',
        'items': [{
            'actionName': 'save',
            'iconCls': 'icon-disk',
            'text': 'Сохранить'
        }],
        'rmsUid': '2efed10a-d54e-46b9-ac19-6b9792c2fb9e-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'IndividualsEditor-container',
        'layout': {
            'type': 'anchor'
        },
        'region': 'Center',
        items: [{
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-dbf790f8-86f7-445b-b2ea-f11a2bd7a024',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-95ecf95e-d90c-43e4-8c4b-2ace53a99186',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d$21ecbd16-6ed6-4e4e-af46-8a3b392cff2c',
                    'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-ace72536-1b25-42f3-8d96-50882e457efd',
                    'fieldLabel': 'Фамилия',
                    'labelAlign': 'top',
                    'modelProperty': 'Individuals_Surname',
                    'name': 'Surname',
                    'rmsUid': 'ace72536-1b25-42f3-8d96-50882e457efd',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': '95ecf95e-d90c-43e4-8c4b-2ace53a99186',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-05c289ed-c1ac-405a-8ba8-ec5be5b47e69',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d$02c16e5e-79e3-42b2-837e-b9e8ec19aaa5',
                    'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-5591bf2a-a7fc-416d-aea3-bea89ec4953e',
                    'fieldLabel': 'Имя',
                    'labelAlign': 'top',
                    'modelProperty': 'Individuals_Name',
                    'name': 'Name',
                    'rmsUid': '5591bf2a-a7fc-416d-aea3-bea89ec4953e',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': '05c289ed-c1ac-405a-8ba8-ec5be5b47e69',
                'xtype': 'container'
            }, {
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-ee58bb96-17e2-4854-8dea-50439dabadd0',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d$8baa4ced-6274-402c-ac1b-0db307331b44',
                    'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-d8115caf-502d-43fd-bef2-0a8d5c903ed5',
                    'fieldLabel': 'Отчество',
                    'labelAlign': 'top',
                    'modelProperty': 'Individuals_Patronymic',
                    'name': 'Patronymic',
                    'rmsUid': 'd8115caf-502d-43fd-bef2-0a8d5c903ed5',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'ee58bb96-17e2-4854-8dea-50439dabadd0',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'dbf790f8-86f7-445b-b2ea-f11a2bd7a024',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-73101be0-b192-4331-83a3-9e93b2dd50de',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-10ad511e-89e5-46b1-bd87-20c7d684673f',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d$9eb7280e-5e7f-4c39-b975-ad80302db2f6',
                    'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-2d48ca36-49f4-4fa4-9b69-366d793a51fa',
                    'fieldLabel': 'ФИО',
                    'labelAlign': 'top',
                    'modelProperty': 'Individuals_FIO',
                    'name': 'FIO',
                    'rmsUid': '2d48ca36-49f4-4fa4-9b69-366d793a51fa',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': '10ad511e-89e5-46b1-bd87-20c7d684673f',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '73101be0-b192-4331-83a3-9e93b2dd50de',
            'xtype': 'container'
        }, {
            'anchor': '100%',
            'dockedItems': [],
            'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-e751991e-db43-4ef5-88b3-3677459da080',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-85beed43-743b-4683-8156-8b079b2c86c1',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d$6921b320-087a-421a-804d-0506c8838012',
                    'extraCls': 'cmp-style-2efed10a-d54e-46b9-ac19-6b9792c2fb9e-c2758611-1346-4bcf-9ba2-db34beef7c63',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'Individuals_Comment',
                    'name': 'Comment',
                    'rmsUid': 'c2758611-1346-4bcf-9ba2-db34beef7c63',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': '85beed43-743b-4683-8156-8b079b2c86c1',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': 'e751991e-db43-4ef5-88b3-3677459da080',
            'xtype': 'container'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'Individuals_Id',
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
            me.setTitle('Добавление физ лица');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        return res;
    },
});