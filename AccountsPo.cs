using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class AccountsPo
    {
        public long IdNo { get; set; }
        public int AcCode { get; set; }
        public int? PartyCode { get; set; }
        public string? ModuleName { get; set; }
        public int? DocId { get; set; }
        public string? DocNo { get; set; }
        public DateTime? DocDate { get; set; }
        public string? DrCr { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int IdentifierId { get; set; }
        public string? Narration { get; set; }
        public string? ChequeNo { get; set; }
        public string? PatientRegNo { get; set; }
        public string? PatientType { get; set; }
        public int? CustomerCode { get; set; }
    }
}
