using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Nortwing.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nortwing.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlantillaView : ContentPage
    {
        BaseDatosModel Bd = new BaseDatosModel();
        public PlantillaView ()
		{
			InitializeComponent ();
           
            ListaProductos.ItemsSource = Bd.LeerDatos();

        }

        private void ListaProductos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CategoriaModel categoriaelegida = new CategoriaModel();
            categoriaelegida = (CategoriaModel)e.SelectedItem;
            int idcategoria = categoriaelegida.IDCategoria;
            List<ProductoModel> productosAMostrar = new List<ProductoModel>();
            productosAMostrar = Bd.LeerProductoCategoria(idcategoria);

            ListaProductos.ItemsSource = productosAMostrar;

            ListaProductos.IsVisible = false;
            ListaProductos.IsVisible = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PlantillaView());
        }

        
    }
}