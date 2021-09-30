using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Actividad_10.Vistas;
using Actividad_10.Modelo;

namespace Actividad_10
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            App.tapped = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstPersonas.ItemsSource = null;
            lstPersonas.ItemsSource = App.Personas;
        }
        private void btnNuevo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoPage());
        }
        private void btnModificar_Clicked(object sender, EventArgs e)
        {
            if (App.tapped)
            {
                App.Personas[App.index].Nombre = txtNombre.Text;
                App.Personas[App.index].Correo = txtCorreo.Text;
                App.Personas[App.index].Telefono = txtTelefono.Text;
                lstPersonas.ItemsSource = null;
                lstPersonas.ItemsSource = App.Personas;
            }
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            if (App.tapped)
            {
                App.Personas.RemoveAt(App.index);
                lstPersonas.ItemsSource = null;
                lstPersonas.ItemsSource = App.Personas;
                App.tapped = false;
                btnModificar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
            }
        }

        private void lstPersonas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            var myItem = myListView.SelectedItem;
            App.index = App.Personas.IndexOf(myItem);
            txtNombre.Text = App.Personas[App.index].Nombre;
            txtCorreo.Text = App.Personas[App.index].Correo;
            txtTelefono.Text = App.Personas[App.index].Telefono;
            App.tapped = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
        }


    }
}
