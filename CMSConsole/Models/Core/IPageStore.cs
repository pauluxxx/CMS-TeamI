using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSConsole.Models.Core
{
    public interface IPageStore
    {
        IEnumerable<Page> Pages { get;}
    }
}
