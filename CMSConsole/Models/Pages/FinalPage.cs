﻿
namespace CMSConsole.Models
{
    public enum WIN
    {
        Sucsess, Fail
    }
    public class FinalPage : BasketWizardPage
    {
        public WIN WIN { get; set; }
        public override string WizardPageName()
        {
            return base.WizardPageName();
        }
    }


}