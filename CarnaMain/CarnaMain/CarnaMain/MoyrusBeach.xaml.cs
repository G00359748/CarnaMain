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
	public partial class MoyrusBeach : ContentPage
	{
		public MoyrusBeach ()
		{
			InitializeComponent();
            addImagesToPages3();
        }

        private void addImagesToPages3()
        {
            var assembly = typeof(Home);

            string strfilename = "CarnaMain.Images.Moyrus.jpeg";

            Moyrus.Source = ImageSource.FromResource(strfilename, assembly);
        }
    }
}