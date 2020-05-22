using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MyPhotosWebApp.Models
{
    [DataContract(IsReference = true)]
    public class PersonsDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonsDTO()
        {
            this.PersonsMedias = new HashSet<PersonsMediaDTO>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string personName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<PersonsMediaDTO> PersonsMedias { get; set; }
    }
}
