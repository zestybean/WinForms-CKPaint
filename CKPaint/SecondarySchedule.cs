using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPaint
{
    public class SecondarySchedule
    {
        //ORM DB Definition 
        public Decimal ScheduleID { get; set; }
        public string JobNumber { get; set; }
        public string SetNumber { get; set; }
        public string PartNumber { get; set; }
        public string PartNumberRH { get; set; }
        public string ColorCode { get; set; }
        public Int16 Primer { get; set; }
        public string ProductType { get; set; }
        public string ProductPlatform { get; set; }
        public string Description { get; set; }
        public string DescriptionRH { get; set; }
        public string RackCode { get; set; }
        public string RackPosition { get; set; }
        public string RackPositionRH { get; set; }
        public DateTime AssembleDate { get; set; }
        public DateTime PaintDate { get; set; }
        public string PaintBlock { get; set; }
        public string WOID { get; set; }
        public string WOIDRH { get; set; }
        public DateTime ShipDate { get; set; }
        public DateTime ImportDate { get; set; }

    }
}
