using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class District
    {
        public District()
        {
            PatientRegistrations = new HashSet<PatientRegistration>();
        }

        public int IdNo { get; set; }
        public string Name { get; set; } = null!;
        public int StateIdNo { get; set; }

        public virtual ICollection<PatientRegistration> PatientRegistrations { get; set; }
    }
}
