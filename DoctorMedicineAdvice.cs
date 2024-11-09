using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class DoctorMedicineAdvice
    {
        public int RecId { get; set; }
        public int DoctorHeadId { get; set; }
        public int ItemId { get; set; }
        public string? MedicineAdvice { get; set; }

        public virtual DoctorPrescriptionHead DoctorHead { get; set; } = null!;
        public virtual PhItemHead Item { get; set; } = null!;
    }
}
