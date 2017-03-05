

using CMSConsole.Models;
using CMSConsole.Models.Core;
using System;
namespace CMSConsole.Controllers
{
    public abstract class BasketWizardController<TPage> where TPage : Page, IWizardPage
    {
        //
        // GET: /BasketWizard/
        private TPage page;
        private IEngine engine;
        public BasketWizardController() { }
        public BasketWizardController(IEngine engine)
        {
            this.engine = engine;
        }
        public BasketWizardController(TPage page,IEngine engine):this(engine)
        {  
            this.page = page;
        }
        public virtual void Index()
        {
            Console.WriteLine(page.Name + " Controller");
            GoToNextPage();
        }
        protected void GoToNextPage()
        {
            var nextPage = engine.goTo(page);
            if (nextPage is FinalPage)
            {
                var controller = new FinalPageController(nextPage as FinalPage);
                controller.Index();
                return;
            }

            
            
        }
    }
}
