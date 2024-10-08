﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public int PackageId { get; set; }
        public ICollection<Package> Packages { get; set; }
        [Required]
        public bool ContainsAlcohol { get; set; }
        [Required]
        public string Picture { get; set; }
    }
}
