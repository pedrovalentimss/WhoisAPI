using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Desafio.Models
{
    public class ClientWhois
    {
        private readonly RestClient httpClient;

        public ClientWhois()
        {
            httpClient = new RestClient("http://jsonwhoisapi.com/");
        }

        public Whois ConsultaDominio(string dominio)
        {
            var request = new RestRequest("api/v1/whois?identifier=" + dominio, Method.GET);
            request.AddHeader("Authorization", "OfOOhEUl0qzrfH7t35vvug");

            var response = httpClient.Execute(request);

            var whois = JsonConvert.DeserializeObject<Whois>(response.Content);

            return whois;
        }

    }
}