using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Töösuhe
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime TöösuhteAlgus { get; set; }
        public DateTime TöösuhteLõpp { get; set; }
        public int Koormus { get; set; }
        public Employee Employee { get; set; }

    }
}