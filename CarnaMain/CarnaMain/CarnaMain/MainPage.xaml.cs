using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarnaMain
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            addImagesToPages1();
        }

        private void addImagesToPages1()
        {
            var assembly = typeof(MainPage);

            string strfilename = "CarnaMain.Images.Mace-Pier.jpg";

            MacePier.Source = ImageSource.FromResource(strfilename, assembly);
        }

        private void PleaseEnterButton_Clicked(object sender, EventArgs obj)
        {

            Navigation.PushAsync(new Home());

        }

    }
}
