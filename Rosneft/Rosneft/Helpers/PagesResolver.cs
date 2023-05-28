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
            _pagesResolvers.Add(Navigation.AdminPage, () => new AdminPage());
            _pagesResolvers.Add(Navigation.RepairPage, () => new RepairPage());
            _pagesResolvers.Add(Navigation.RepairArchivePage, () => new RepairArchivePage());
            _pagesResolvers.Add(Navigation.CalculationNormsPage, () => new CalculationNormsPage());
            _pagesResolvers.Add(Navigation.TimeSheetPage, () => new TimeSheetPage());
            _pagesResolvers.Add(Navigation.DocumentsPage, () => new DocumentsPage());
            _pagesResolvers.Add(Navigation.ChatPage, () => new ChatPage());
        }

        public Page GetPageInstance(string alias)
        {
            if (_pagesResolvers.ContainsKey(alias)) return _pagesResolvers[alias]();
            return _pagesResolvers[Navigation.NotFoundPageAlias]();
        }
    }
}