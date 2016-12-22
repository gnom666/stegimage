using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App2
{
    public partial class Crear : ContentPage
    {
        public Crear()
        {
            InitializeComponent();

            double v1 = 0;
            double v2 = 0;
            double v3 = 0;
            double v4 = 0;

            sldrV1.ValueChanged += (sender, e) =>
            {
                v1 = ((Slider)sender).Value;
            };
            sldrV2.ValueChanged += (sender, e) =>
            {
                v2 = ((Slider)sender).Value;
            };
            sldrV3.ValueChanged += (sender, e) =>
            {
                v3 = ((Slider)sender).Value;
            };
            sldrV4.ValueChanged += (sender, e) =>
            {
                v4 = ((Slider)sender).Value;
            };

            btnCrear.Clicked += (sender, e) =>
            {
                lblCP.Text = Math.Round(v1).ToString() + " " +
                             Math.Round(v2).ToString() + " " +
                             Math.Round(v3).ToString() + " " +
                             Math.Round(v4).ToString();
            };
        }        
    }
}
