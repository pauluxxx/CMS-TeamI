using CMSConsole.Controllers;
using CMSConsole.Models;
using CMSConsole.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSConsole
{
    public class Program
    {
        //create field for Store to simplify the name 
        public static IPageStore Store;
        public static void Main(string[] args)
        {
            Application.Initialize(ConfigurationHelper.ConfigureDependencies);
            try
            {
                Store = Application.Current.Container.GetInstance<IPageStore>();

                var injectedEngine = Application.Current.Container.GetInstance<IEngine>();
                var basketPage = Store.Pages.OfType<BasketPage>().FirstOrDefault();
                var registerPage = Store.Pages.OfType<RegisterPage>().FirstOrDefault();

                var basketController = new BasketController(basketPage, injectedEngine);
                var registerController = new RegisterController(registerPage, injectedEngine);

                basketController.Index();
                registerController.Index();

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an exception of {0} type", ex.GetType());
            }

        }
    }
}
