using PerpustakaanDataAccess;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Perpustakaan.Controllers
{
    public class BukuController : Controller
    {
        // GET: Buku
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetByPenerbit(string kodePenerbit)
        {
            return View(BukuDataAccess.GetByPenerbit(kodePenerbit));
        }
        public ActionResult List()
        {
            return View(BukuDataAccess.GetAll());
        }
        public ActionResult Create()
        {
            ViewBag.PenerbitList = new SelectList(PenerbitDataAccess.GetAll(), "KodePenerbit", "KodePenerbit");
            return View();
        }

        [HttpPost]

        public ActionResult Create(BukuViewModel model)
        {
            return CreateEdit(model);
        }


        public ActionResult CreateEdit(BukuViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (BukuDataAccess.Update(model))
                    {
                        return Json(new { success = true, message = "Success" },
                            JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = false, message = BukuDataAccess.Message },
                            JsonRequestBehavior.AllowGet);
                    }


                }
                else
                {
                    return Json(new { success = false, message = "Please fill required fiels!" },
                            JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Edit(int id)
        {
            ViewBag.PenerbitList = new SelectList(PenerbitDataAccess.GetAll(), "KodePenerbit", "KodePenerbit");
            return View(BukuDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(BukuViewModel model)
        {
            return CreateEdit(model);
        }

        public ActionResult Delete(int id)
        {
            return View(BukuDataAccess.GetById(id));
        }
        [HttpPost]

        public ActionResult DeleteConfirm(int id)
        {
            if (BukuDataAccess.Delete(id))
            {
                return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, message = BukuDataAccess.Message }, JsonRequestBehavior.AllowGet);
            }

        }
    }
}