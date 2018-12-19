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
	public partial class CarnaBayHotel : ContentPage
	{
		public CarnaBayHotel ()
		{
			InitializeComponent ();
            addImagesToPages4();
        }
        

    private void addImagesToPages4()
    {
        var assembly = typeof(Home);

        string strfilename = "CarnaMain.Images.CarnaBay.jpg";

        CarnaBay.Source = ImageSource.FromResource(strfilename, assembly);
    }
}
}