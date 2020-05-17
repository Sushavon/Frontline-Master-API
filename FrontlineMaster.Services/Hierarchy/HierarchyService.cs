using FrontlineMaster.Entity.Hierarchy;
using FrontlineMaster.Interface.Hierarchy;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineMaster.Services.Hierarchy
{
    public class HierarchyService : IHierarchyService
    {
        private IHierarchyRepository _hierarchyRepository = null;

        public HierarchyService(IHierarchyRepository hierarchyRepository)
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
    }
}
