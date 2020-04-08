using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPhotosProject
{
    public class PersonsController
    {
        // CREATE
        public Persons createPerson(Persons p)
        {
            Console.WriteLine("Add a person into the database:");
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                Random rnd = new Random();
                p.Id = Convert.ToInt32(rnd.Next());
                context.Persons.Add(p);
                context.SaveChanges();
                return p;
            }
        }

        //READ
        public List<Persons> GetPersonsByMediaName(string mediaName)
        {
            string query = "SELECT personName FROM Persons JOIN PersonsMedias ON Persons.personId=PersonsMedia.PersonsId " +
                "JOIN Media ON PersonsMedias.MediaId=Media.Id WHERE Media.name=" + mediaName;
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                var foundPerson = context.Persons.SqlQuery(query).ToList();
                return foundPerson;
            }
        }

        //UPDATE
        public Persons updatePerson(Persons p)
        {
            string query = "UPDATE DATABASE Persons SET personName=" + p.personName + " WHERE Id="+p.Id;
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                context.Persons.SqlQuery(query);
                return p;
            }
        }

        //DELETE
        public void removePersonFromDb(Persons p)
        {
            using (ModelMyPhotosContainer context = new ModelMyPhotosContainer())
            {
                context.Persons.Remove(p);
                context.SaveChanges();
            }
        }
    }
}
