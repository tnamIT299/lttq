//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pets.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThuCung
    {
        public string MaDon { get; set; }
        public string TenThuCung { get; set; }
        public string ChungLoai { get; set; }
        public Nullable<int> CanNang { get; set; }
        public DateTime NgayNhan { get; set; }
        public string TinhTrang { get; set; }
        public decimal Phi { get; set; }
        public int MaDV { get; set; }
        public Nullable<int> SoNgay { get; set; }
    
        public virtual DichVu DichVu { get; set; }
    }
}