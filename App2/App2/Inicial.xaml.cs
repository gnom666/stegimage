using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class Inicial : ContentPage
    {
        public Inicial()
        {
            InitializeComponent();

            btnEntrar.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Menu());
            };

            btnCrear.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Crear());
            };
        }

        void OnInfoTapped(object sender, EventArgs args)
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

        
    }
}
