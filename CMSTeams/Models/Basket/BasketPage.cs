using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSTeams.Models
{
    public class BasketPage:BasketWizardPage 
    {
        public double Total { get; set; }
        public override string WizardPageName()
        { 
            return base.WizardPageName();
        }
    }
}