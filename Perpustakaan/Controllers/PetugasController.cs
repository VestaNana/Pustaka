using PerpustakaanDataAccess;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Perpustakaan.Controllers
{
    public class PetugasController : Controller
    {
        // GET: Petugas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(PetugasDataAccess.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PetugasViewModel model)
        {
            return CreateEdit(model);
        }
        public ActionResult Edit(int id)
        {
            return View(PetugasDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(PetugasViewModel model)
        {
            return CreateEdit(model);
        }
        public ActionResult CreateEdit(PetugasViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (PetugasDataAccess.Update(model))
                    {
                        return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = false, message = PetugasDataAccess.Message }, JsonRequestBehavior.AllowGet);
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
            return View(PetugasDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            if (PetugasDataAccess.Delete(id))
            {
                return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, message = PetugasDataAccess.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}