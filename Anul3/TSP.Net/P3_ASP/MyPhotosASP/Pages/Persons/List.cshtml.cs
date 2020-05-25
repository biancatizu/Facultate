using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotosASP.Models;
using ServiceReferenceMyPhotos;

namespace MyPhotosASP.Pages.Persons
{
    public class ListModel : PageModel
    {
        MyPhotosServiceClient mpc = new MyPhotosServiceClient();
        public List<PersonsDTO> Persons { get; set; }
        public ListModel()
        {
            Persons = new List<PersonsDTO>();
        }
        public async Task OnGetAsync(string? mediaName)
        {
            if (mediaName==null)
                return;

            var item = await mpc.getPersonsByMediaNameAsync(mediaName);
            foreach(var pdto in Persons)
            {
                PersonsDTO pp = new PersonsDTO();
                pp.Id = pdto.Id;
                pp.personName = pdto.personName;
                Persons.Add(pp);
            }
        }
    }
}