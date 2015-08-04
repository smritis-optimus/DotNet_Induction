using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace WO.BusinessEntity
{
    public class WorkOrder
    {
        public int WONumber { get; set; }
        public string WOShortText { get; set; }
        public string WOLongText { get; set; }
        [XmlAttribute]
        public int action { get; set; }
        public List<Operation> Operations { get; set; }
       
        }
    }
