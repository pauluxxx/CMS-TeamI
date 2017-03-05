

namespace CMSConsole.Models
{
    abstract public class BasketWizardPage:Page,IWizardPage
    {

        public virtual string WizardPageName()
        { 
            return Name;
        }
    }
}