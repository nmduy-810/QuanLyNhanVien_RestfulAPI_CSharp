//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanVien_WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN_PHONGBAN
    {
        public int MaNV_PB { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public Nullable<int> MaNhanVien { get; set; }
        public Nullable<int> MaPhongBan { get; set; }
        public Nullable<int> MaChucVu { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}
