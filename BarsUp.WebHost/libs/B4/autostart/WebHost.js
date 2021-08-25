Ext.define('B4.autostart.WebHost', {
    singleton: true,
    requires: [
        'BarsUp.biux.desktop.Viewport', ],
    onBeforeViewport: function(cfg) {
        cfg.mainView = 'BarsUp.biux.desktop.Viewport';
        cfg.mainViewConfig = {
            "splitter": {},
            "menuEvents": {}
        };
    }
});