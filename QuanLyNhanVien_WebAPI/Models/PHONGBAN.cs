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
    
    public partial class PHONGBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONGBAN()
        {
            this.NHANVIEN_PHONGBAN = new HashSet<NHANVIEN_PHONGBAN>();
        }
    
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public string SoDienThoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_PHONGBAN> NHANVIEN_PHONGBAN { get; set; }
    }
}
