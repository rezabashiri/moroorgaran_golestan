//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Golestane_Shohada.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shahrestan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shahrestan()
        {
            this.Bakhshes = new HashSet<Bakhsh>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public Nullable<int> IDOstan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bakhsh> Bakhshes { get; set; }
        public virtual Ostan Ostan { get; set; }
    }
}
