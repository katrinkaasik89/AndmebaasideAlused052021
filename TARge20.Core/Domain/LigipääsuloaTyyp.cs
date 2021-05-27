using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class LigipääsuloaTyyp
    {
        public Guid Id { get; set; }
        public string Ligipääs { get; set; }
        public Ligipääsuluba Ligipääsuluba { get; set; }

    }
}
