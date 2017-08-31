using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;



namespace App2
{
    public partial class Contacts : ContentPage
    {
        public ObservableCollection<ContactsViewModel> contacts { get; set; }
		public ObservableCollection<ActivityViewModel> activities { get; set; }

		public Contacts()
        {
            InitializeComponent();

			//FillListView();
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

        public interface IClipBoard
        {
            String GetTextFromClipBoard();
        }

        public void PubKey_Clicked (object sender, EventArgs e)
        {
            string text = ((Label)sender).Text;
            lblTmp.Text = text;            
        }

        public void btnEditClicked(object sender, EventArgs e)
        {
            Image image = (Image)sender;
            image.Opacity = 0.5;
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                image.Opacity = 1;
                return false;
            });
        }

        public void btnRemoveClicked(object sender, EventArgs e)
        {
            Image image = (Image)sender;
            image.Opacity = 0.5;
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                image.Opacity = 1;
                return false;
            });
        }

        private void FillListView()
        {
            contacts = new ObservableCollection<ContactsViewModel>();
            contacts.Add(new ContactsViewModel { name = "Tomato", publicKey = "Fruit", image = "icon.png", index = 0 });
            contacts.Add(new ContactsViewModel { name = "Romaine Lettuce", publicKey = "Vegetable", image = "icon.png", index = 1 });
            contacts.Add(new ContactsViewModel { name = "Zucchini", publicKey = "Vegetable", image = "icon.png", index = 2 });
            lstView.ItemsSource = contacts;
        }

		private void FillActivities()
		{
			activities = new ObservableCollection<ActivityViewModel>();
			activities.Add(new ActivityViewModel { id = 1, name="fiesta", date="hoy", owner_id=1, total=610.00});
			lstView.ItemsSource = activities;
		}
	}
}
