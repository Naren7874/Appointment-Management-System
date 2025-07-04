﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Core.Entities
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }


        // Navigation Properties
        public ICollection<Doctor> Doctors { get; set; }
        public List<CategoryHospital> Hospitals { get; set; }
    }
}
