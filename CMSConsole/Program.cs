using CMSTeams.Controllers;
using CMSTeams.Models;
using CMSTeams.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Initialize(ConfigurationHelper.ConfigureDependencies);
            try
            {
                var injectedEngine = Application.Current.Container.GetInstance<IEngine>();

                var s = Application.Current.PageStore;
                var basketPage = Application.Current.PageStore.Pages.OfType<BasketPage>().FirstOrDefault();
                var basketController = new BasketController(basketPage, injectedEngine);
                basketController.Index();
                var registerPage = Application.Current.PageStore.Pages.OfType<RegisterPage>().FirstOrDefault();
                var registerController = new RegisterController(registerPage, injectedEngine);
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
