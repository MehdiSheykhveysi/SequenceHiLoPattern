using System;
using System.Collections.Generic;

namespace SequenceHiloPattern.Entitties
{
    public class Product : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        //Navigation Property

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
