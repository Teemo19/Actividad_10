using System;
using Xamarin.Forms;
using Actividad_10.Modelo;
using Actividad_10.Vistas;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;

namespace Actividad_10
{
    public partial class App : Application
    {
        public static List<Persona> Personas { get; set; }
        public static bool tapped { get; set; }
        public static int index { get; set; }
        public App()
        {
            InitializeComponent();
            Personas = new List<Persona>();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
