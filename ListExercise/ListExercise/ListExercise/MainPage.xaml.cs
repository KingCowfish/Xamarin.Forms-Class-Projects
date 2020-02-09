using ListExercise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListExercise.Services;
using Xamarin.Forms;

namespace ListExercise
{
	public partial class MainPage : ContentPage
	{
		private SearchService _searchService;
		private List<SearchGroup> _searchGroups;

		public MainPage()
		{
			_searchService = new SearchService();

			InitializeComponent();

			PopulateListView(_searchService.GetRecentSearches());
		}

		private void OnSearchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			PopulateListView(_searchService.GetRecentSearches(e.NewTextValue));
		}


		private void PopulateListView(IEnumerable<Search> searches)
		{
			_searchGroups = new List<SearchGroup>
			{
				new SearchGroup("Recent Searches", searches)
			};

			listView.ItemsSource = _searchGroups;
		}

		private void OnDeleteClicked(object sender, System.EventArgs e)
		{
			var search = (sender as MenuItem).CommandParameter as Search;


			_searchGroups[0].Remove(search);

			_searchService.DeleteSearch(search.Id);
		}

		private void OnRefreshing(object sender, System.EventArgs e)
		{
			// Note that we're using the text in the SearchBar while refreshing
			// the list of searches. This ensures that the filter is applied 
			// while refreshing the list. 
			PopulateListView(_searchService.GetRecentSearches(searchBar.Text));

			listView.EndRefresh();
		}

		private void OnSearchSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var search = e.SelectedItem as Search;
			DisplayAlert("Selected", search.Location, "OK");
		}
	}
}
