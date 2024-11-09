using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class DoctorMaster
    {
        public DoctorMaster()
        {
            IndoorCheckupAdviceHeads = new HashSet<IndoorCheckupAdviceHead>();
            IpdadvanceCollections = new HashSet<IpdadvanceCollection>();
            OtdetailAsstDoctors = new HashSet<Otdetail>();
            OtdetailDoctors = new HashSet<Otdetail>();
            PatientGeneralCheckups = new HashSet<PatientGeneralCheckup>();
            PatientRegistrations = new HashSet<PatientRegistration>();
            PrescribedMedicines = new HashSet<PrescribedMedicine>();
            SummarizeTestResults = new HashSet<SummarizeTestResult>();
        }

        public int DoctorId { get; set; }
        public string? DoctorName { get; set; }
        public string? SignPath { get; set; }
        public string? Mobile { get; set; }
        public string? RegistrationNo { get; set; }
        public string? Email { get; set; }
        public string? YearOfPassing { get; set; }

        public virtual ICollection<IndoorCheckupAdviceHead> IndoorCheckupAdviceHeads { get; set; }
        public virtual ICollection<IpdadvanceCollection> IpdadvanceCollections { get; set; }
        public virtual ICollection<Otdetail> OtdetailAsstDoctors { get; set; }
        public virtual ICollection<Otdetail> OtdetailDoctors { get; set; }
        public virtual ICollection<PatientGeneralCheckup> PatientGeneralCheckups { get; set; }
        public virtual ICollection<PatientRegistration> PatientRegistrations { get; set; }
        public virtual ICollection<PrescribedMedicine> PrescribedMedicines { get; set; }
        public virtual ICollection<SummarizeTestResult> SummarizeTestResults { get; set; }
    }
}
