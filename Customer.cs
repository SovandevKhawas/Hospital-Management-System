using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class Customer
    {
        public Customer()
        {
            PhFinCbDtls = new HashSet<PhFinCbDtl>();
        }

        public int IdNo { get; set; }
        public string Name { get; set; } = null!;
        public string? PhoneNo { get; set; }

        public virtual ICollection<PhFinCbDtl> PhFinCbDtls { get; set; }
    }
}
