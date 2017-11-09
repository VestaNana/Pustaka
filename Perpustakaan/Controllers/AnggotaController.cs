using PerpustakaanDataAccess;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Perpustakaan.Controllers
{
    public class AnggotaController : Controller
    {
        // GET: Anggota
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetByPendaftaran(string kodeKartu)
        {
            return View(AnggotaDataAccess.GetByPendaftaran(kodeKartu));
        }
        public ActionResult List()
        {
            return View(AnggotaDataAccess.GetAll());
        }
        public ActionResult Create()
        {
            //ViewBag.PendaftaranList = new SelectList(PendaftaranDataAccess.GetAll(), "KodeAnggota", "KodeAnggota");
            return View();
        }

        [HttpPost]
        public ActionResult Create(AnggotaViewModel model)
        {
            return CreateEdit(model);
        }
        public ActionResult Edit(int id)
        {
            //ViewBag.PendaftaranList = new SelectList(PendaftaranDataAccess.GetAll(), "KodeAnggota", "KodeAnggota");
            return View(AnggotaDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(AnggotaViewModel model)
        {
            return CreateEdit(model);
        }
        public ActionResult CreateEdit(AnggotaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (AnggotaDataAccess.Update(model))
                    {
                        return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = false, message = AnggotaDataAccess.Message }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { success = false, message = "Please full fill required fields!" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Delete(int id)
        {
            return View(AnggotaDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            if (AnggotaDataAccess.Delete(id))
            {
                return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, message = AnggotaDataAccess.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}