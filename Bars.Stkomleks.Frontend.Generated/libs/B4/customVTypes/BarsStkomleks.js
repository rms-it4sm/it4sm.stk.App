Ext.define('B4.customVTypes.BarsStkomleks', {
    singleton: true,
    requires: ['Ext.form.field.VTypes'],
    constructor: function() {
        if (!Ext.form.field.VTypes.Configs) {
            Ext.form.field.VTypes.Configs = {};
        }
    }
});
Ext.override(Ext.window.MessageBox, {
    autoScroll: true,
    alert: function(cfg, msg, fn, scope) {
        if (Ext.isString(cfg)) {
            cfg = {
                title: cfg,
                msg: msg,
                buttons: this.OK,
                fn: fn,
                scope: scope,
                minWidth: this.minWidth
            };
        }
        return this.show(cfg);
    }
});