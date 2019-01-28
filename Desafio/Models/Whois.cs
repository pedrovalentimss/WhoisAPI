using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Desafio.Models
{
    public class Whois
    {
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Dominio { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("created")]
        public string DataRegistro { get; set; }
        [JsonProperty("expires")]
        public string DataExpire { get; set; }
        [JsonProperty("changed")]
        public string DataUpdate { get; set; }
        [JsonProperty("nameservers")]
        public string[] DNS { get; set; }
    }
}