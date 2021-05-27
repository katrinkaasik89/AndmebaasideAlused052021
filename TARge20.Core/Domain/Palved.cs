using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Palved
    {
        [Key]
        public Guid Id { get; set; }

        public string Saaja { get; set; }
        public string Saatja { get; set; }
        public DateTime PalveKpv { get; set; }

    }
}
