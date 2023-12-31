using Firtmvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Firtmvc.Data{
    public class ApplicationDbcontext : DbContext{
        public ApplicationDbcontext()
        {
            
        }
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
        public DbSet<Daily> Daily { get; set;}
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set;}
        public DbSet<Firtmvc.Models.Employee> Employee { get; set; } = default!;
        
        
    }
}