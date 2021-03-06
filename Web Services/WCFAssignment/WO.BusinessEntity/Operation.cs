﻿using System.Xml.Serialization;
namespace WO.BusinessEntity
{
    public class Operation
    {
        public int OpID { get; set; }
        public string OpDesc { get; set; }
        public string OpStatus { get; set; }
        public Nullable<System.DateTime> OpCompletionDate { get; set; }
        [XmlAttribute]
        public int action { get; set; }
    }
}
