using CMSConsole.Models;
using CMSConsole.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CMSConsole.Controllers
{
    class FinalPageController
    {
        private FinalPage page;

        public FinalPageController(FinalPage finalPage)
        {
            this.page = finalPage;
        }

        internal void Index()
        {
            Console.WriteLine(page.Name +" is :"+ page.WIN);
            var startController = new StartPageController(PageStore.Pages.OfType<StartPage>().FirstOrDefault());
            startController.Index();
        }
    }
}
