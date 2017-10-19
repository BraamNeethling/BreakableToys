using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersistantDictionary.Models;

namespace PersistantDictionary.DAL
{
    public class TableInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TableContext>
    {
        protected override void Seed(TableContext context)
        {
            var students = new List<Student>
            {
                new Student {FirstName = "Carson", LastName = "Alexander"},
                new Student {FirstName = "Meredith", LastName = "Alonso"},
                new Student {FirstName = "Arturo", LastName = "Anand"},
                new Student {FirstName = "Gytis", LastName = "Barzdukas"},
                new Student {FirstName = "Yan", LastName = "Li"},
                new Student {FirstName = "Peggy", LastName = "Justice"},
                new Student {FirstName = "Laura", LastName = "Norman"},
                new Student {FirstName = "Nino", LastName = "Olivetto"}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}