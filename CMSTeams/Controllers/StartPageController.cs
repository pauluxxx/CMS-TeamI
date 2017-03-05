using CMSTeams.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSTeams.Controllers
{
    public class StartPageController : Controller
    {
        //
        // GET: /StartPage/
        private StartPage page;

        public StartPageController(StartPage page)
        {
            this.page = page;
        }

        public void Index()
        {
            Console.WriteLine(page.Name + " Controller");
         
        }


    }
}
