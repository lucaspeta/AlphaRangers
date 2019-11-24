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
            var Baja = db.Baja
                       .OrderByDescending(b => b.CreatedDate)
                       .FirstOrDefault();

            return Json(
                new
                {
                    Id = Baja.ID,
                    Velocidade = Baja.Velocidade,
                    Temperatura = Baja.Temperatura,
                    Tensao = Baja.Bateria,
                    FreiosQTD = Baja.FreioQtd,
                    VoltasQTD = Baja.VoltasQtd,
                    CreatedDate = Baja.CreatedDate
                }
            );
        }

        [HttpPost]
        public JsonResult SendFlag(bool Green, bool Yellow, bool Red, bool Shutdown)
        {
            string flagAtivada = "";

            Flags Flag = new Flags();

            Flag.Green = Green;
            Flag.Yellow = Yellow;
            Flag.Red = Red;
            Flag.Shutdown = Shutdown;
            Flag.CreatedDate = DateTime.Now;

            if (Green)
                flagAtivada = "Flag Verde ativada";

            if(Yellow)
                flagAtivada = "Flag Amarela ativada";

            if (Red)
                flagAtivada = "Flag Vermelha ativada";

            if (Shutdown)
                flagAtivada = "desligando...";

            db.Flags.Add(Flag);
            db.SaveChanges();
            
            return Json( 
                new {
                    flag_ativada = flagAtivada
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