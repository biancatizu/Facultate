using MyPhotosProject;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCFService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MyPhotosService : IMyPhotosService
    {
        MediaController _mediaController = new MediaController();
        PersonsController _personsController = new PersonsController();
        public MyPhotosService() { }

        void interfaceMedia.addPersonToMedia(Persons p, int mediaId)
        {
            _mediaController.addPersonToMedia(p, mediaId);
        }

        Media interfaceMedia.createMedia(Media m)
        {
            Console.WriteLine("Apel createMedia");
            return _mediaController.createMedia(m);
        }

        Persons interfacePerson.createPerson(Persons P)
        {
            Console.WriteLine("Apel createPerson");
            return _personsController.createPerson(P);
        }

        List<Media> interfaceMedia.getAllMedia()
        {
            Console.WriteLine("Apel getAllMedia");
            return _mediaController.getAllMedia();
        }

        Media interfaceMedia.getMediaById(int id)
        {
            Console.WriteLine("Apel getMediaById");
            return _mediaController.getMediaById(id);
        }

        List<Media> interfaceMedia.getMediaByPath(string path)
        {
            Console.WriteLine("Apel getMediaByPath");
            return _mediaController.getMediaByPath(path);
        }

        List<Media> interfaceMedia.getMediaByPersonName(string personName)
        {
            return _mediaController.getMediaByPersonName(personName);
        }

        List<Persons> interfacePerson.getPersonsByMediaName(string mediaName)
        {
            return _personsController.getPersonsByMediaName(mediaName);
        }

        void interfaceMedia.removeMedia(int id)
        {
            _mediaController.removeMedia(id);
        }

        void interfacePerson.removePersonFromDb(Persons p)
        {
            _personsController.removePersonFromDb(p);
        }

        Media interfaceMedia.updateMedia(Media m, int mediaId)
        {
            return _mediaController.updateMedia(m, mediaId);
        }

        Persons interfacePerson.updatePerson(Persons p)
        {
            return _personsController.updatePerson(p);
        }
    }
}
