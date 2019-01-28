using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using Desafio.DAL;
using Desafio.Models;

namespace Desafio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(new WhoisContext().WhoisDb.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult ConsultaDominio(string dominio)
        {
            var whois = new ClientWhois().ConsultaDominio(dominio);
            var banco = new WhoisContext();
            banco.WhoisDb.Add(whois);
            banco.SaveChanges();

            return View("Index", whois);
        }
    }
}