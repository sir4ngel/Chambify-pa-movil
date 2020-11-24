using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chambify
{
    class ApiRest
    {
        //public async Task<T> Get<T>()
        //{
        //    try
        //    {
        //        HttpClient client = new HttpClient();
        //        var response = await client.GetAsync("http://www.nutrimorin.com/api/usuarios");
        //        if(response.StatusCode == System.Net.HttpStatusCode.OK)
        //        {
        //            var json = await response.Content.ReadAsStringAsync();
        //            return JsonConvert.DeserializeObject<T>(json);
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    return default(T);
        //}
        public string GetItems(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null)
                        {
                            return null;
                        }
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            return responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            return null;
        }

    }
}
