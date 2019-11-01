using AlphaRangers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlphaRangers.Controllers
{
    public class HomeController : Controller
    {
        private SiteContext db = new SiteContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetData()
        {
            Baja Baja = db.Baja.ToList().Last();

            return Json(
                new
                {
                    Velocidade = Baja.Velocidade,
                    Temperatura = Baja.Temperatura,
                    Tensao = Baja.Bateria,
                    FreiosQTD = Baja.FreioQtd,
                    VoltasQTD = Baja.VoltasQtd
                }
            );
        }

        public ActionResult Reports()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}