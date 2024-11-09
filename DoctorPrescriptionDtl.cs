using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class DoctorPrescriptionDtl
    {
        public int RecId { get; set; }
        public int? HeadIdNo { get; set; }
        public int? LabMasterIdNo { get; set; }

        public virtual DoctorPrescriptionHead? HeadIdNoNavigation { get; set; }
        public virtual LabMaster? LabMasterIdNoNavigation { get; set; }
    }
}
