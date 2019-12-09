using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceHiloPattern.Entitties
{
    public class Author : BaseEntity<int>
    {

        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }

    public class Address : BaseEntity<int>
    {
        public string Description { get; set; }
    }
}
