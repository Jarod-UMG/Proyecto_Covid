using Business_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROYECTO.Controllers
{
    public class TVacunasController : Controller
    {
        // GET: TVacunas
        public ActionResult Insert(TVacunasBO dto)
        {
            NegTVacunas obj = new NegTVacunas();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Update(TVacunasBO dto)
        {
            NegTVacunas obj = new NegTVacunas();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Delete(string ID_VACUNA)
        {
            NegTVacunas obj = new NegTVacunas();
            obj.Eliminar(ID_VACUNA);
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            NegTVacunas obj = new NegTVacunas();
            return View(obj.Listar());
        }

        [HttpGet]
        public ActionResult Update(string ID_VACUNA)
        {
            NegTVacunas obj = new NegTVacunas();
            TVacunasBO dto = obj.Listar().FirstOrDefault(a => a.ID_VACUNA == ID_VACUNA);
            return View("Update", dto);
        }

    }
}