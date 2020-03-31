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
    public interface IService
    {
        [OperationContract]
        void ScreateMedia(Media m);

        [OperationContract]
        List<Media> SgetAllMedia();
        
        [OperationContract]
        List<Media> SgetMediaByPersonName(string personName);

        [OperationContract]
        List<Media> SgetMediaByPath(string path);

        [OperationContract]
        Media SgetMediaById(int id);

        [OperationContract]
        Media SupdateMedia(Media m, int mediaId);

        [OperationContract]
        void SaddPersonToMedia(Persons p, int mediaId);

        [OperationContract]
        void SremoveMedia(int id);
    }
}
