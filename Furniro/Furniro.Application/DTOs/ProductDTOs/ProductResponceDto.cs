using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniro.Application.DTOs.ProductDTOs
{
    public class ProductResponceDto
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? Discount { get; set; }
        public int Quality { get; set; }
        public bool? MarkAsNew { get; set; }
        public byte[] CoverPhoto { get; set; }
        public List<byte[]> AdditionalPhotos { get; set; }
        public IEnumerable<string> Sizes { get; set; }
        public IEnumerable<string> Colors { get; set; }
        public Guid CategoryId { get; set; }
    }
}
