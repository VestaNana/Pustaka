using PerpustakaanDataAccess;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Perpustakaan.Controllers
{
    public class PemasokController : Controller
    {
        // GET: Pemasok
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(PemasokDataAccess.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PemasokViewModel model)
        {
            return CreateEdit(model);
        }

        public ActionResult Edit(int id)
        {
            return View(PemasokDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(PemasokViewModel model)
        {
            return CreateEdit(model);
        }

        public ActionResult CreateEdit(PemasokViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (PemasokDataAccess.Update(model))
                    {
                        return Json(new { success = true, Message = "Success" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = false, Message = PemasokDataAccess.Message }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { success = false, Message = "Please Full Fill required Field" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, Message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(PemasokDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            if (PemasokDataAccess.Delete(id))
            {
                return Json(new { success = true, Message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, Message = PemasokDataAccess.Message }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false, Message = "Error" }, JsonRequestBehavior.AllowGet);
        }
    }     
}