using CRMAppAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMAppAPI.Data
{
    public class CRMContext : IdentityDbContext<User>
    {
        public CRMContext(DbContextOptions<CRMContext> options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<PrimaryBusinessField> PrimaryBusinessFields { get; set; }

    }
}
