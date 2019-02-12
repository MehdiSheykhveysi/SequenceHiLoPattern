using System;
using System.Collections.Generic;

namespace SequenceHiloPattern.Entitties
{
    public class Product:BaseEntity<int>
    {
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        //Navigation Property

        public ICollection<Category> Categories { get; set; }
    }
}
