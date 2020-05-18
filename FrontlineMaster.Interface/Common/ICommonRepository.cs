
using FrontlineMaster.Entity.Common;
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
        Task<IQueryable<MemberEntity>> GetMembers();
        Task<IQueryable<McrCategoryEntity>> GetMcrCategories(int desigId);
        Task<IQueryable<ZoneEntity>> GetZones(int sbuId);
        Task<IQueryable<RegionEntity>> GetRegions(int zoneId);
        Task<IQueryable<AreaEntity>> GetAreas(int regionId);
        Task<IQueryable<HeadquarterEntity>> GetHeadquarters(int headquarterId);
        void Dispose();
    }
}
