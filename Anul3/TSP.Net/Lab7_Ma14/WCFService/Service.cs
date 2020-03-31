using MyPhotosProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WCFService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService
    {
        private readonly MediaController _mediaController = new MediaController();
        public Service() { }

        public void SaddPersonToMedia(Persons p, int mediaId)
        {
            throw new NotImplementedException();
        }

        public void ScreateMedia(Media m)
        {
            throw new NotImplementedException();
        }

        public List<Media> SgetAllMedia()
        {
            throw new NotImplementedException();
        }

        public Media SgetMediaById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Media> SgetMediaByPath(string path)
        {
            throw new NotImplementedException();
        }

        public List<Media> SgetMediaByPersonName(string personName)
        {
            throw new NotImplementedException();
        }

        public void SremoveMedia(int id)
        {
            throw new NotImplementedException();
        }

        public Media SupdateMedia(Media m, int mediaId)
        {
            throw new NotImplementedException();
        }
    }
}
