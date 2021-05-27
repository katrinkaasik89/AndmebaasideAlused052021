using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class PuhkuseTyyp
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimetus { get; set; }
       
        public DateTime DateAndTime { get; set; }
        public Puhkus puhkus { get; set; }
    }
}
