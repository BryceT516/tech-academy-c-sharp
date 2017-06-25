using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ExampleCodePortfolio.Models
{
    public class ExamplesContext : DbContext
    {
        public ExamplesContext(DbContextOptions<ExamplesContext> options)
            : base(options)
        {
        }

        public DbSet<CodeExample> CodeExamples { get; set; }
    }
}
