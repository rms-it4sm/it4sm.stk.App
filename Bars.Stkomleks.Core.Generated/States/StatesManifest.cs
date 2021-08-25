namespace Bars.Stkomleks.States
{
    using System.Collections.Generic;
    using BarsUp.Modules.States;

    /// <summary>
    /// Объявление статусов
    /// </summary>
    public class StatesManifest : IStatefulEntitiesManifest
    {
        /// <summary>
        /// Получить все статусные объекты
        /// </summary>
        /// <returns>Список</returns>
        public IEnumerable<StatefulEntityInfo> GetAllInfo()
        {
            var list = new List<StatefulEntityInfo>();
            list.Add(new StatefulEntityInfo("bars.stkomleks.zakaz", "Заказы", typeof(Bars.Stkomleks.Zakaz)));
list.Add(new StatefulEntityInfo("bars.stkomleks.ordersobjects", "Объекты", typeof(Bars.Stkomleks.OrdersObjects)));
list.Add(new StatefulEntityInfo("bars.stkomleks.compositionworksobjects", "Работы объектов", typeof(Bars.Stkomleks.CompositionWorksObjects)));
list.Add(new StatefulEntityInfo("bars.stkomleks.organization", "Организации", typeof(Bars.Stkomleks.Organization)));
list.Add(new StatefulEntityInfo("bars.stkomleks.staff", "Сотрудники", typeof(Bars.Stkomleks.Staff)));
            return list.ToArray();            
        }
    }
}	