using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class DoctorPrescriptionHead
    {
        public DoctorPrescriptionHead()
        {
            DoctorMedicineAdvices = new HashSet<DoctorMedicineAdvice>();
            DoctorPrescriptionDtls = new HashSet<DoctorPrescriptionDtl>();
            LabFeesEntryHeads = new HashSet<LabFeesEntryHead>();
        }

        public int Id { get; set; }
        public string? RegNo { get; set; }
        public int? UnitId { get; set; }
        public int? DoctorId { get; set; }
        public string? DescriptionOfDisease { get; set; }
        public string? MedicineAdvice { get; set; }
        public string? PrescriptionNo { get; set; }
        public DateTime? PrescriptionDate { get; set; }
        public string? ActionTaken { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? GeneralCheckupId { get; set; }
        public DateTime? ReVisitDate { get; set; }

        public virtual PatientGeneralCheckup? GeneralCheckup { get; set; }
        public virtual ICollection<DoctorMedicineAdvice> DoctorMedicineAdvices { get; set; }
        public virtual ICollection<DoctorPrescriptionDtl> DoctorPrescriptionDtls { get; set; }
        public virtual ICollection<LabFeesEntryHead> LabFeesEntryHeads { get; set; }
    }
}
