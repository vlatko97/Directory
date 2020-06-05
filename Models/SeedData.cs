using Directory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directory.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DirectoryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DirectoryContext>>()))
            {
                // Look for any movies.
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }

                context.Person.AddRange(
                    new Person
                    {
                        Name = "Vlatko",
                        Surname = "Kocev",
                        Address = "s.Oraovica, Radovis",
                        Email = "vlatko_kocev@yahoo.com",
                        PhoneNumber = "070123456"
                    },

                    new Person
                    {
                        Name = "Ivana",
                        Surname = "Jovanova",
                        Address = "Moskovska 25, Skopje",
                        Email = "ivana.jovanova@gmail.com",
                        PhoneNumber = "+38978999777"
                    },

                    new Person
                    {
                        Name = "Goran",
                        Surname = "Todorov",
                        Address = "Goce Delcev 2, Bitola",
                        Email = "goran-todorov@outlook.com",
                        PhoneNumber = "075570057"
                    },

                    new Person
                    {
                        Name = "Ilija",
                        Surname = "Aleksov",
                        Address = "Pitu Guli 8, Ohrid",
                        Email = "",
                        PhoneNumber = "071 555 678"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
