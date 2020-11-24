using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chambify
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            ImpUsuario.Text = "Bienvenido, " + usuario;
            Servicios();
        }

        public async void Servicios()
        {
            await Navigation.PushAsync(new Servicios());
        }

        private void BtnServicios_Clicked(object sender, EventArgs e)
        {
            Servicios();
        }
    }
}
