using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chambify
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Servicios : ContentPage
    {
        ApiRest client;
        string url;
        public Servicios()
        {
            InitializeComponent();
            Services();
        }

        public void Services()
        {
            url = "http://www.nutrimorin.com/api/trabajadores";
            client = new ApiRest();
            string jsonWorkers = client.GetItems(url);
            List<Workers> workers = JsonConvert.DeserializeObject<List<Workers>>(jsonWorkers);

            servicios.ItemsSource = workers;
        }

    }
}