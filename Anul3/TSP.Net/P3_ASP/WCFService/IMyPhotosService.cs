using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyPhotosProject;

namespace WCFService
{
    [ServiceContract]
    interface interfaceMedia
    {
        [OperationContract]
        Media createMedia(Media m);

        [OperationContract]
        List<Media> getAllMedia();

        [OperationContract]
        List<Media> getMediaByPersonName(string personName);

        [OperationContract]
        List<Media> getMediaByPath(string path);

        [OperationContract]
        Media getMediaById(int id);

        [OperationContract]
        Media updateMedia(Media m, int mediaId);

        [OperationContract]
        void addPersonToMedia(Persons p, int mediaId);

        [OperationContract]
        void removeMedia(int id);

        [OperationContract]
        void removeMediaFromDb(int id);
    }

    [ServiceContract]
    interface interfacePerson
    {
        [OperationContract]
        Persons createPerson(Persons P);
        [OperationContract]
        List<Persons> getPersonsByMediaName(string mediaName);
        [OperationContract]
        Persons updatePerson(Persons p);
        [OperationContract]
        void removePersonFromDb(Persons p);
    }
    [ServiceContract]
    interface IMyPhotosService: interfaceMedia, interfacePerson
    {

    }
}
