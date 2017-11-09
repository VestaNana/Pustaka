using PerpustakaanViewModel;
using PerpustakaanDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanDataAccess
{
    public class PemasokDataAccess
    {
        public static string Message = string.Empty;
        public static List<PemasokViewModel> GetAll()
        {
            List<PemasokViewModel> result = new List<PemasokViewModel>();
            using (var db = new PerpusContext())
            {
                result = (from pms in db.Pemasok
                          select new PemasokViewModel
                          {
                              Id = pms.Id,
                              KodePenerbit = pms.KodePenerbit,
                              KodePemasok = pms.KodePemasok,
                              NamaPemasok = pms.NamaPemasok,
                              AlamatPemasok = pms.AlamatPemasok,
                              Telepon = pms.Telepon
                          }).ToList();
            }
            return result;
        }

        public static bool Update(PemasokViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    if (model.Id == 0)
                    {
                        Pemasok pms = new Pemasok();
                           pms.Id = model.Id;
                           pms.KodePenerbit=model.KodePenerbit;
                           pms.KodePemasok=model.KodePemasok;
                           pms.NamaPemasok=model.NamaPemasok;
                           pms.AlamatPemasok=model.AlamatPemasok;
                           pms.Telepon=model.Telepon;
                           pms.CreatedBy = "Admin";
                           pms.Created = DateTime.Now;
                           db.Pemasok.Add(pms);
                           db.SaveChanges();
                    }
                    else
                    {
                        Pemasok pms = db.Pemasok.Where(o => o.Id == model.Id).FirstOrDefault();
                        if (pms != null)
                        {
                            pms.KodePenerbit = model.KodePenerbit;
                            pms.KodePemasok = model.KodePemasok;
                            pms.NamaPemasok = model.NamaPemasok;
                            pms.AlamatPemasok = model.AlamatPemasok;
                            pms.Telepon = model.Telepon;
                            pms.ModifiedBy = "Admin";
                            pms.Modified = DateTime.Now;
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                result = false;
            }
            return result;
        }

        public static PemasokViewModel GetById(int id)
        {
            PemasokViewModel result = new PemasokViewModel();
            using (var db = new PerpusContext())
            {
                result = (from pms in db.Pemasok
                          where pms.Id==id
                          select new PemasokViewModel
                          {
                              Id = pms.Id,
                              KodePenerbit = pms.KodePenerbit,
                              KodePemasok = pms.KodePemasok,
                              NamaPemasok = pms.NamaPemasok,
                              AlamatPemasok = pms.AlamatPemasok,
                              Telepon = pms.Telepon
                          }).FirstOrDefault();
            }
            return result;
        }

        public static bool Delete(int id)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    Pemasok pms = db.Pemasok.Where(o => o.Id == id).FirstOrDefault();
                    if (pms != null)
                    {
                        db.Pemasok.Remove(pms);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                result = false;
            }
            return result;
        }
    }
}
