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

        public Contacts()
        {
            InitializeComponent();

            FillListView();

            
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

        private void FillListView()
        {
            contacts = new ObservableCollection<ContactsViewModel>();
            contacts.Add(new ContactsViewModel { name = "Tomato", publicKey = "Fruit", image = "icon.png" });
            contacts.Add(new ContactsViewModel { name = "Romaine Lettuce", publicKey = "Vegetable", image = "icon.png" });
            contacts.Add(new ContactsViewModel { name = "Zucchini", publicKey = "Vegetable", image = "icon.png" });
            lstView.ItemsSource = contacts;
        }
    }
}
