using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExampleCodePortfolio.Models
{
    public class DbInitializer
    {
        public static void Initialize(ExamplesContext context)
        {
            context.Database.EnsureCreated();

            // Look for any examples.
            if (context.CodeExamples.Any())
            {
                return;   // DB has been seeded
            }

            var codeExamples = new CodeExample[]
            {
            new CodeExample{Title="Code Example 1", Description="Code example 1 description...", Url="url 1", ImageUrl="imageurl 1"},
            new CodeExample{Title="Code Example 2", Description="Code example 2 description...", Url="url 2", ImageUrl="imageurl 2"},
            new CodeExample{Title="Code Example 3", Description="Code example 3 description...", Url="url 3", ImageUrl="imageurl 3"},
            new CodeExample{Title="Code Example 4", Description="Code example 4 description...", Url="url 4", ImageUrl="imageurl 4"},
            new CodeExample{Title="Code Example 5", Description="Code example 5 description...", Url="url 5", ImageUrl="imageurl 5"},
            new CodeExample{Title="Code Example 6", Description="Code example 6 description...", Url="url 6", ImageUrl="imageurl 6"}
            };
            foreach (CodeExample ce in codeExamples)
            {
                context.CodeExamples.Add(ce);
            }
            context.SaveChanges();

        }
    }
}
