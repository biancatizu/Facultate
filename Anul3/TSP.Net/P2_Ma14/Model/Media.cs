//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotosProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Media
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Media()
        {
            this.PersonsMedias = new HashSet<PersonsMedia>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime date { get; set; }
        public string location { get; set; }
        public string @event { get; set; }
        public string path { get; set; }
        public string type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonsMedia> PersonsMedias { get; set; }
    }
}
