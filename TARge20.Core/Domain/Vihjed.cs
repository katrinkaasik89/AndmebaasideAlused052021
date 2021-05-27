﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Vihjed
    {
        [Key]
        public Guid Id { get; set; }

        public string Saaja { get; set; }
        public DateTime VihjeKpv { get; set; }

    }
}