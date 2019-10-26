using CRMAppAPI.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMAppAPI.Data
{
    public class CRMSeeder
    {
        private readonly CRMContext _context;
        private readonly UserManager<User> _userManager;

        public CRMSeeder(CRMContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            _context.Database.EnsureCreated();

            User user = await _userManager.FindByNameAsync("admin");

            if (user == null)
            {
                user = new User()
                {
                    CompanyID = "admin@CRM",
                    UserName = "admin"
                };

                var result = await _userManager.CreateAsync(user, "P@ssw0rd");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create user in Seeding");
                }
            }

            //if (!_userManager.Users.Any())
            //{
            //    User user = new User()
            //    {
            //        CompanyID = "admin@CRM",
            //        UserName = "admin"
            //    };

            //    var result =  _userManager.CreateAsync(user, "P@ssw0rd").Result;
            //    if (result != IdentityResult.Success)
            //    {
            //        throw new InvalidOperationException("Could not create a new user in seeder");
            //    }
            //}

            if (!_context.Cities.Any())
            {
                _context.Cities.Add(new City
                {
                    Name = "Tel Aviv"
                });
                _context.Cities.Add(new City
                {
                    Name = "Petach Tiqwa"
                });
                _context.Cities.Add(new City
                {
                    Name = "Jerusalem"
                });

                _context.PrimaryBusinessFields.Add(new PrimaryBusinessField
                {
                    Name = "Hi-Tech",
                    SecondaryBusinessFields = new List<SecondaryBusinessField>()
                    {
                        new SecondaryBusinessField()
                        {
                            Name = "Software"

                        },
                        new SecondaryBusinessField()
                        {
                            Name = "QA"
                        },
                        new SecondaryBusinessField()
                        {
                            Name = "Communication"
                        },
                        new SecondaryBusinessField()
                        {
                            Name = "DevOps"
                        }
                    }
                });
            }

            _context.SaveChanges();
        }
    }
}
