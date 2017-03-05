
namespace CMSConsole.Models
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