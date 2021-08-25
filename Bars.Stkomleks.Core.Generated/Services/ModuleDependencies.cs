namespace Bars.Stkomleks
{    
    using BarsUp;
    using BarsUp.DataAccess;    
    using BarsUp.DataAccess.Extentions;

    using Castle.Windsor;

    using System;    
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;
    using BarsUp.Utils;
    using NHibernate;

    public class ModuleDependencies : BaseModuleDependencies
    {
        public ModuleDependencies(IWindsorContainer container)
            : base(container)
        {
            RegisterContactsTypeDependencies();
RegisterCurrentPositionsDepartmentsDependencies();
RegisterDepartmentsDependencies();
RegisterDepartmentsPositionsDependencies();
RegisterDepartmentsTypeDependencies();
RegisterDocumentsTypeDependencies();
RegisterFundingProgramsDependencies();
RegisterIndividualsDependencies();
RegisterObjectProductsDependencies();
RegisterObjectsStagesDependencies();
RegisterObjectsTypesDependencies();
RegisterOrderOrganizationDependencies();
RegisterOrdersObjectsDependencies();
RegisterOrganizationDependencies();
RegisterOrganizationProfilesDependencies();
RegisterPositionsTypesDependencies();
RegisterProductsTypesDependencies();
RegisterProfilesOrganizationsDependencies();
RegisterStaffDependencies();
RegisterTypesWorkTypesObjectsDependencies();
RegisterUnitMeasureDependencies();
RegisterWorksRolesDependencies();
RegisterWorksTypesDependencies();
RegisterZakazDependencies();
        }
        
        #region Типы контактов и его наследники
private void RegisterContactsTypeDependencies()
{
    #region Типы контактов
    References.Add(new EntityReference
    {
        ReferenceName = "Контакты физ лиц",
        BaseEntity = typeof(Bars.Stkomleks.ContactsType),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ContactsIndiv>(x => x.Type != null && x.Type.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ContactsIndiv>(x => x.Type != null && x.Type.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ContactsIndiv>()
                .Where(x => x.Type != null && x.Type.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ContactsIndiv),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Контакты организации",
        BaseEntity = typeof(Bars.Stkomleks.ContactsType),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrganizationContacts>(x => x.Type != null && x.Type.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrganizationContacts>(x => x.Type != null && x.Type.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrganizationContacts>()
                .Where(x => x.Type != null && x.Type.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrganizationContacts),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Занимаемые должности подразделений и его наследники
private void RegisterCurrentPositionsDepartmentsDependencies()
{
    #region Занимаемые должности подразделений
    References.Add(new EntityReference
    {
        ReferenceName = "Специалисты объектов",
        BaseEntity = typeof(Bars.Stkomleks.CurrentPositionsDepartments),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionObjectSpecialists>(x => x.Staff != null && x.Staff.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionObjectSpecialists>(x => x.Staff != null && x.Staff.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionObjectSpecialists>()
                .Where(x => x.Staff != null && x.Staff.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionObjectSpecialists),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Подразделения и его наследники
private void RegisterDepartmentsDependencies()
{
    #region Подразделения
    References.Add(new EntityReference
    {
        ReferenceName = "Работы объектов",
        BaseEntity = typeof(Bars.Stkomleks.Departments),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.Brigade != null && x.Brigade.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.Brigade != null && x.Brigade.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionWorksObjects>()
                .Where(x => x.Brigade != null && x.Brigade.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionWorksObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Должности подразделения",
        BaseEntity = typeof(Bars.Stkomleks.Departments),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.DepartmentsPositions>(x => x.Department != null && x.Department.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.DepartmentsPositions>(x => x.Department != null && x.Department.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.DepartmentsPositions>()
                .Where(x => x.Department != null && x.Department.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.DepartmentsPositions),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Должности подразделения и его наследники
private void RegisterDepartmentsPositionsDependencies()
{
    #region Должности подразделения
    References.Add(new EntityReference
    {
        ReferenceName = "Занимаемые должности подразделений",
        BaseEntity = typeof(Bars.Stkomleks.DepartmentsPositions),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CurrentPositionsDepartments>(x => x.DepartmentPosition != null && x.DepartmentPosition.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CurrentPositionsDepartments>(x => x.DepartmentPosition != null && x.DepartmentPosition.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CurrentPositionsDepartments>()
                .Where(x => x.DepartmentPosition != null && x.DepartmentPosition.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CurrentPositionsDepartments),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Виды подразделений и его наследники
private void RegisterDepartmentsTypeDependencies()
{
    #region Виды подразделений
    References.Add(new EntityReference
    {
        ReferenceName = "Подразделения",
        BaseEntity = typeof(Bars.Stkomleks.DepartmentsType),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.Departments>(x => x.Type != null && x.Type.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.Departments>(x => x.Type != null && x.Type.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.Departments>()
                .Where(x => x.Type != null && x.Type.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.Departments),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Типы документов и его наследники
private void RegisterDocumentsTypeDependencies()
{
    #region Типы документов
    References.Add(new EntityReference
    {
        ReferenceName = "Документы договоров",
        BaseEntity = typeof(Bars.Stkomleks.DocumentsType),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ContractDocuments>(x => x.Type != null && x.Type.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ContractDocuments>(x => x.Type != null && x.Type.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ContractDocuments>()
                .Where(x => x.Type != null && x.Type.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ContractDocuments),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Документы",
        BaseEntity = typeof(Bars.Stkomleks.DocumentsType),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.Documents>(x => x.Type != null && x.Type.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.Documents>(x => x.Type != null && x.Type.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.Documents>()
                .Where(x => x.Type != null && x.Type.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.Documents),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Программы финансирования и его наследники
private void RegisterFundingProgramsDependencies()
{
    #region Программы финансирования
    References.Add(new EntityReference
    {
        ReferenceName = "Программы финансирования организации",
        BaseEntity = typeof(Bars.Stkomleks.FundingPrograms),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrganizationFundingPrograms>(x => x.FundingPrograms != null && x.FundingPrograms.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrganizationFundingPrograms>(x => x.FundingPrograms != null && x.FundingPrograms.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrganizationFundingPrograms>()
                .Where(x => x.FundingPrograms != null && x.FundingPrograms.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrganizationFundingPrograms),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Физические лица и его наследники
private void RegisterIndividualsDependencies()
{
    #region Физические лица
    References.Add(new EntityReference
    {
        ReferenceName = "Контакты физ лиц",
        BaseEntity = typeof(Bars.Stkomleks.Individuals),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ContactsIndiv>(x => x.Individual != null && x.Individual.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ContactsIndiv>(x => x.Individual != null && x.Individual.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ContactsIndiv>()
                .Where(x => x.Individual != null && x.Individual.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ContactsIndiv),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Сотрудники",
        BaseEntity = typeof(Bars.Stkomleks.Individuals),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.Staff>(x => x.Individual != null && x.Individual.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.Staff>(x => x.Individual != null && x.Individual.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.Staff>()
                .Where(x => x.Individual != null && x.Individual.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.Staff),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Спецификация объекта и его наследники
private void RegisterObjectProductsDependencies()
{
    #region Спецификация объекта
    References.Add(new EntityReference
    {
        ReferenceName = "Работы объектов",
        BaseEntity = typeof(Bars.Stkomleks.ObjectProducts),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.ObjectElement != null && x.ObjectElement.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.ObjectElement != null && x.ObjectElement.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionWorksObjects>()
                .Where(x => x.ObjectElement != null && x.ObjectElement.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionWorksObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Комплектация элементов объектов",
        BaseEntity = typeof(Bars.Stkomleks.ObjectProducts),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.Products>(x => x.ObjectSpecification != null && x.ObjectSpecification.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.Products>(x => x.ObjectSpecification != null && x.ObjectSpecification.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.Products>()
                .Where(x => x.ObjectSpecification != null && x.ObjectSpecification.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.Products),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region УДЛ_Этапы объектов и его наследники
private void RegisterObjectsStagesDependencies()
{
    #region УДЛ_Этапы объектов
    References.Add(new EntityReference
    {
        ReferenceName = "УДЛ_Этапы объектов",
        BaseEntity = typeof(Bars.Stkomleks.ObjectsStages),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ObjectsStages>(x => x.IncludidIn != null && x.IncludidIn.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ObjectsStages>(x => x.IncludidIn != null && x.IncludidIn.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ObjectsStages>()
                .Where(x => x.IncludidIn != null && x.IncludidIn.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ObjectsStages),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Типы объектов и его наследники
private void RegisterObjectsTypesDependencies()
{
    #region Типы объектов
    References.Add(new EntityReference
    {
        ReferenceName = "Объекты",
        BaseEntity = typeof(Bars.Stkomleks.ObjectsTypes),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrdersObjects>(x => x.Type != null && x.Type.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrdersObjects>(x => x.Type != null && x.Type.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrdersObjects>()
                .Where(x => x.Type != null && x.Type.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrdersObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Виды работ.Типы объектов",
        BaseEntity = typeof(Bars.Stkomleks.ObjectsTypes),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.TypesWorkTypesObjects>(x => x.ObjectType != null && x.ObjectType.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.TypesWorkTypesObjects>(x => x.ObjectType != null && x.ObjectType.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.TypesWorkTypesObjects>()
                .Where(x => x.ObjectType != null && x.ObjectType.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.TypesWorkTypesObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Организации заказа и его наследники
private void RegisterOrderOrganizationDependencies()
{
    #region Организации заказа
    References.Add(new EntityReference
    {
        ReferenceName = "Ответственные лица заказа",
        BaseEntity = typeof(Bars.Stkomleks.OrderOrganization),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ResponsiblePersonsOrder>(x => x.OrderOrganization != null && x.OrderOrganization.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ResponsiblePersonsOrder>(x => x.OrderOrganization != null && x.OrderOrganization.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ResponsiblePersonsOrder>()
                .Where(x => x.OrderOrganization != null && x.OrderOrganization.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ResponsiblePersonsOrder),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Объекты и его наследники
private void RegisterOrdersObjectsDependencies()
{
    #region Объекты
    References.Add(new EntityReference
    {
        ReferenceName = "Специалисты объектов",
        BaseEntity = typeof(Bars.Stkomleks.OrdersObjects),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionObjectSpecialists>(x => x.Object != null && x.Object.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionObjectSpecialists>(x => x.Object != null && x.Object.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionObjectSpecialists>()
                .Where(x => x.Object != null && x.Object.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionObjectSpecialists),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Работы объектов",
        BaseEntity = typeof(Bars.Stkomleks.OrdersObjects),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.ObjectWork != null && x.ObjectWork.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.ObjectWork != null && x.ObjectWork.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionWorksObjects>()
                .Where(x => x.ObjectWork != null && x.ObjectWork.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionWorksObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Спецификация объекта",
        BaseEntity = typeof(Bars.Stkomleks.OrdersObjects),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ObjectProducts>(x => x.ObjectOrder != null && x.ObjectOrder.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ObjectProducts>(x => x.ObjectOrder != null && x.ObjectOrder.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ObjectProducts>()
                .Where(x => x.ObjectOrder != null && x.ObjectOrder.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ObjectProducts),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Документы объекта",
        BaseEntity = typeof(Bars.Stkomleks.OrdersObjects),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ObjectsDocuments>(x => x.ObjectWork != null && x.ObjectWork.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ObjectsDocuments>(x => x.ObjectWork != null && x.ObjectWork.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ObjectsDocuments>()
                .Where(x => x.ObjectWork != null && x.ObjectWork.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ObjectsDocuments),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Заказы Объекты",
        BaseEntity = typeof(Bars.Stkomleks.OrdersObjects),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ObjectsOrders>(x => x.Object != null && x.Object.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ObjectsOrders>(x => x.Object != null && x.Object.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ObjectsOrders>()
                .Where(x => x.Object != null && x.Object.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ObjectsOrders),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "УДЛ_Этапы объектов",
        BaseEntity = typeof(Bars.Stkomleks.OrdersObjects),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ObjectsStages>(x => x.ObjectWork != null && x.ObjectWork.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ObjectsStages>(x => x.ObjectWork != null && x.ObjectWork.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ObjectsStages>()
                .Where(x => x.ObjectWork != null && x.ObjectWork.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ObjectsStages),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Организации и его наследники
private void RegisterOrganizationDependencies()
{
    #region Организации
    References.Add(new EntityReference
    {
        ReferenceName = "Подразделения",
        BaseEntity = typeof(Bars.Stkomleks.Organization),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.Departments>(x => x.Organization != null && x.Organization.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.Departments>(x => x.Organization != null && x.Organization.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.Departments>()
                .Where(x => x.Organization != null && x.Organization.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.Departments),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Контакты организации",
        BaseEntity = typeof(Bars.Stkomleks.Organization),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrganizationContacts>(x => x.Organization != null && x.Organization.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrganizationContacts>(x => x.Organization != null && x.Organization.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrganizationContacts>()
                .Where(x => x.Organization != null && x.Organization.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrganizationContacts),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Программы финансирования организации",
        BaseEntity = typeof(Bars.Stkomleks.Organization),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrganizationFundingPrograms>(x => x.Organization != null && x.Organization.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrganizationFundingPrograms>(x => x.Organization != null && x.Organization.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrganizationFundingPrograms>()
                .Where(x => x.Organization != null && x.Organization.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrganizationFundingPrograms),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Организации по профилю",
        BaseEntity = typeof(Bars.Stkomleks.Organization),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrganizationProfiles>(x => x.Organization != null && x.Organization.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrganizationProfiles>(x => x.Organization != null && x.Organization.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrganizationProfiles>()
                .Where(x => x.Organization != null && x.Organization.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrganizationProfiles),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Связанные организации",
        BaseEntity = typeof(Bars.Stkomleks.Organization),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.RelatedOrganizations>(x => x.Organization != null && x.Organization.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.RelatedOrganizations>(x => x.Organization != null && x.Organization.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.RelatedOrganizations>()
                .Where(x => x.Organization != null && x.Organization.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.RelatedOrganizations),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Связанные организации",
        BaseEntity = typeof(Bars.Stkomleks.Organization),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.RelatedOrganizations>(x => x.RelatedOrg != null && x.RelatedOrg.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.RelatedOrganizations>(x => x.RelatedOrg != null && x.RelatedOrg.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.RelatedOrganizations>()
                .Where(x => x.RelatedOrg != null && x.RelatedOrg.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.RelatedOrganizations),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Сотрудники",
        BaseEntity = typeof(Bars.Stkomleks.Organization),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.Staff>(x => x.Organization != null && x.Organization.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.Staff>(x => x.Organization != null && x.Organization.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.Staff>()
                .Where(x => x.Organization != null && x.Organization.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.Staff),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Организации по профилю и его наследники
private void RegisterOrganizationProfilesDependencies()
{
    #region Организации по профилю
    References.Add(new EntityReference
    {
        ReferenceName = "Работы объектов",
        BaseEntity = typeof(Bars.Stkomleks.OrganizationProfiles),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.ContractorWork != null && x.ContractorWork.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.ContractorWork != null && x.ContractorWork.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionWorksObjects>()
                .Where(x => x.ContractorWork != null && x.ContractorWork.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionWorksObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Документы договоров",
        BaseEntity = typeof(Bars.Stkomleks.OrganizationProfiles),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ContractDocuments>(x => x.Side1 != null && x.Side1.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ContractDocuments>(x => x.Side1 != null && x.Side1.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ContractDocuments>()
                .Where(x => x.Side1 != null && x.Side1.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ContractDocuments),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Документы договоров",
        BaseEntity = typeof(Bars.Stkomleks.OrganizationProfiles),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ContractDocuments>(x => x.Side2 != null && x.Side2.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ContractDocuments>(x => x.Side2 != null && x.Side2.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ContractDocuments>()
                .Where(x => x.Side2 != null && x.Side2.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ContractDocuments),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Организации заказа",
        BaseEntity = typeof(Bars.Stkomleks.OrganizationProfiles),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrderOrganization>(x => x.Organization != null && x.Organization.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrderOrganization>(x => x.Organization != null && x.Organization.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrderOrganization>()
                .Where(x => x.Organization != null && x.Organization.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrderOrganization),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Комплектация элементов объектов",
        BaseEntity = typeof(Bars.Stkomleks.OrganizationProfiles),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.Products>(x => x.Supplier != null && x.Supplier.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.Products>(x => x.Supplier != null && x.Supplier.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.Products>()
                .Where(x => x.Supplier != null && x.Supplier.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.Products),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Заказы",
        BaseEntity = typeof(Bars.Stkomleks.OrganizationProfiles),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.Zakaz>(x => x.Client != null && x.Client.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.Zakaz>(x => x.Client != null && x.Client.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.Zakaz>()
                .Where(x => x.Client != null && x.Client.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.Zakaz),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Виды должностей и его наследники
private void RegisterPositionsTypesDependencies()
{
    #region Виды должностей
    References.Add(new EntityReference
    {
        ReferenceName = "Должности подразделения",
        BaseEntity = typeof(Bars.Stkomleks.PositionsTypes),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.DepartmentsPositions>(x => x.Type != null && x.Type.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.DepartmentsPositions>(x => x.Type != null && x.Type.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.DepartmentsPositions>()
                .Where(x => x.Type != null && x.Type.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.DepartmentsPositions),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Типы продуктов и его наследники
private void RegisterProductsTypesDependencies()
{
    #region Типы продуктов
    References.Add(new EntityReference
    {
        ReferenceName = "Спецификация объекта",
        BaseEntity = typeof(Bars.Stkomleks.ProductsTypes),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ObjectProducts>(x => x.TypeElement != null && x.TypeElement.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ObjectProducts>(x => x.TypeElement != null && x.TypeElement.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ObjectProducts>()
                .Where(x => x.TypeElement != null && x.TypeElement.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ObjectProducts),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Профили организаций и его наследники
private void RegisterProfilesOrganizationsDependencies()
{
    #region Профили организаций
    References.Add(new EntityReference
    {
        ReferenceName = "Организации заказа",
        BaseEntity = typeof(Bars.Stkomleks.ProfilesOrganizations),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrderOrganization>(x => x.Profile != null && x.Profile.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrderOrganization>(x => x.Profile != null && x.Profile.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrderOrganization>()
                .Where(x => x.Profile != null && x.Profile.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrderOrganization),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Организации по профилю",
        BaseEntity = typeof(Bars.Stkomleks.ProfilesOrganizations),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrganizationProfiles>(x => x.Profile != null && x.Profile.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrganizationProfiles>(x => x.Profile != null && x.Profile.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrganizationProfiles>()
                .Where(x => x.Profile != null && x.Profile.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrganizationProfiles),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Сотрудники и его наследники
private void RegisterStaffDependencies()
{
    #region Сотрудники
    References.Add(new EntityReference
    {
        ReferenceName = "Занимаемые должности подразделений",
        BaseEntity = typeof(Bars.Stkomleks.Staff),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CurrentPositionsDepartments>(x => x.Staff != null && x.Staff.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CurrentPositionsDepartments>(x => x.Staff != null && x.Staff.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CurrentPositionsDepartments>()
                .Where(x => x.Staff != null && x.Staff.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CurrentPositionsDepartments),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Ответственные лица заказа",
        BaseEntity = typeof(Bars.Stkomleks.Staff),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ResponsiblePersonsOrder>(x => x.Staff != null && x.Staff.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ResponsiblePersonsOrder>(x => x.Staff != null && x.Staff.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ResponsiblePersonsOrder>()
                .Where(x => x.Staff != null && x.Staff.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ResponsiblePersonsOrder),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Заказы",
        BaseEntity = typeof(Bars.Stkomleks.Staff),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.Zakaz>(x => x.Manager != null && x.Manager.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.Zakaz>(x => x.Manager != null && x.Manager.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.Zakaz>()
                .Where(x => x.Manager != null && x.Manager.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.Zakaz),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Виды работ.Типы объектов и его наследники
private void RegisterTypesWorkTypesObjectsDependencies()
{
    #region Виды работ.Типы объектов
    References.Add(new EntityReference
    {
        ReferenceName = "Работы объектов",
        BaseEntity = typeof(Bars.Stkomleks.TypesWorkTypesObjects),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.WorkType != null && x.WorkType.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.WorkType != null && x.WorkType.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionWorksObjects>()
                .Where(x => x.WorkType != null && x.WorkType.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionWorksObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Единицы измерения и его наследники
private void RegisterUnitMeasureDependencies()
{
    #region Единицы измерения
    References.Add(new EntityReference
    {
        ReferenceName = "Работы объектов",
        BaseEntity = typeof(Bars.Stkomleks.UnitMeasure),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.UnutMeasure != null && x.UnutMeasure.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.UnutMeasure != null && x.UnutMeasure.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionWorksObjects>()
                .Where(x => x.UnutMeasure != null && x.UnutMeasure.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionWorksObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Спецификация объекта",
        BaseEntity = typeof(Bars.Stkomleks.UnitMeasure),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ObjectProducts>(x => x.UnitMeasure != null && x.UnitMeasure.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ObjectProducts>(x => x.UnitMeasure != null && x.UnitMeasure.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ObjectProducts>()
                .Where(x => x.UnitMeasure != null && x.UnitMeasure.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ObjectProducts),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Роли и его наследники
private void RegisterWorksRolesDependencies()
{
    #region Роли
    References.Add(new EntityReference
    {
        ReferenceName = "Специалисты объектов",
        BaseEntity = typeof(Bars.Stkomleks.WorksRoles),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionObjectSpecialists>(x => x.Role != null && x.Role.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionObjectSpecialists>(x => x.Role != null && x.Role.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionObjectSpecialists>()
                .Where(x => x.Role != null && x.Role.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionObjectSpecialists),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Виды работ и его наследники
private void RegisterWorksTypesDependencies()
{
    #region Виды работ
    References.Add(new EntityReference
    {
        ReferenceName = "Работы объектов",
        BaseEntity = typeof(Bars.Stkomleks.WorksTypes),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.Type != null && x.Type.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.CompositionWorksObjects>(x => x.Type != null && x.Type.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.CompositionWorksObjects>()
                .Where(x => x.Type != null && x.Type.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.CompositionWorksObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Виды работ.Типы объектов",
        BaseEntity = typeof(Bars.Stkomleks.WorksTypes),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.TypesWorkTypesObjects>(x => x.WorkType != null && x.WorkType.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.TypesWorkTypesObjects>(x => x.WorkType != null && x.WorkType.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.TypesWorkTypesObjects>()
                .Where(x => x.WorkType != null && x.WorkType.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.TypesWorkTypesObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
#region Заказы и его наследники
private void RegisterZakazDependencies()
{
    #region Заказы
    References.Add(new EntityReference
    {
        ReferenceName = "Заказы Объекты",
        BaseEntity = typeof(Bars.Stkomleks.Zakaz),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.ObjectsOrders>(x => x.Zakaz != null && x.Zakaz.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.ObjectsOrders>(x => x.Zakaz != null && x.Zakaz.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.ObjectsOrders>()
                .Where(x => x.Zakaz != null && x.Zakaz.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.ObjectsOrders),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Организации заказа",
        BaseEntity = typeof(Bars.Stkomleks.Zakaz),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrderOrganization>(x => x.Zakaz != null && x.Zakaz.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrderOrganization>(x => x.Zakaz != null && x.Zakaz.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrderOrganization>()
                .Where(x => x.Zakaz != null && x.Zakaz.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrderOrganization),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    References.Add(new EntityReference
    {
        ReferenceName = "Объекты",
        BaseEntity = typeof(Bars.Stkomleks.Zakaz),
        CheckAnyDependencesAsync = async id => await AnyAsync<Bars.Stkomleks.OrdersObjects>(x => x.Zakaz != null && x.Zakaz.Id == id),
        GetCountDependencesAsync = async id => await CountAsync<Bars.Stkomleks.OrdersObjects>(x => x.Zakaz != null && x.Zakaz.Id == id),
        GetDependenciesAsync = async id =>
        {
            return await GetAll<Bars.Stkomleks.OrdersObjects>()
                .Where(x => x.Zakaz != null && x.Zakaz.Id == id)
                .Select(x => new BarsUp.Abstractions.DataAccess.Dependence.DependencyInfo
                {
                    EntityType = typeof(Bars.Stkomleks.OrdersObjects),
                    Id = x.Id,
                    Display = "Идентификатор " + x.Id
                }).ToArrayMaybeAsync();
        },
        GetDescriptionDependencesAsync = null
    }
    );
    #endregion
}
#endregion
                
    }    
}

