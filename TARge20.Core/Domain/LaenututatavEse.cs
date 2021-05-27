using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class LaenutatavEse
    {
        public Guid Id { get; set; }
        public string EsemeNimi { get; set; }
        public Laenutuskord Laenutuskord { get; set; }
    }
}
