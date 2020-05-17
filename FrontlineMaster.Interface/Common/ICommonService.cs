using FrontlineMaster.Entity.Hierarchy;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineMaster.Interface.Hierarchy
{

    public interface ICommonService
    {
        Task<List<CompanyEntity>> GetAllCompany();
        Task<List<SBUEntity>> GetAllSbu();
        Task<List<SBUEntity>> GetSbu(int companyId);
        Task<List<DesignationWithGroupEntity>> GetDesignations();
        Task<List<DesignationWithGroupEntity>> GetDesignations(int sbuId);
        Task<List<StateEntity>> GetStates(int companyId);
        Task<List<CityEntity>> GetCities(int stateId);
        Task<List<SpecialityEntity>> GetSpecialities(int companyId);
        Task<List<TownTypeEntity>> GetTownTypes(int companyId);
        Task<List<SecurityQuestionEntity>> GetSecurityQuestions();
    }
}
