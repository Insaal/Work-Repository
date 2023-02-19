using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Rosneft.Helpers.Interfaces;
using Rosneft.Pages;

namespace Rosneft.Helpers
{
    public class PagesResolver : IPageResolver
    {
        private readonly Dictionary<string, Func<Page>> _pagesResolvers = new Dictionary<string, Func<Page>>();

        public PagesResolver()
        {
            _pagesResolvers.Add(Navigation.MainPage, () => new MainPage());
            //_pagesResolvers.Add(Navigation.AdminUsers, () => new AdminUsers());
            //_pagesResolvers.Add(Navigation.CalculatingSalary, () => new CalculatingSalary());
            //_pagesResolvers.Add(Navigation.About, () => new About());
        }

        public Page GetPageInstance(string alias)
        {
            if (_pagesResolvers.ContainsKey(alias)) return _pagesResolvers[alias]();
            return _pagesResolvers[Navigation.NotFoundPageAlias]();
        }
    }
}