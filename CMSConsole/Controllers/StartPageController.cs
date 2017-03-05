using CMSConsole.Models;
using System;
namespace CMSConsole.Controllers
{
    public class StartPageController 
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
