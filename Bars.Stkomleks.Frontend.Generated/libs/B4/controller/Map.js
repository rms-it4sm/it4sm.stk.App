Ext.define('B4.controller.Map', {
    extend: 'B4.base.panel.Controller',
    models: [],
    views: [
        'Map'],
    requires: [
        'B4.view.Map'],
    aspects: [{
        'permissions': [],
        'xtype': 'permissionaspect'
    }],
    // алиас контролируемых представлений
    viewAlias: 'rms-map',
    viewDataName: 'Map',
    init: function() {
        var me = this;
        me.callParent(arguments);
    },
    applyCtxValues: function(rec, form) {
        var me = this,
            ctrl = null,
            element = null,
            model = null;
        var _ctrl = null,
            _ctxParams = null,
            _editorCtxValues = form.getEditorValues(true);
    },
    onViewConnected: function(view) {
        var me = this,
            element = null,
            ctrl = null;
        // при привязке представления к контроллеру  необходимо обойти 
        // список вложенных представлений (реестров, редакторов и т.д.)
        // и привязать их к их контроллерам
    },
    onViewDeployed: function(view) {
        var me = this,
            element = null,
            ctrl = null,
            form = view;
        // после размещения представления необходимо обойти 
        // список вложенных представлений (реестров, редакторов и т.д.)
        // и выполнить допонительные методы инициализации
        // в данный момент параметры контекста заданы, 
        // компоненты созданы и отрендерены	
        //повторная инициализация аспекта permissionaspect
        if (this.aspectCollection) {
            this.aspectCollection.each(function(aspect) {
                if (aspect && aspect.xtype == 'permissionaspect') {
                    aspect.init(this);
                }
            }, this);
        }
    },
});