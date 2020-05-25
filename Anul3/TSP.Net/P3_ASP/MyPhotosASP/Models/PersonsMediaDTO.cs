using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MyPhotosASP.Models
{
    public class PersonsMediaDTO
    {
        [DataMember]
        public int MediaId { get; set; }
        [DataMember]
        public int PersonsId { get; set; }
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public virtual MediaDTO Media { get; set; }
        [DataMember]
        public virtual PersonsDTO Person { get; set; }
    }
}
