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
    
    public partial class Raste
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raste()
        {
            this.ShahidAmaliats = new HashSet<ShahidAmaliat>();
            this.Vaheds = new HashSet<Vahed>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Tozihat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShahidAmaliat> ShahidAmaliats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vahed> Vaheds { get; set; }
    }
}
