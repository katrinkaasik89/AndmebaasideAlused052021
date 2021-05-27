using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Haiguslehed
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime HaigusleheAlgus { get; set; }
        public DateTime HaigusleheLõpp { get; set; }
        public Employee Employee { get; set; }
    }
}