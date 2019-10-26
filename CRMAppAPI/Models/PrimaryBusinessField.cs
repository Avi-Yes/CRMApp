using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMAppAPI.Models
{
    public class PrimaryBusinessField
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SecondaryBusinessField> SecondaryBusinessFields { get; set; }
    }
}
