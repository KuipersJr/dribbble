using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Dribbble.Aplicacao;
using Dribbble.Dominio;
using Dribbble.WindowsPhone.Common;
using Dribbble.WindowsPhone.Data;

namespace Dribbble.WindowsPhone
{
    public sealed partial class PrincipalPage : Page
    {
        private const string PopularesGroupName = "Populares";

        private readonly NavigationHelper _navigationHelper;
        private readonly ObservableDictionary _defaultViewModel = new ObservableDictionary();
        private readonly ResourceLoader _resourceLoader = ResourceLoader.GetForCurrentView("Resources");

        public PrincipalPage()
        {
            InitializeComponent();

            NavigationCacheMode = NavigationCacheMode.Required;

            _navigationHelper = new NavigationHelper(this);
            _navigationHelper.LoadState += NavigationHelper_LoadState;
            _navigationHelper.SaveState += NavigationHelper_SaveState;
        }

        public NavigationHelper NavigationHelper
        {
            get { return this._navigationHelper; }
        }

        public ObservableDictionary DefaultViewModel
        {
            get { return this._defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>.
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private async void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            //if (_navigationHelper._pageKey == "Page-0")
            //{
            //    await PopularPaginaPrincipal();
            //}
        }

        private async Task PopularPaginaPrincipal()
        {
            var paginaPrincipal = await new PrincipalAplicacao()
                .Obter(Configuracoes.Uris[Configuracoes.Pagina.Principal], Common.Aplicacao.NumeroPaginaPrincipal);
            DefaultViewModel[PopularesGroupName] = paginaPrincipal;
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache. Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/>.</param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
            // TODO: Save the unique state of the page here.
        }

        private void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var shotId = ((Shot)e.ClickedItem).id;

            if (!Frame.Navigate(typeof(ShotPage), shotId))
            {
                throw new Exception(_resourceLoader.GetString("NavigationFailedExceptionMessage"));
            }
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedTo(e);

            if (e.NavigationMode == NavigationMode.New)
            {
                await PopularPaginaPrincipal();
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private async void ProximaPaginaAppBarButton_OnClick(object sender, RoutedEventArgs e)
        {
            ++Common.Aplicacao.NumeroPaginaPrincipal;
            await PopularPaginaPrincipal();
        }

        private async void PaginaAnteriorAppBarButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (Common.Aplicacao.NumeroPaginaPrincipal > 1)
            {
                --Common.Aplicacao.NumeroPaginaPrincipal;
                await PopularPaginaPrincipal();
            }
        }

        private async void AtualizarAppBarButton_OnClick(object sender, RoutedEventArgs e)
        {
            await PopularPaginaPrincipal();
        }
    }
}