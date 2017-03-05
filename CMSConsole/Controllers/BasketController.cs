using CMSConsole.Models;
using CMSConsole.Models.Core;
namespace CMSConsole.Controllers
{
    public class BasketController : BasketWizardController<BasketPage>
    {
        public override void Index()
        {
            base.Index();
        }

        public BasketController(BasketPage basketPage, IEngine engine)
            : base(basketPage, engine)
        {
        }
    }
}
