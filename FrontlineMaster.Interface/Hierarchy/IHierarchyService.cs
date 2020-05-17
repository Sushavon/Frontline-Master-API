using FrontlineMaster.Entity.Hierarchy;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineMaster.Interface.Hierarchy
{

    public interface IHierarchyService
    {
        Task<List<CompanyEntity>> GetAllCompany();
        Task<List<SBUEntity>> GetAllSbu();
        Task<List<SBUEntity>> GetSbu(int companyId);
    }
}
