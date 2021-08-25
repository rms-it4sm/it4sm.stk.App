Ext.define('B4.view.OrganizationEditor', {
    extend: 'B4.base.form.View',
    alias: 'widget.rms-organizationeditor',
    title: 'Организация',
    rmsUid: '7bfd891d-f74e-48c4-9141-e68896e91cc3',
    rmsElementUid: '7bfd891d-f74e-48c4-9141-e68896e91cc3',
    dataSourceUid: '242b06d2-b239-47ad-b75a-cbf88a4b987b',
    requires: [
        'B4.view.DepartmentsList',
        'B4.view.OrganizationContactsList',
        'B4.view.OrganizationFundingProgramsList',
        'B4.view.OrganizationProfilesList',
        'B4.view.RelatedOrganizationsList',
        'B4.view.StaffList'],
    statics: {
        windowSize: {
            height: 600,
            width: 700
        }
    },
    metaFields: [{
        'dataIndex': 'Id',
        'modelProperty': 'Organization_Id',
        'type': 'hidden'
    }, {
        'dataIndex': 'Name',
        'modelProperty': 'Organization_Name',
        'type': 'TextField'
    }, {
        'dataIndex': 'FullName',
        'modelProperty': 'Organization_FullName',
        'type': 'TextField'
    }, {
        'dataIndex': 'Comment',
        'modelProperty': 'Organization_Comment',
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
        'rmsUid': '7bfd891d-f74e-48c4-9141-e68896e91cc3-Form-TopToolBar',
        'xtype': 'toolbar'
    }],
    items: [{
        xtype: 'container',
        itemId: 'OrganizationEditor-container',
        'layout': {
            'align': 'stretch',
            'type': 'vbox'
        },
        'region': 'Center',
        items: [{
            'dockedItems': [],
            'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-688723fd-c0de-4f09-b693-efe17289d3ea',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-70e31744-5ee7-4597-93cd-9407876056b1',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://242b06d2-b239-47ad-b75a-cbf88a4b987b$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                    'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-8967b231-f09f-444d-8ebf-df640d6e5ea7',
                    'fieldLabel': 'Наименование',
                    'labelAlign': 'top',
                    'modelProperty': 'Organization_Name',
                    'name': 'Name',
                    'rmsUid': '8967b231-f09f-444d-8ebf-df640d6e5ea7',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': '70e31744-5ee7-4597-93cd-9407876056b1',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '688723fd-c0de-4f09-b693-efe17289d3ea',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-01136a4a-0eba-470a-9520-6e93078d0458',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-aa892c7d-648d-4d9b-a000-d8dce1a5e8b8',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://242b06d2-b239-47ad-b75a-cbf88a4b987b$597802ac-f55b-40ee-98da-f63d361ae48c',
                    'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-d9aaab32-d046-44a2-9640-5112287c8446',
                    'fieldLabel': 'Полное наименование',
                    'labelAlign': 'top',
                    'modelProperty': 'Organization_FullName',
                    'name': 'FullName',
                    'rmsUid': 'd9aaab32-d046-44a2-9640-5112287c8446',
                    'xtype': 'textfield'
                }],
                'layout': 'anchor',
                'rmsUid': 'aa892c7d-648d-4d9b-a000-d8dce1a5e8b8',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '01136a4a-0eba-470a-9520-6e93078d0458',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-47aa74b4-2bb6-434a-8af8-8f4d36d09082',
            'items': [{
                'defaults': {
                    'margin': '5 5 5 5'
                },
                'dockedItems': [],
                'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-cfc57a0a-348d-48b8-a69a-bc049388cdd4',
                'flex': 1,
                'items': [{
                    'anchor': '100%',
                    'dataIndexAbsoluteUid': 'FieldPath://242b06d2-b239-47ad-b75a-cbf88a4b987b$344fe108-25f3-42b4-a688-72a4f911da37',
                    'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-5803587b-88bc-4dc9-9b20-69f8c6fbe17c',
                    'fieldLabel': 'Описание',
                    'labelAlign': 'top',
                    'modelProperty': 'Organization_Comment',
                    'name': 'Comment',
                    'rmsUid': '5803587b-88bc-4dc9-9b20-69f8c6fbe17c',
                    'xtype': 'textarea'
                }],
                'layout': 'anchor',
                'rmsUid': 'cfc57a0a-348d-48b8-a69a-bc049388cdd4',
                'xtype': 'container'
            }],
            'layout': 'hbox',
            'rmsUid': '47aa74b4-2bb6-434a-8af8-8f4d36d09082',
            'xtype': 'container'
        }, {
            'dockedItems': [],
            'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-de543d87-4d96-41a1-9b65-55b7f356e7ee',
            'fieldLabel': 'Панель закладок',
            'flex': 1,
            'header': false,
            'items': [{
                'dockedItems': [],
                'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-47e31e2d-1c03-425a-bec3-eddf7c188db7',
                'fieldLabel': 'Контакты',
                'flex': 1,
                'iconCls': 'fad fa-address-card',
                'items': [{
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
                                "DataIndex": "FieldPath://2ab43a3b-81eb-4f93-8d61-eb1304c71200$56a4d0ab-d6fa-4f25-aab9-24b4e09fa869$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@Organization_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-542d988f-c13a-4abf-9773-8f7b7bddc79b',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'OrganizationContactsList',
                    'region': 'Center',
                    'rmsUid': '542d988f-c13a-4abf-9773-8f7b7bddc79b',
                    'title': null,
                    'xtype': 'rms-organizationcontactslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '47e31e2d-1c03-425a-bec3-eddf7c188db7',
                'title': 'Контакты',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-a43cf966-c60e-4eb7-9dc3-4d3ac4be2ab3',
                'fieldLabel': 'Подразделения',
                'flex': 1,
                'iconCls': 'fad fa-stream',
                'items': [{
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
                                "DataIndex": "FieldPath://493d5e72-6f08-4da0-9fa7-bfd88e202a82$4232236c-1a3f-44b0-9871-c455627e996f$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@Organization_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-2bd09945-7b59-431c-b05a-a90003098ec5',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'DepartmentsList',
                    'region': 'Center',
                    'rmsUid': '2bd09945-7b59-431c-b05a-a90003098ec5',
                    'title': null,
                    'xtype': 'rms-departmentslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': 'a43cf966-c60e-4eb7-9dc3-4d3ac4be2ab3',
                'title': 'Подразделения',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-4f5c5134-d8eb-49d7-8c6c-3497ef5a5ea8',
                'fieldLabel': 'Сотрудники',
                'flex': 1,
                'iconCls': 'fad fa-user-hard-hat',
                'items': [{
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
                                "DataIndex": "FieldPath://0b83a4c4-1b8b-49d6-b16b-dcb3a373a391$877ada62-82d4-4fca-8574-61c4290187d5$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@Organization_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-dc0d23ec-305f-4892-b9b6-0deef3a9385b',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'StaffList',
                    'region': 'Center',
                    'rmsUid': 'dc0d23ec-305f-4892-b9b6-0deef3a9385b',
                    'title': null,
                    'xtype': 'rms-stafflist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '4f5c5134-d8eb-49d7-8c6c-3497ef5a5ea8',
                'title': 'Сотрудники',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-f0117339-7df9-4b78-acc3-d4197cd20b4e',
                'fieldLabel': 'Программы финансирования',
                'flex': 1,
                'iconCls': 'fad fa-ruble-sign',
                'items': [{
                    'closable': false,
                    'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-fc58811c-44cb-48aa-879b-a16438ac1388',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'OrganizationFundingProgramsList',
                    'region': 'Center',
                    'rmsUid': 'fc58811c-44cb-48aa-879b-a16438ac1388',
                    'title': null,
                    'xtype': 'rms-organizationfundingprogramslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': 'f0117339-7df9-4b78-acc3-d4197cd20b4e',
                'title': 'Программы финансирования',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-b6393dc2-68e1-4fd9-a36c-542e83b780a1',
                'fieldLabel': 'Профили',
                'flex': 1,
                'iconCls': 'fad fa-list-ul',
                'items': [{
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
                                "DataIndex": "FieldPath://2f3cc7da-d8a3-4c53-b83f-ec26f028202e$e0a08ecf-f833-461a-8b0d-8d7e5d4e4778$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@Organization_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-8dbc5025-53e5-4b7d-9d21-63b2801b3038',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'OrganizationProfilesList',
                    'region': 'Center',
                    'rmsUid': '8dbc5025-53e5-4b7d-9d21-63b2801b3038',
                    'title': null,
                    'xtype': 'rms-organizationprofileslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': 'b6393dc2-68e1-4fd9-a36c-542e83b780a1',
                'title': 'Профили',
                'xtype': 'container'
            }, {
                'dockedItems': [],
                'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-1c7839c6-8f66-4c90-84dd-0201796e82f9',
                'fieldLabel': 'Взаимосвязанные организации',
                'flex': 1,
                'items': [{
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
                                "DataIndex": "FieldPath://ba084c30-4998-4494-a718-d6eca64c6140$42fbc98d-ab6c-474a-8a5e-74f8b1811518$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id",
                                "DataIndexType": null,
                                "Value": "@Organization_Id",
                                "Filters": null,
                                "IsEmpty": false
                            }],
                            "IsEmpty": false
                        }
                    },
                    'closable': false,
                    'extraCls': 'cmp-style-7bfd891d-f74e-48c4-9141-e68896e91cc3-4b7447e6-7130-4b6c-94de-2178565fa862',
                    'flex': 1,
                    'header': false,
                    'inlineCascadeSave': false,
                    'name': 'RelatedOrganizationsList',
                    'region': 'Center',
                    'rmsUid': '4b7447e6-7130-4b6c-94de-2178565fa862',
                    'title': null,
                    'xtype': 'rms-relatedorganizationslist'
                }],
                'layout': {
                    'type': 'fit'
                },
                'region': 'Center',
                'rmsUid': '1c7839c6-8f66-4c90-84dd-0201796e82f9',
                'title': 'Взаимосвязанные организации',
                'xtype': 'container'
            }],
            'layout': {
                'type': 'fit'
            },
            'region': 'Center',
            'rmsUid': 'de543d87-4d96-41a1-9b65-55b7f356e7ee',
            'title': null,
            'xtype': 'tabpanel'
        }, {
            'hidden': true,
            'items': [{
                'modelProperty': 'Organization_Id',
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
        me.grid_OrganizationContactsList = me.down('rms-organizationcontactslist[name=OrganizationContactsList]');
        me.grid_DepartmentsList = me.down('rms-departmentslist[name=DepartmentsList]');
        me.grid_StaffList = me.down('rms-stafflist[name=StaffList]');
        me.grid_OrganizationFundingProgramsList = me.down('rms-organizationfundingprogramslist[name=OrganizationFundingProgramsList]');
        me.grid_OrganizationProfilesList = me.down('rms-organizationprofileslist[name=OrganizationProfilesList]');
        me.grid_RelatedOrganizationsList = me.down('rms-relatedorganizationslist[name=RelatedOrganizationsList]');
    },
    beforeLoadRecord: function(entityId) {
        var me = this;
        if (!Ext.isNumber(entityId) || entityId <= 0) {
            me.setTitle('Добавление организации');
        }
    },
    loadRecord: function(rec) {
        var me = this,
            res = me.callParent(arguments),
            entityId = rec.get('Id');
        if (Ext.isNumber(entityId) && entityId > 0) {
            me.setTitle(rec.get('Name'));
        }
        return res;
    },
});