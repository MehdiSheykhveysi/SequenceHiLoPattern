using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SequenceHiloPattern.Entitties
{
    public class Product : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal Price { get; set; }

        //Navigation Property
        public ICollection<ProductGallery> ProductGalleries { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

    }
}
