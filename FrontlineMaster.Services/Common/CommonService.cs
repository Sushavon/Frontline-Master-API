using FrontlineMaster.Entity.Common;
using FrontlineMaster.Interface.Hierarchy;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineMaster.Services.Hierarchy
{
    public class CommonService : ICommonService
    {
        private ICommonRepository _hierarchyRepository = null;

        public CommonService(ICommonRepository hierarchyRepository)
        {
            _hierarchyRepository = hierarchyRepository;
        }
        public void Dispose()
        {
            if (_hierarchyRepository != null)
            {
                _hierarchyRepository.Dispose();
            }
        }
        public async Task<List<CompanyEntity>> GetAllCompany()
        {
            var result = await _hierarchyRepository.GetAllCompany();
            return result.ToList();
        }

        public async Task<List<SBUEntity>> GetAllSbu()
        {
            var result = await _hierarchyRepository.GetAllSbu();
            return result.ToList();
        }

        public async Task<List<SBUEntity>> GetSbu(int companyId)
        {
            var result = await _hierarchyRepository.GetSbu(companyId);
            return result.ToList();
        }

        public async Task<List<DesignationWithGroupEntity>> GetDesignations()
        {
            var result = await _hierarchyRepository.GetDesignations();
            return result.ToList();
        }

        public async Task<List<DesignationWithGroupEntity>> GetDesignations(int sbuId)
        {
            var result = await _hierarchyRepository.GetDesignations(sbuId);
            return result.ToList();
        }

        public async Task<List<StateEntity>> GetStates(int companyId)
        {
            var result = await _hierarchyRepository.GetStates(companyId);
            return result.ToList();
        }

        public async Task<List<CityEntity>> GetCities(int stateId)
        {
            var result = await _hierarchyRepository.GetCities(stateId);
            return result.ToList();
        }

        public async Task<List<SpecialityEntity>> GetSpecialities(int companyId)
        {
            var result = await _hierarchyRepository.GetSpecialities(companyId);
            return result.ToList();
        }

        public async Task<List<TownTypeEntity>> GetTownTypes(int companyId)
        {
            var result = await _hierarchyRepository.GetTownTypes(companyId);
            return result.ToList();
        }

        public async Task<List<SecurityQuestionEntity>> GetSecurityQuestions()
        {
            var result = await _hierarchyRepository.GetSecurityQuestions();
            return result.ToList();
        }

        public async Task<List<MemberEntity>> GetMembers()
        {
            var result = await _hierarchyRepository.GetMembers();
            return result.ToList();
        }

        public async Task<List<McrCategoryEntity>> GetMcrCategories(int desigId)
        {
            var result = await _hierarchyRepository.GetMcrCategories(desigId);
            return result.ToList();
        }

        public async Task<List<ZoneEntity>> GetZones(int sbuId)
        {
            var result = await _hierarchyRepository.GetZones(sbuId);
            return result.ToList();
        }

        public async Task<List<RegionEntity>> GetRegions(int zoneId)
        {
            var result = await _hierarchyRepository.GetRegions(zoneId);
            return result.ToList();
        }

        public async Task<List<AreaEntity>> GetAreas(int regionId)
        {
            var result = await _hierarchyRepository.GetAreas(regionId);
            return result.ToList();
        }

        public async Task<List<HeadquarterEntity>> GetHeadquarters(int headquarterId)
        {
            var result = await _hierarchyRepository.GetHeadquarters(headquarterId);
            return result.ToList();
        }

        public async Task<List<DropReasonEntity>> GetDropReasons()
        {
            var result = await _hierarchyRepository.GetDropReasons();
            return result.ToList();
        }

        public async Task<List<QualificationEntity>> GetQualifications(int specialityId)
        {
            var result = await _hierarchyRepository.GetQualifications(specialityId);
            return result.ToList();
        }

        public async Task<List<CodeValueEntity>> GetCodeValues(string typeCode)
        {
            var result = await _hierarchyRepository.GetCodeValues(typeCode);
            return result.ToList();
        }

        public async Task<List<MenuEntity>> GetMenuItems(int repId, string loginType)
        {
            var result = await _hierarchyRepository.GetMenuItems(repId, loginType);
            return result.ToList();
        }
    }
}
