using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App2
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();

            btnContacts.Clicked += BtnContacts_Clicked;
            btnEncrypt.Clicked += BtnEncrypt_Clicked;
            btnDecrypt.Clicked += BtnDecrypt_Clicked;
            btnPubKey.Clicked += BtnPubKey_Clicked;
        }

        private void BtnPubKey_Clicked(object sender, EventArgs e)
        {
            
        }

        private void BtnDecrypt_Clicked(object sender, EventArgs e)
        {
            
        }

        private void BtnEncrypt_Clicked(object sender, EventArgs e)
        {
            
        }

        private void BtnContacts_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Contacts());
        }
    }
}
