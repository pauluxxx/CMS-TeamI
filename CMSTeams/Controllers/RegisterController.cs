using CMSTeams.Models;
using CMSTeams.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSTeams.Controllers
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