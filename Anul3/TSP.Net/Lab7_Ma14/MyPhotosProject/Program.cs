using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Media obj = new Media() {
                name = Convert.ToString(Console.ReadLine()),
                location= Convert.ToString(Console.ReadLine()),
                description= Convert.ToString(Console.ReadLine()),
                date= Convert.ToDateTime(Console.ReadLine()),
                @event= Convert.ToString(Console.ReadLine()),
                type= Convert.ToString(Console.ReadLine()),
                path=System.IO.Path.GetFullPath(Console.ReadLine())
            };
            var mediaCtrl = new MediaController();
            Console.WriteLine("Add a photo or video into the database:");
            Console.WriteLine(mediaCtrl.createMedia(obj));
        }
    }
}
