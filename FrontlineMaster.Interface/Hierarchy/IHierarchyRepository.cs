
using FrontlineMaster.Entity.Hierarchy;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineMaster.Interface.Hierarchy
{
    public interface IHierarchyRepository
    {
        Task<IQueryable<CompanyEntity>> GetAllCompany();
        Task<IQueryable<SBUEntity>> GetAllSbu();
        Task<IQueryable<SBUEntity>> GetSbu(int companyId);
        Task<IQueryable<DesignationWithGroupEntity>> GetDesignations();
        Task<IQueryable<DesignationWithGroupEntity>> GetDesignations(int sbuId);
        void Dispose();
    }
}
