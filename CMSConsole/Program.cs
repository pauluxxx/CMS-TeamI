using CMSTeams.Controllers;
using CMSTeams.Models;
using CMSTeams.Models.Core;
using CMSTeams.Models.Singletone;
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
           // Application.Initialize(ConfigurationHelper.ConfigureDependencies);
            var injectedEngine = new Engine();
            var basketPage = PageStore.Pages.OfType<BasketPage>().FirstOrDefault();
            var basketController = new BasketController(basketPage,injectedEngine);
            basketController.Index();
            var registerPage = PageStore.Pages.OfType<RegisterPage>().FirstOrDefault();
            var registerController = new RegisterController(registerPage, injectedEngine);
            registerController.Index();

            Console.ReadKey();
           
        }
    }
}
