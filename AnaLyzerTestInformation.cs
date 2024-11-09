using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class AnaLyzerTestInformation
    {
        public int IdNo { get; set; }
        public int? AnalyzerMasterIdNo { get; set; }
        public string? BarcodeNo { get; set; }
        public int? TestIdNo { get; set; }
        public string? TestCode { get; set; }
        public int? DoctorPrescriptionIdNo { get; set; }
        public string? DoctorPrescriptionNo { get; set; }
        public DateTime? DoctorPrescriptionDate { get; set; }
        public string? PatientRegNo { get; set; }
        public string? TestResult { get; set; }
        public string? RecordStatus { get; set; }
        public string? RejectionReason { get; set; }
    }
}
