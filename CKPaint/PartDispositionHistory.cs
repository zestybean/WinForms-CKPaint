using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPaint
{
    class PartDispositionHistory
    {
        //ORM DB Definition 
        public string InspectorName { get; set; }
        public string PartNumber { get; set; } //
        public string JobNumber { get; set; } //
        public string PartColor { get; set; } //
        public string PartType { get; set; } //
        public string InspectorID { get; set; } //NEED IMP
        public string Machine { get; set; } //NEED IMP
        public string PartProcess { get; set; }//HOw?
        public string WOID { get; set; }//
        public string PartDefect { get; set; }//
        public Int16 DPUCount { get; set; }//
        public string PartDisposition { get; set; }
        public string PartDescription { get; set; }
        public DateTime DispositionDate { get; set; }
    }
}
