//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySinhVien5ToT
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOAI_TIEU_CHUAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_TIEU_CHUAN()
        {
            this.TIEU_CHUAN = new HashSet<TIEU_CHUAN>();
        }
    
        public bool MaLoaiTieuChuan { get; set; }
        public string TenLoaiTieuChuan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIEU_CHUAN> TIEU_CHUAN { get; set; }
    }
}
