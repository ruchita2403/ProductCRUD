using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MVCShopBridgeProducts
{
    public  static class GlobalVriables
    {
        public static HttpClient WebapiClient = new HttpClient();
        static GlobalVriables()
        {
            WebapiClient.BaseAddress = new Uri("http://localhost:60325/api/");
            WebapiClient.DefaultRequestHeaders.Clear();
            WebapiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}