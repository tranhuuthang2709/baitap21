//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace baitap21.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LopSH
    {
        public string maLSH { get; set; }
        public string tenLSH { get; set; }
        public string manganh { get; set; }
        public Nullable<int> SISO { get; set; }
        public Nullable<int> SLTT { get; set; }
        public string Makhoa { get; set; }
        public string maGVCN { get; set; }
        public Nullable<int> SLNam { get; set; }
        public string status { get; set; }
        public string ghichu { get; set; }
        public Nullable<int> khoahoc { get; set; }
        public string maloptruong { get; set; }
        public string maloppho { get; set; }
        public string mabithu { get; set; }
        public Nullable<int> HKhienhanh { get; set; }
        public string heDT0 { get; set; }
    
        public virtual Giaovien Giaovien { get; set; }
        public virtual LSH_SV LSH_SV { get; set; }
    }
}
