using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SequenceHiloPattern.Entitties
{
    public class ProductGallery : BaseEntity<int>
    {
        public string Path { get; set; }
        public bool IsDefault { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
