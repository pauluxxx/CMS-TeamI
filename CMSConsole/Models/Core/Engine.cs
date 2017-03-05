using CMSConsole.Models;
using CMSConsole.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSConsole.Models.Core
{
    public class Engine : IEngine
    {
        private static IDictionary<string, Page> BasketFlow = new Dictionary<string, Page>();
        private static IDictionary<string, Page> RegisterFlow = new Dictionary<string, Page>();
        private static Random random = new Random();//not thread safe
        static Engine()
        {
            Initializing();
        }
        private static void Initializing()
        {
            BasketFlow.Add(PageName.Basket.ToString(), GetPage(typeof(BasketPage), PageName.Basket.ToString()));
            BasketFlow.Add(PageName.Success_Payment.ToString(), GetPage(typeof(FinalPage), PageName.Success_Payment.ToString()));
            BasketFlow.Add(PageName.Fail_Payment.ToString(), GetPage(typeof(FinalPage), PageName.Fail_Payment.ToString()));

            RegisterFlow.Add(PageName.Register.ToString(), GetPage(typeof(RegisterPage), PageName.Register.ToString()));
            RegisterFlow.Add(PageName.Success_Payment.ToString(), GetPage(typeof(FinalPage), PageName.Success_Payment.ToString()));
            RegisterFlow.Add(PageName.Fail_Payment.ToString(), GetPage(typeof(FinalPage), PageName.Fail_Payment.ToString()));

        }
        private static Page GetPage(Type type, string wizardPageName)
        {
            foreach (var page in Program.Store.Pages)
            {
                var wizardPage = page as IWizardPage;
                if (wizardPage != null)
                {
                    string s = wizardPage.WizardPageName();

                }
                if (wizardPage != null && wizardPage.GetType() == type && wizardPage.WizardPageName() == wizardPageName)
                {
                    return page;
                }
            }
            return null;
        }
        public Page goTo<TPage>(TPage page)
            where TPage : Page, IWizardPage
        {
            var startPage = Program.Store.Pages
                .OfType<StartPage>()
                .SingleOrDefault();
            if (BasketFlow.ContainsKey(page.WizardPageName()))
            {
                if (page.WizardPageName() == PageName.Basket.ToString())
                {
                    return (random.Next(2) == 0) ? BasketFlow[PageName.Success_Payment.ToString()] : BasketFlow[PageName.Fail_Payment.ToString()];
                }
            }
            if (RegisterFlow.ContainsKey(page.WizardPageName()))
            {
                if (page.WizardPageName() == PageName.Register.ToString())
                {
                    return (random.Next(2) == 0) ? RegisterFlow[PageName.Success_Payment.ToString()] : RegisterFlow[PageName.Fail_Payment.ToString()];
                }
            }
            return startPage;
        }


    }
}
