using CMSConsole.Models;
using CMSConsole.Models.Core;
namespace CMSConsole.Controllers
{
    public class RegisterController : BasketWizardController<RegisterPage>
    {
        public override void Index()
        {
            base.Index();
        }
        public RegisterController(RegisterPage page, IEngine engine)
            : base(page, engine)
        {

        }
    }
}