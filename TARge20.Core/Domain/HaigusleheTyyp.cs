using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class HaigusleheTyyp
    {
        
        public Guid Id { get; set; }
        public string Nimetus { get; set; }
        public Haiguslehed Haiguslehed { get; set; }
    }
}
