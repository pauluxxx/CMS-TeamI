using CMSTeams.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSTeams.Models.Core
{
    internal sealed class PageStore : IPageStore
    {
        private static readonly PageStore instance = new PageStore();
        private IEnumerable<Page> pages;
        private PageStore()
        {
            //input a constant Page of CMS
            pages = new List<Page> { new StartPage { Name = PageName.Start.ToString() }, new RegisterPage { Name = PageName.Register.ToString() }, new BasketPage { Name = PageName.Basket.ToString(), Total = 1 }, new FinalPage { Name = PageName.Success_Payment.ToString(), WIN = WIN.Sucsess }, new FinalPage { Name = PageName.Fail_Payment.ToString(), WIN = WIN.Fail } };
        }
        public IEnumerable<Page> Pages
        {
            get { return instance.pages; }
        }

    }
}