using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotosASP.Models;
using ServiceReferenceMyPhotos;
using System.Collections.Generic;

namespace MyPhotosASP.Pages.Medias
{
    public class IndexModel : PageModel
    {
        MyPhotosServiceClient mpc = new MyPhotosServiceClient();
        public List<MediaDTO> Medias { get; set; }
        public IndexModel()
        {
            Medias = new List<MediaDTO>();
        }
        public async void OnGetAsync()
        {
            List<Media> medias = await mpc.getAllMediaAsync();
            foreach (var item in medias)
            {
                MediaDTO md = new MediaDTO();
                md.Id = item.Id;
                md.name = item.name;
                md.description = item.description;
                md.date = item.date;
                md.location = item.location;
                md.@event = item.@event;
                md.path = item.path;
                md.type = item.type;
                /*foreach(var pm in item.PersonsMedias)
                {
                    PersonsMediaDTO pmd = new PersonsMediaDTO();
                    pmd.MediaId = pm.MediaId;
                    pmd.PersonsId = pm.PersonsId;
                    md.PersonsMedias.Add(pmd);
                }*/
                Medias.Add(md);
            }
        }
    }
}