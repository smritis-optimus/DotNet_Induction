//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WO.DataEdmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operation
    {
        public int OpID { get; set; }
        public string OpDesc { get; set; }
        public string OpenStatus { get; set; }
        public Nullable<System.DateTime> OpCompletionDate { get; set; }
        public Nullable<int> WONumber { get; set; }
    
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
