using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Rosneft.Helpers.Interfaces;

namespace Rosneft.Helpers
{
    public class Navigation
    {
        #region Constants

        public static readonly string MainPage = "MainPage";

        public static readonly string AdminPage = "AdminPage";
        public static readonly string RepairPage = "RepairPage";
        public static readonly string RepairArchivePage = "RepairArchivePage";
        public static readonly string TimeSheetPage = "TimeSheetPage";
        public static readonly string DocumentsPage = "DocumentsPage";
        public static readonly string CalculationNormsPage = "CalculationNormsPage";
        public static readonly string ChatPage = "ShatPage";

        public static readonly string NotFoundPageAlias = "404";

        #endregion

        #region Fields

        private NavigationService _navService;
        private readonly IPageResolver _resolver;

        #endregion

        #region Properties

        public static NavigationService Service
        {
            get => Instance._navService;
            set
            {
                if (Instance._navService != null) Instance._navService.Navigated -= Instance._navService_Navigated;
                Instance._navService = value;
                Instance._navService.Navigated += Instance._navService_Navigated;
            }
        }

        #endregion

        #region Public Methods

        public static void Navigate(Page page, object context)
        {
            if (Instance._navService == null || page == null) return;
            Instance._navService.Navigate(page, context);
        }

        public static void Navigate(Page page)
        {
            Navigate(page, null);
        }

        public static void Navigate(string uri, object context)
        {
            if (Instance._navService == null || uri == null) return;
            var page = Instance._resolver.GetPageInstance(uri);
            Navigate(page, context);
        }

        public static void Navigate(string uri)
        {
            Navigate(uri, null);
        }

        #endregion

        #region Private Methods

        private void _navService_Navigated(object sender, NavigationEventArgs e)
        {
            var page = e.Content as Page;
            if (page == null) return;
            page.DataContext = e.ExtraData;
            if (Application.Current.MainWindow != null) Application.Current.MainWindow.Title = page.Title;
        }

        #endregion

        #region Singleton

        private static volatile Navigation _instance;
        private static readonly object SyncRoot = new object();

        private Navigation()
        {
            _resolver = new PagesResolver();
        }

        private static Navigation Instance
        {
            get
            {
                if (_instance == null)
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                            _instance = new Navigation();
                    }

                return _instance;
            }
        }

        #endregion
    }
}