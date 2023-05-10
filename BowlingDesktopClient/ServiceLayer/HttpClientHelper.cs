using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BowlingDesktopClient.ServiceLayer
{
    internal class HttpClientHelper
    {
        private static HttpClient _httpClient;

        public static HttpClient GetHttpClient()
        {
            if (_httpClient == null)
            {
                _httpClient = new HttpClient();
                InitializeHttpClient();
            }

            return _httpClient;
        }

        private static void InitializeHttpClient()
        {
            // Brug den lokale URL til din API
            _httpClient.BaseAddress = new Uri("https://localhost:7197/");
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // Tilføj yderligere konfiguration efter behov, f.eks. API-nøgler, autorisationsheadere osv.
        }
    }
}

