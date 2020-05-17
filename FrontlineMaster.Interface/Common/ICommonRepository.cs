
using FrontlineMaster.Entity.Hierarchy;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineMaster.Interface.Hierarchy
{
    public interface ICommonRepository
    {
        Task<IQueryable<CompanyEntity>> GetAllCompany();
        Task<IQueryable<SBUEntity>> GetAllSbu();
        Task<IQueryable<SBUEntity>> GetSbu(int companyId);
        Task<IQueryable<DesignationWithGroupEntity>> GetDesignations();
        Task<IQueryable<DesignationWithGroupEntity>> GetDesignations(int sbuId);
        Task<IQueryable<StateEntity>> GetStates(int companyId);
        Task<IQueryable<CityEntity>> GetCities(int stateId);
        Task<IQueryable<SpecialityEntity>> GetSpecialities(int companyId);
        Task<IQueryable<TownTypeEntity>> GetTownTypes(int companyId);
        Task<IQueryable<SecurityQuestionEntity>> GetSecurityQuestions();
        void Dispose();
    }
}
