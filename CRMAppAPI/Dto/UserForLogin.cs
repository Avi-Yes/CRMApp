using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMAppAPI.Dto
{
    public class UserForLogin
    {
        [Required]
        //[RegularExpression(@"(\w|\d){1,25}")]
        public string CompanyID { get; set; }
        [Required]
        //[RegularExpression(@"(\w|\d){1,25}")]
        public string UserName { get; set; }
        [Required]
        //[RegularExpression(@"(\w|\d){1,25}")]
        public string Password { get; set; }
    }
}
