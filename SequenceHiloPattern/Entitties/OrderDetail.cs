using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SequenceHiloPattern.Entitties
{
    public class OrderDetail : BaseEntity<int>
    {
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
