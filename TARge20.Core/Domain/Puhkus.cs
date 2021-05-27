using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Puhkus
    {
        
        public Guid Id { get; set; }

        public string puhkuseTyyp { get; set; }
        public DateTime puhkuseAlgus { get; set; }
        public DateTime puhkuseLõpp { get; set; }
        public Employee Employee { get; set; }

    }
}