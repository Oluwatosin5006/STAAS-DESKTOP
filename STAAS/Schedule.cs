//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STAAS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public System.DateTime Resumption_Time { get; set; }
        public System.DateTime Closing_Time { get; set; }
        public string Workdays { get; set; }
        public string Description { get; set; }
    }
}
