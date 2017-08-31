using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity : ContentPage
	{
		public ObservableCollection<ActivityViewModel> activities { get; set; }

		public Activity()
		{
			InitializeComponent();

			FillActivities();
		}

		void OnAddTapped(object sender, EventArgs args)
		{
			Image image = (Image)sender;
			image.Opacity = 0.5;
			Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
			{
				image.Opacity = 1;
				return false;
			});
			Navigation.PushAsync(new Info());
		}

		public void PubKey_Clicked(object sender, EventArgs e)
		{
			string text = ((Label)sender).Text;
		}

		public void btnEditActClicked(object sender, EventArgs e)
		{
			Image image = (Image)sender;
			image.Opacity = 0.5;
			Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
			{
				image.Opacity = 1;
				return false;
			});
		}

		public void btnRemoveActClicked(object sender, EventArgs e)
		{
			Image image = (Image)sender;
			image.Opacity = 0.5;
			Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
			{
				image.Opacity = 1;
				return false;
			});
		}

		private void FillActivities()
		{
			activities = new ObservableCollection<ActivityViewModel>();



			activities.Add(new ActivityViewModel { id = 1, name = "fiesta", date = "hoy", owner_id = 1, total = 610.00 });
			lstActView.ItemsSource = activities;
		}
	}
}