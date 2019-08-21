using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nortwing.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductoView : ContentPage
    {
        public ProductoView()
        {
        }

        public ProductoView (/*Models.ProductoModel selectedItem*/Models.ProductoModel selectedItem) 
		{
			InitializeComponent ();
		}

        public void ProductoItemSelect(Models.ProductoModel selectedItem)
        {

        }


        private void Agregar_Clicked(object sender, EventArgs e)
        {

        }
    }
}