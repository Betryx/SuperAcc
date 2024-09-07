﻿using Furniro.Domain.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniro.Application.DTOs.CategoryDTOs
{
    public class CategoryResponceDto
    {
        public string Name { get; set; }
        public byte[] CoverPhoto { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
