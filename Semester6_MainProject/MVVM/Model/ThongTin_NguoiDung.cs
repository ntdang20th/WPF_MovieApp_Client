//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semester6_MainProject.MVVM.Model
{
    using System;
    using System.Collections.Generic;
    using Semester6_MainProject.MVVM.ViewModel;

    public partial class ThongTin_NguoiDung : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTin_NguoiDung()
        {
            this.NguoiDungs = new HashSet<NguoiDung>();
        }

        private string _Ho_HoLot;
        private string _Ten;
        private Nullable<System.DateTime> _NgaySinh;
        private string _Email;


        public int Id { get; set; }
        public string Ho_HoLot { get => _Ho_HoLot; set { _Ho_HoLot = value; OnPropertyChanged(); } }
        public string Ten { get => _Ten; set { _Ten = value; OnPropertyChanged(); } }
        public Nullable<System.DateTime> NgaySinh { get => _NgaySinh; set { _NgaySinh = value; OnPropertyChanged(); } }
        public string Email { get => _Email; set { _Email = value; OnPropertyChanged(); } }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
