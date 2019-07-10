using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgiSistemiDAL
{
    public class ProjectContext :DbContext
    {
        public ProjectContext() : base("DilaraGOKSUcon")
        {
            Database.SetInitializer<ProjectContext>(new DropCreateDatabaseIfModelChanges<ProjectContext>());
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
