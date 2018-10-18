using StarWarsUniverse.Domain;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWarsXF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : MasterDetailPage
	{
		public MainView()
		{
			InitializeComponent();

			//MyMasterPage.MyListView.ItemSelected += MyListView_ItemSelected;
		}

		//private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		//{
		//    var movie = e.SelectedItem as Movie;
		//    if (movie != null)
		//    {
		//        var page = new MovieDetailsView();

		//        //pass the movie for the page
		//        page.Title = movie.Title;
		//        page.FillMovieDetails(movie);
		//        Detail = new NavigationPage(page);

		//        //install a handler to open the planets inside this detail page
		//        page.MyPlanetsButton.Clicked += (pageSender, pageArgs) =>
		//        {
		//            var planetsPage = new PlanetsView();
		//            planetsPage.Title = $"{movie.Title} - Planets";
		//            planetsPage.FillPlanetDetails(movie);
		//            Detail = new NavigationPage(planetsPage);
		//        };

		//        IsPresented = false;
		//    }
		//}
	}
}