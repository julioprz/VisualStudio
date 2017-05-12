using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Model.Repository Repository = new Model.Repository();

            IRepository Repository = new Model.Repository();

            //var MainPageContents = Repository.FinEntitySet<MainPageContent>(p => true);

            //var mainPageCont1 = Repository.Create(new MainPageContent
            //{

            //    sTitle = "Test1",
            //    sStory = "Esto es una prueba",
            //    dtCreated = DateTime.Now
            //});

            
            

            Console.Write("Presiona Enter para finalizar: ");
            Console.ReadLine();
             
        }
    }
}
