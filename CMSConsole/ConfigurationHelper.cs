using CMSConsole.Models.Core;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSConsole
{
    public class ConfigurationHelper
    {
        public  static void ConfigureDependencies(ConfigurationExpression obj)
        {
            obj.For<IEngine>().Use<Engine>();
            var s = PageStore.Current;
            obj.For<IPageStore>().Singleton().Use(s);
        }
    }
}
