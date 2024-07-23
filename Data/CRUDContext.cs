using Microsoft.EntityFrameworkCore;
using CRUD_Base.Models;

namespace CRUD_Base.Data
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
