using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class DoctorUnit
    {
        public DoctorUnit()
        {
            PatientGeneralCheckups = new HashSet<PatientGeneralCheckup>();
            PatientRegistrations = new HashSet<PatientRegistration>();
        }

        public int DoctorUnitId { get; set; }
        public string? DoctorUnitName { get; set; }

        public virtual ICollection<PatientGeneralCheckup> PatientGeneralCheckups { get; set; }
        public virtual ICollection<PatientRegistration> PatientRegistrations { get; set; }
    }
}
