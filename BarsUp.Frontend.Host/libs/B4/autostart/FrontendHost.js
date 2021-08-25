Ext.define('B4.autostart.FrontendHost', {
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