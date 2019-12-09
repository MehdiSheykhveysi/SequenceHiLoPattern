using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceHiloPattern.Entitties
{
    public class Order : BaseEntity<int>
    {
        public string Title { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
