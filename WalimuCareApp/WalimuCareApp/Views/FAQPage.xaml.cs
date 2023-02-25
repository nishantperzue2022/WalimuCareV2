using System;
using System.Collections.ObjectModel;
using WalimuCareApp.Models;
using WalimuCareApp.Repositories.FAQsModule;
using WalimuCareApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FAQPage : ContentPage
	{
		private ObservableCollection<FaqsViewModel> getContents;

		private ObservableCollection<FaqsViewModel> _expanderContents;
		public FAQPage()
		{
			InitializeComponent();

			getContents = FaqsViewModel.Contents;

			UpdateListContent();
		}

		private void HeaderTapped(object sender, EventArgs args)
		{
			int ListSelectedIndex = _expanderContents.IndexOf(((FaqsViewModel)((Button)sender).CommandParameter));

			getContents[ListSelectedIndex].Expanded = !getContents[ListSelectedIndex].Expanded;

			UpdateListContent();
		}

		private void UpdateListContent()
		{
			_expanderContents = new ObservableCollection<FaqsViewModel>();

			foreach (FaqsViewModel group in getContents)
			{
				FaqsViewModel jobs = new FaqsViewModel(group.Title, group.Expanded);

				jobs.JobItems = group.Count;

				if (group.Expanded)
				{
					foreach (JobClassModel job in group)
					{
						jobs.Add(job);
					}
				}
				_expanderContents.Add(jobs);
			}
			MyListView.ItemsSource = _expanderContents;
		}
		//protected override void OnAppearing()
		//{
		//	base.OnAppearing();

		//	GetFAQS();
		//}

		//private async void GetFAQS()
		//{
		//	try
		//	{
		//		var data = await FAQsRepository.GetList();

		//		if (data == null)
		//		{
		//			await DisplayAlert("Oops !", "You have not registered any dependant", "Ok");
		//		}

		//		//listOfFaqs.ItemsSource = data;
		//	}
		//	catch (Exception ex)
		//	{
		//		Console.WriteLine(ex.Message);
		//	}
		//}


	}
}