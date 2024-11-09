using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class Hsn
    {
        public int IdNo { get; set; }
        public string HsnCode { get; set; } = null!;
        public int? CgstAcCodePur { get; set; }
        public int? SgstAcCodePur { get; set; }
        public int? IgstAcCodePur { get; set; }
        public decimal? CgstPur { get; set; }
        public decimal? SgstPur { get; set; }
        public decimal? IgstPur { get; set; }
        public int? CgstAcCodeSal { get; set; }
        public int? SgstAcCodeSal { get; set; }
        public int? IgstAcCodeSal { get; set; }
        public decimal? CgstSal { get; set; }
        public decimal? SgstSal { get; set; }
        public decimal? IgstSal { get; set; }
    }
}
