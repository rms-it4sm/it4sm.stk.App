Ext.define('B4.autostart.WebHost', {
    singleton: true,
    requires: [
        'BarsUp.flexdesk.viewport.Default', ],
    onBeforeViewport: function(cfg) {
        cfg.mainView = 'BarsUp.flexdesk.viewport.Default';
        cfg.mainViewConfig = {
            "splitter": {},
            "menuEvents": {}
        };
    }
});