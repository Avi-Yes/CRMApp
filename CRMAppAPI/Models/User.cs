using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMAppAPI.Models
{
    public class User : IdentityUser
    {
        public string CompanyID { get; set; }
    }
}
