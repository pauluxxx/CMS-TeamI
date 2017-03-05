using CMSTeams.Models;
using CMSTeams.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSTeams.Controllers
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
