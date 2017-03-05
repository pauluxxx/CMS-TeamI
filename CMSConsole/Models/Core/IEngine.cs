using CMSConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSConsole.Models.Core
{
    public interface IEngine
    {
        Page goTo<TPage>(TPage page)
           where TPage : Page, IWizardPage;
    }
}
