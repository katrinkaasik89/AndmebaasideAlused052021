using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Ligipääsuluba
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime LoaAlgus { get; set; }
        public DateTime LoaLõpp { get; set; }
        public string LigipääsuTyyp { get; set; }
        public Employee Employee { get; set; }

    }
}