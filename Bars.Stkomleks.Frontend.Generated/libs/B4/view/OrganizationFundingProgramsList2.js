Ext.define('B4.view.OrganizationFundingProgramsList2', {
    'alias': 'widget.rms-organizationfundingprogramslist2',
    'dataSourceUid': '0de41a18-2d17-4f59-b60b-e39e0559c240',
    'enableColumnHide': true,
    'enableColumnMove': true,
    'enableColumnResize': true,
    'extend': 'B4.base.registry.View',
    'model': 'B4.model.OrganizationFundingProgramsList2Model',
    'rmsElementUid': 'dbf839ff-91bd-4f87-a390-154f8db2a097',
    'rmsUid': 'dbf839ff-91bd-4f87-a390-154f8db2a097',
    'stateful': false,
    'title': 'Оганизации.Программа финансирования',
    requires: [
        'B4.model.OrganizationFundingProgramsList2Model',
        'B4.ux.grid.plugin.StyleConditions',
        'BarsUp.filter.ExtGridPlugin'],
    features: [{
        'ftype': 'grouping'
    }],
    'tbar': [{
        'actionName': 'update',
        'extraCls': 'cmp-style-dbf839ff-91bd-4f87-a390-154f8db2a097-38a10156-9bd6-4e7f-9a3c-185406e1d0dc',
        'hidden': false,
        'iconCls': 'icon-arrow-refresh',
        'ignoreMakeInactive': false,
        'itemId': 'Refresh',
        'rmsUid': '38a10156-9bd6-4e7f-9a3c-185406e1d0dc',
        'text': 'Обновить'
    }, {
        'extraCls': 'cmp-style-dbf839ff-91bd-4f87-a390-154f8db2a097-d3eafc66-51e2-4b9a-91f9-d3b68d0a4a10',
        'handler': function(item, e) {
            try {
                var _self = this,
                    _args = Array.prototype.slice.call(arguments);
                var grid = this.getDataGrid && this.getDataGrid() ? this.getDataGrid() : (this.is && (this.is('grid') || this.is('treepanel')) ? this : (this.up ? this.up('grid') || this.up('treepanel') : null)),
                    sel = grid && grid.getSelectionModel().getSelection()[0],
                    fld = sel && sel.get('Id'),
                    grid1 = B4.utils.FormHelper.findNearestListView(typeof _self === 'undefined' ? this : _self),
                    ctxKey = (grid1 && grid1.ctxKey) || this.getCurrentContextKey(),
                    dataVariables = new B4.variables.Container();
                grid1 && grid1.data && grid1.data.getVariables().forEach(v => dataVariables.set(v.code, v.value));
                var inWindow = false;
                var parentComponentWithVersionAttribute = B4.utils.FormHelper.findNearestParentWithAttribute(grid1, 'versionScope');
                var parentComponentWithChangeSetAttribute = B4.utils.FormHelper.findNearestParentWithAttribute(grid1, 'changeSet');
                B4.Navigation.openForm("OrganizationEditor", fld, inWindow, true, {
                    dataVariables: dataVariables,
                    RmsDataGridAlias: this.viewAlias,
                    RmsDataGridId: grid1 ? grid1.getId() : null,
                    ctxKey: ctxKey,
                    isDataGridEditor: !Ext.isEmpty(grid1),
                    versionScope: parentComponentWithVersionAttribute != null ? Ext.decode(Ext.encode(parentComponentWithVersionAttribute.versionScope)) : null,
                    changeSet: parentComponentWithChangeSetAttribute != null ? Ext.decode(Ext.encode(parentComponentWithChangeSetAttribute.changeSet)) : null,
                    maximizable: true,
                    viewStack: grid1 && grid1.viewStack ? [...grid1.viewStack] : []
                });
            } catch (_e__r__r) {
                console.warn("Ошибка в событии `Действие на строке списка (кнопка)` элемента `d3eafc66-51e2-4b9a-91f9-d3b68d0a4a10`");
                throw _e__r__r;
            }
        },
        'hidden': false,
        'iconCls': 'fad fa-building',
        'ignoreMakeInactive': false,
        'itemId': 'ListViewRow',
        'rmsUid': 'd3eafc66-51e2-4b9a-91f9-d3b68d0a4a10',
        'text': 'Открыть организацию'
    }],
    paging: 50,
    initComponent: function() {
        var me = this;
        Ext.apply(me, {
            columns: [{
                'dataIndex': 'FundingPrograms_Id',
                'dataIndexAbsoluteUid': 'FieldPath://0de41a18-2d17-4f59-b60b-e39e0559c240$f95a256b-5ae1-40f4-aa65-89e63c58f335$BarsUp.DataAccess.PersistentObject, BarsUp.Core/Id',
                'dataIndexRelativePath': 'FundingPrograms.Id',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-number-property'
                },
                'flex': 1,
                'hidden': true,
                'menuDisabled': false,
                'rmsUid': '44fdf0bc-8985-479a-a1db-83c6efc228a2',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Программа финансирования.Идентификатор',
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Organization_Name',
                'dataIndexAbsoluteUid': 'FieldPath://0de41a18-2d17-4f59-b60b-e39e0559c240$a739203f-8f97-4e4a-b804-7d0a5ae76632$291234e7-3e4e-49ad-9652-9e47bcf814f4',
                'dataIndexRelativePath': 'Organization.Name',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'menuDisabled': false,
                'rmsUid': '07b1ed0a-0d2f-4b22-a863-984e46db9e8f',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Наименование',
                'width': 200,
                'xtype': 'gridcolumn'
            }, {
                'dataIndex': 'Organization_Comment',
                'dataIndexAbsoluteUid': 'FieldPath://0de41a18-2d17-4f59-b60b-e39e0559c240$a739203f-8f97-4e4a-b804-7d0a5ae76632$344fe108-25f3-42b4-a688-72a4f911da37',
                'dataIndexRelativePath': 'Organization.Comment',
                'decimalPrecision': 2,
                'filter': {
                    'xtype': 'b4-filter-field-list-of-string-property'
                },
                'flex': 1,
                'menuDisabled': false,
                'rmsUid': '4c624b37-a4e2-4ce9-a895-b3d5f253b386',
                'sortable': true,
                'summaryRenderer': function(value) {
                    return Ext.String.format('{0}', value);
                },
                'summaryType': 'none',
                'text': 'Описание',
                'xtype': 'gridcolumn'
            }],
            plugins: [{
                'ptype': 'gridfilters',
                'renderHidden': false,
                'showClearAllButton': false,
                'showShowHideButton': false
            }, {
                'conditions': [],
                'ptype': 'gridStyleConditions'
            }]
        });
        me.callParent(arguments);
    }
});