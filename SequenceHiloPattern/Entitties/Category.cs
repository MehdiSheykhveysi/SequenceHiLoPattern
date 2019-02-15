using System;
using System.Collections.Generic;

namespace SequenceHiloPattern.Entitties
{
    public class Category : BaseEntity<Guid>
    {
        public string Title { get; set; }

        //Navigation Property

        
        public ICollection<Product> Products { get; set; }
    }
}
