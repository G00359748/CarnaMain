using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarnaMain
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
            addImagesToPages2();
        }

        private void addImagesToPages2()
        {
            var assembly = typeof(Home);

            string strfilename = "CarnaMain.Images.Carna1.jpg";

            Carna1.Source = ImageSource.FromResource(strfilename, assembly);
        }

        private void MoyrusButton_Clicked(object sender, EventArgs obj)
        {
            Navigation.PushAsync(new MoyrusBeach());
        }

        private void CarnaButton_Clicked(object sender, EventArgs obj)
        {
            Navigation.PushAsync(new CarnaBayHotel());
        }

        private void JoeHeaneyButton_Clicked(object sender, EventArgs obj)
        {
            Navigation.PushAsync(new JoeHeaneyFestival());
        }

        private void MacDaraButton_Clicked(object sender, EventArgs obj)
        {
            Navigation.PushAsync(new MacDarasIsland());
        }

        private void MoransButton_Clicked(object sender, EventArgs obj)
        {
            Navigation.PushAsync(new MoransBar());
        }

        private void ContactButton_Clicked(object sender, EventArgs obj)
        {
            Navigation.PushAsync(new Contact());
        }
    }
}