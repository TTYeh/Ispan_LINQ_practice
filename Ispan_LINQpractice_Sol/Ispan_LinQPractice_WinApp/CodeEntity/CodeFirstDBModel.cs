using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan_LinQPractice_WinApp.CodeEntity
{
    public class CodeFirstDBModel:DbContext
    {
        public CodeFirstDBModel() : base("CodeFirstConnectionString") { }
        public DbSet<Member> Member { get; set; }
        public DbSet<City> City { get; set; }
    }
}
