using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Laenutuskord
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime LaenutuseAlgus { get; set; }
        public DateTime LaenutuseLõpp { get; set; }
        public string LaenutatavEse { get; set; }
        public Employee Employee { get; set; }

    }
}
