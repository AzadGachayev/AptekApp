//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aptek_Program.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicineToTag
    {
        public int ID { get; set; }
        public Nullable<int> MedicineID { get; set; }
        public Nullable<int> TagID { get; set; }
    
        public virtual Medicines Medicines { get; set; }
        public virtual Tags Tags { get; set; }
    }
}