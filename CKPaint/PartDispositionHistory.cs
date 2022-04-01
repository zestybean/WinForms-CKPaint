﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPaint
{
    class PartDispositionHistory
    {
        public PartDispositionHistory()
        {
            InspectorName = "";
            PartNumber = "";
            JobNumber = "";
            ColorCode = "";
            ProductType = "";
            InspectorID = "";
            PaintMachine = "";
            PartProcess = "";
            WOID = "";
            WOIDRH = "";
            PartDefect = "";
            DPUCount = 0;
            PartDescription = "";
            PartDescriptionRH = "";
            PartDisposition = "";
            DispositionDate = DateTime.Now;
        }

        //ORM DB Definition 
        public string InspectorName { get; set; }
        public string PartNumber { get; set; } //
        public string JobNumber { get; set; } //
        public string ColorCode { get; set; } //
        public string ProductType { get; set; } //
        public string InspectorID { get; set; } //NEED IMP
        public string PaintMachine { get; set; } //NEED IMP
        public string PartProcess { get; set; }//HOw?
        public string WOID { get; set; }//
        public string WOIDRH { get; set; }//
        public string PartDefect { get; set; }//
        public Int16 DPUCount { get; set; }//
        public string PartDisposition { get; set; }
        public string PartDescription { get; set; }
        public string PartDescriptionRH { get; set; }
        public DateTime DispositionDate { get; set; }
    }
}
