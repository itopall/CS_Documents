//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _01_DbFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personel_ConstraintTest
    {
        public int Id { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string NameSurname { get; set; }
        public string GSM { get; set; }
        public string TCKNO { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual Department_ConstraintTest Department_ConstraintTest { get; set; }
    }
}
