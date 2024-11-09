using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class BedMaster
    {
        public BedMaster()
        {
            IndoorCheckupAdviceDtls = new HashSet<IndoorCheckupAdviceDtl>();
            Otdetails = new HashSet<Otdetail>();
            PatientAdmissionMasters = new HashSet<PatientAdmissionMaster>();
        }

        public int IdNo { get; set; }
        public string BedNo { get; set; } = null!;
        public int WardIdNo { get; set; }
        public int? BedTypeId { get; set; }

        public virtual BedCabinType? BedType { get; set; }
        public virtual WardMaster WardIdNoNavigation { get; set; } = null!;
        public virtual ICollection<IndoorCheckupAdviceDtl> IndoorCheckupAdviceDtls { get; set; }
        public virtual ICollection<Otdetail> Otdetails { get; set; }
        public virtual ICollection<PatientAdmissionMaster> PatientAdmissionMasters { get; set; }
    }
}
