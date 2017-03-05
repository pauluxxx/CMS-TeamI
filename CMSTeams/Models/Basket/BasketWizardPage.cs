using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSTeams.Models
{
    abstract public class BasketWizardPage:Page,IWizardPage
    {

        public virtual string WizardPageName()
        { 
            return Name;
        }
    }
}