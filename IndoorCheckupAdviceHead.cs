using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class IndoorCheckupAdviceHead
    {
        public IndoorCheckupAdviceHead()
        {
            IndoorCheckupAdviceDtls = new HashSet<IndoorCheckupAdviceDtl>();
            IndoorCheckupAdviceInfos = new HashSet<IndoorCheckupAdviceInfo>();
            IndoorCheckupAdviceItemParameters = new HashSet<IndoorCheckupAdviceItemParameter>();
            IndoorCheckupAdviceLabParameters = new HashSet<IndoorCheckupAdviceLabParameter>();
            IndoorCheckupAdviceTestsParameters = new HashSet<IndoorCheckupAdviceTestsParameter>();
            IpdfeesEntryHeads = new HashSet<IpdfeesEntryHead>();
            IpdfeesEntryLabDetails = new HashSet<IpdfeesEntryLabDetail>();
            IpdfeesEntryLabs = new HashSet<IpdfeesEntryLab>();
            IpdfeesEntryServices = new HashSet<IpdfeesEntryService>();
            IpdfeesEntryTestParameters = new HashSet<IpdfeesEntryTestParameter>();
            IpdfeesEntryTestParametersDetails = new HashSet<IpdfeesEntryTestParametersDetail>();
            Otdetails = new HashSet<Otdetail>();
        }

        public int IdNo { get; set; }
        public string RefNo { get; set; } = null!;
        public int PatientAdmissionMasterIdNo { get; set; }
        public string? Remarks { get; set; }
        public string IsFeesEntryMadeYn { get; set; } = null!;
        public int? DoctorId { get; set; }

        public virtual DoctorMaster? Doctor { get; set; }
        public virtual PatientAdmissionMaster PatientAdmissionMasterIdNoNavigation { get; set; } = null!;
        public virtual ICollection<IndoorCheckupAdviceDtl> IndoorCheckupAdviceDtls { get; set; }
        public virtual ICollection<IndoorCheckupAdviceInfo> IndoorCheckupAdviceInfos { get; set; }
        public virtual ICollection<IndoorCheckupAdviceItemParameter> IndoorCheckupAdviceItemParameters { get; set; }
        public virtual ICollection<IndoorCheckupAdviceLabParameter> IndoorCheckupAdviceLabParameters { get; set; }
        public virtual ICollection<IndoorCheckupAdviceTestsParameter> IndoorCheckupAdviceTestsParameters { get; set; }
        public virtual ICollection<IpdfeesEntryHead> IpdfeesEntryHeads { get; set; }
        public virtual ICollection<IpdfeesEntryLabDetail> IpdfeesEntryLabDetails { get; set; }
        public virtual ICollection<IpdfeesEntryLab> IpdfeesEntryLabs { get; set; }
        public virtual ICollection<IpdfeesEntryService> IpdfeesEntryServices { get; set; }
        public virtual ICollection<IpdfeesEntryTestParameter> IpdfeesEntryTestParameters { get; set; }
        public virtual ICollection<IpdfeesEntryTestParametersDetail> IpdfeesEntryTestParametersDetails { get; set; }
        public virtual ICollection<Otdetail> Otdetails { get; set; }
    }
}
