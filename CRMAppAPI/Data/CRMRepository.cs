using CRMAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMAppAPI.Data
{
    public class CRMRepository : ICRMRepository
    {
        private readonly CRMContext _context;

        public CRMRepository(CRMContext context)
        {
            _context = context;
        }

        public IEnumerable<City> GetCities()
        {
            return _context.Cities.OrderBy(c => c.Name).ToList();
        }

        public IEnumerable<PrimaryBusinessField> GetPrimaryBusinessFields()
        {
            return _context.PrimaryBusinessFields.Include(o => o.SecondaryBusinessFields).ToList();
        }
        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
