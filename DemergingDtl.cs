using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class DemergingDtl
    {
        public int RecId { get; set; }
        public int HeadIdNo { get; set; }
        public string DocNo { get; set; } = null!;
        public DateTime DocDate { get; set; }
        public int ItemId { get; set; }
        public string BatchNo { get; set; } = null!;
        public string ExpDate { get; set; } = null!;
        public int Qty { get; set; }
        public decimal? Mrp { get; set; }
        public string? ReasonsForDemerging { get; set; }

        public virtual DemergingHead HeadIdNoNavigation { get; set; } = null!;
        public virtual PhItemHead Item { get; set; } = null!;
    }
}
