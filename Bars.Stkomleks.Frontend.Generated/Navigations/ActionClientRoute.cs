namespace Bars.Stkomleks
{
using Bars.Stkomleks.Core.Generated;
using Bars.Stkomleks.Frontend.Abstractions.Generated;    
    using BarsUp;
    using BarsUp.UI.ExtJs.Compatibility4;
    using BarsUp.Modules.MacroAccessManagement;

    public class ActionClientRoute : IExtJsControllerClientRouteMapRegistrar
    {        
        #region Implementation of IExtJsControllerClientRouteMapRegistrar

        /// <summary>
        /// Метод регистрации роута в общей карте
        /// </summary>
        /// <param name="map"></param>
        public void RegisterRoutes(ExtJsControllerClientRouteMap map)
        {
            map.AddRoute(new ExtJsControllerClientRoute("OrdersList-Edit/{id}/", "B4.controller.OrdersList", "executeActionEdit"));
map.AddRoute(new ExtJsControllerClientRoute("OrdersObjectsList2-Edit/{id}/", "B4.controller.OrdersObjectsList2", "executeActionEdit"));
map.AddRoute(new ExtJsControllerClientRoute("OrdersObjectsList-Edit/{id}/", "B4.controller.OrdersObjectsList", "executeActionEdit"));
        }

        #endregion
    }
}