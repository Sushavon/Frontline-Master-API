using FrontlineMaster.Entity.Hierarchy;
using Microsoft.EntityFrameworkCore;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class DBContext : DbContext
    {
        public virtual DbSet<CompanyEntity> CompanyEntityListSP { get; set; }

    }
}
