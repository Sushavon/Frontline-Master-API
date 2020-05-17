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
    }
}
