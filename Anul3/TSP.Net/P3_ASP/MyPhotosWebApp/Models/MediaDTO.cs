using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApp.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public class MediaDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MediaDTO()
        {
            this.PersonsMedias = new HashSet<PersonsMediaDTO>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public System.DateTime date { get; set; }
        [DataMember]
        public string location { get; set; }
        [DataMember]
        public string @event { get; set; }
        [DataMember]
        public string path { get; set; }
        [DataMember]
        public string type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<PersonsMediaDTO> PersonsMedias { get; set; }
    }
}
