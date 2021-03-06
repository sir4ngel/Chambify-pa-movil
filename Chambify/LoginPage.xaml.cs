﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chambify
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        
        ApiRest client;
        string name, password, url;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnEnter_Clicked(object sender, EventArgs e)
        {
            login();
        }

        private async void login()
        {
            name = TxName.Text;
            password = TxPassword.Text;
            url = "http://www.nutrimorin.com/api/usuarios";
            client = new ApiRest();
            string jsonUsers = client.GetItems(url);
            List<Users> usuarios = JsonConvert.DeserializeObject<List<Users>>(jsonUsers);
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(password);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }

            for (int i = 0; i < usuarios.Count;)
            {
                if (usuarios[i].Usuario.Equals(name) && usuarios[i].Contrasena.Equals(cadena.ToString()))
                {
                    await Navigation.PushAsync(new MainPage(usuarios[i].Nombre));
                    break;
                }
                else
                {
                    i++;
                }

                if(i == usuarios.Count)
                {
                    await DisplayAlert("Error", "No se encontraron datos.", "OK");
                }
            }
        }
    }
}