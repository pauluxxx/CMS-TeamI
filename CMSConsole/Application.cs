
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CMSConsole
{
    class Application
    {
        //SingletoneApp 
        //lockObject for multithreading?
        private static readonly object LockObject = new object();
        private static Application currentApplicationInstance = new Application();
        private readonly IContainer container;

       // private readonly IPageStore pagestore;
        private Application()
        {
            container = new Container();
            container.Configure(x => x.For<IContainer>().Singleton().Use(container));
        }
        //we didn't ask IsInitialized ? why it may 
        public static bool IsInitialized { get; private set; }
        public static Application Current
        {
            get { return currentApplicationInstance; }
        }
        public IContainer Container
        {
            get { return container; }
        }
        //public IPageStore PageStore {
        //    get { return pagestore; }
        //  }
        public static Application Initialize(Action<ConfigurationExpression> configurationAction)
        {
            lock (LockObject)
            {
                currentApplicationInstance = new Application();
                Current.Container.Configure(configurationAction);
                IsInitialized = true;
            }
            return Current;
        }

    }
}
