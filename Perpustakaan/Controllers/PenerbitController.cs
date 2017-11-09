using PerpustakaanViewModel;
using PerpustakaanDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Perpustakaan.Controllers
{
    public class PenerbitController : Controller
    {
        // GET: Penerbit
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(PenerbitDataAccess.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PenerbitViewModel model)
        {
            return CreateEdit(model);
        }

        public ActionResult Edit(int id)
        {
            return View(PenerbitDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(PenerbitViewModel model)
        {
            return CreateEdit(model);
        }

        public ActionResult CreateEdit(PenerbitViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (PenerbitDataAccess.Update(model))
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
            return View(PenerbitDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            if (PenerbitDataAccess.Delete(id))
            {
                return Json(new { success = true, Message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, Message = PenerbitDataAccess.Message }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false, Message = "Error" }, JsonRequestBehavior.AllowGet);
        }
    }    
}
    