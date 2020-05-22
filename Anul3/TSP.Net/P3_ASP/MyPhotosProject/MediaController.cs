using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPhotosProject
{
    public class MediaController
    {
        // CREATE
        public Media createMedia(Media m) 
        {
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                Random rnd = new Random();
                m.Id = Convert.ToInt32(rnd.Next());
                context.Media.Add(m);
                context.SaveChanges();
                return m;
            }
        }

        //READ
        public List<Media> getAllMedia()
        {
            string query = "SELECT * FROM Media";
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                List<Media> allMedia = context.Media.SqlQuery(query).ToList();
                return allMedia;
            }
        }

        public List<Media> getMediaByPersonName(string personName)
        {            
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                int personId = context.Persons.SingleOrDefault(person => person.personName == personName).Id;
                List<PersonsMedia> references = context.PersonsMedias.SqlQuery("SELECT * FROM PersonsMedias WHERE PersonsId=" + personId).ToList();
                List<Media> foundMedia = new List<Media>();
                foreach(PersonsMedia reference in references)
                {
                    Media m = context.Media.SingleOrDefault(searchMedia => searchMedia.Id == reference.MediaId);
                    foundMedia.Add(m);
                }
                return foundMedia;
            }
        }
        
        public List<Media> getMediaByPath(string path)
        {
            string query = "SELECT * FROM Media WHERE path=" + path;
            using(ModelMyPhotosContainer context=new ModelMyPhotosContainer())
            {
                var foundMedia = context.Media.SqlQuery(query).ToList();
                return foundMedia;
            }
        }

        public Media getMediaById(int id)
        {
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                var foundMedia = context.Media.Find(id);
                return foundMedia;
            }
        }

        //UPDATE
        public Media updateMedia(Media m, int mediaId)
        {
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer()) 
            {
                Media dbMedia = context.Media.SingleOrDefault(searchMedia => searchMedia.Id == mediaId);
                dbMedia.name = m.name;
                dbMedia.description = m.description;
                dbMedia.location = m.location;
                dbMedia.@event = m.@event;
                context.SaveChanges();
                return dbMedia;
            }
        }

        public void addPersonToMedia(Persons p, int mediaId)
        {
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                PersonsMedia reference = new PersonsMedia()
                {
                    MediaId = mediaId,
                    PersonsId = p.Id
                };
                context.PersonsMedias.Add(reference);
                context.SaveChanges();
            }
        }
        //DELETE
        public void removeMedia(int id)
        {
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                Media dbMedia = context.Media.SingleOrDefault(searchMedia => searchMedia.Id == id);
                dbMedia.path = "DELETED" + dbMedia.path;
                context.SaveChanges();
            }
        }
        public void removeMediaFromDb(int id)
        {
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                Media m = context.Media.SingleOrDefault(searchMedia => searchMedia.Id == id);
                context.Media.Remove(m);
                context.SaveChanges();
            }
        }
    }
}
