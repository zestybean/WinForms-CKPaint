using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPaint
{
    class PartInlineHistory
    {
        public PartInlineHistory()
        {
            JobNumber = "";
            WOID = "";
            WOIDRH = "";
            PartNumber = "";
            PartNumberRH = "";
            ColorCode = "";
            SetNumber = "";
            PartRework = 0;
            RackCode = "";
            ProductType = "";
            PaintDate = DateTime.Now;
            PaintStation = "";
        }

        public string JobNumber { get; set; }
        public string WOID { get; set; }
        public string WOIDRH { get; set; }
        public string PartNumber { get; set; }
        public string PartNumberRH { get; set; }
        public string ColorCode { get; set; }
        public string SetNumber { get; set; }
        public Int16 PartRework { get; set; }
        public string RackCode { get; set; }
        public string ProductType { get; set; }
        public DateTime PaintDate { get; set; }
        public string PaintStation { get; set; }
    }
}
