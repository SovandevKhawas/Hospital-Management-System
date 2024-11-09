using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class AnalyzerMaster
    {
        public int IdNo { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string BarcodeNo { get; set; } = null!;
    }
}
