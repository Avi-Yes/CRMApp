using CRMAppAPI.Models;
using System.Collections.Generic;

namespace CRMAppAPI.Data
{
    public interface ICRMRepository
    {
        IEnumerable<City> GetCities();
        IEnumerable<PrimaryBusinessField> GetPrimaryBusinessFields();
        public bool SaveAll();
    }
}