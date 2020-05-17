
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
        void Dispose();
    }
}
