using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Eshop.Games.Services
{
    internal class BaseService
    {
        public HttpClient HttpClient;

        public BaseService()
        {
            HttpClient = new HttpClient();

            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
