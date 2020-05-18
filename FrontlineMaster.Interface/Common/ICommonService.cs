using FrontlineMaster.Entity.Common;
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
        Task<List<MemberEntity>> GetMembers();
        Task<List<McrCategoryEntity>> GetMcrCategories(int desigId);
        Task<List<ZoneEntity>> GetZones(int sbuId);
        Task<List<RegionEntity>> GetRegions(int zoneId);
        Task<List<AreaEntity>> GetAreas(int regionId);
        Task<List<HeadquarterEntity>> GetHeadquarters(int headquarterId);
        Task<List<DropReasonEntity>> GetDropReasons();
        Task<List<QualificationEntity>> GetQualifications(int specialityId);
        Task<List<CodeValueEntity>> GetCodeValues(string typeCode);
    }
}
