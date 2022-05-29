
using SSManagement.Data;
using SSManagment.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SSManagment.Data.Seed
{
    public class SeedData
    {
        public static void Seed(SSContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Universities.Any())
            {
                var universties = new List<University>
                {
                    new University{Name = "Minya"},
                    new University{ Name ="Cairo"}
                };

                context.Universities.AddRange(universties);
                context.SaveChanges();

            }

        }
    }
}
