using CRMAppAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimaryBusinessField
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SecondaryBusinessField> SecondaryBusinessFields { get; set; }
    }
}
