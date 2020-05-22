using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotosWebApp.Models;
using ServiceReferenceMyPhotos;

namespace MyPhotosWebApp
{
    public class IndexModel : PageModel
    {
        MyPhotosServiceClient psc = new MyPhotosServiceClient();
        public List<MediaDTO> Medias { get; set; }
        public List<PersonsDTO> Persons { get; set; }
        public IndexModel()
        {
            Medias = new List<MediaDTO>();
            Persons = new List<PersonsDTO>();
        }
        public async Task OnGetAsync()
        {
            var medias = await psc.getAllMediaAsync();
            foreach (var item in medias)
            {
                // Trebuia folosit AutoMapper. Transform Post in PostDTO
                MediaDTO md = new MediaDTO();
                md.Id = item.Id;
                md.name = item.name;
                md.description = item.description;
                md.date = item.date;
                md.location = item.location;
                md.@event = item.@event;
                md.path = item.path;
                md.type = item.type;

                var persons = await psc.getPersonsByMediaNameAsync(md.name);
                foreach (var person in persons)
                {
                    PersonsDTO pd = new PersonsDTO();
                    pd.Id = person.Id;
                    pd.personName = person.personName;
                    Persons.Add(pd);
                }
                Medias.Add(md);
            }
        }

    }
}