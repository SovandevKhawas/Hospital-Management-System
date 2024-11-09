using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class CabinMaster
    {
        public CabinMaster()
        {
            IndoorCheckupAdviceDtls = new HashSet<IndoorCheckupAdviceDtl>();
            PatientAdmissionMasters = new HashSet<PatientAdmissionMaster>();
        }

        public int IdNo { get; set; }
        public int WardIdNo { get; set; }
        public string CabinNo { get; set; } = null!;
        public int? CabinTypeId { get; set; }

        public virtual BedCabinType? CabinType { get; set; }
        public virtual WardMaster WardIdNoNavigation { get; set; } = null!;
        public virtual ICollection<IndoorCheckupAdviceDtl> IndoorCheckupAdviceDtls { get; set; }
        public virtual ICollection<PatientAdmissionMaster> PatientAdmissionMasters { get; set; }
    }
}
