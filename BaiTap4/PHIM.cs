//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiTap4
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIM
    {
        public string MADON { get; set; }
        public string TENPHIM { get; set; }
        public string QUOCGIA { get; set; }
        public string THELOAI { get; set; }
        public DateTime NGAYCONGCHIEU { get; set; }
        public int TUOIQUYDINH { get; set; }
        public int MADINHDANG { get; set; }
        public double GIA { get; set; }
    
        public virtual DINHDANGPHIM DINHDANGPHIM { get; set; }
    }
}