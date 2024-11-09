using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class AnesthesiologistMaster
    {
        public AnesthesiologistMaster()
        {
            Otdetails = new HashSet<Otdetail>();
        }

        public int IdNo { get; set; }
        public string Name { get; set; } = null!;
        public string RegistrationNo { get; set; } = null!;
        public string? MobileNo { get; set; }
        public string? YearOfPassing { get; set; }

        public virtual ICollection<Otdetail> Otdetails { get; set; }
    }
}
