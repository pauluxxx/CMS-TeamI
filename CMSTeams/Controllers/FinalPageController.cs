using CMSTeams.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSTeams.Controllers
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
