using PerpustakaanDataModel;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanDataAccess
{
    public class PenerbitDataAccess
    {
        public static string Message = string.Empty;

        public static List<PenerbitViewModel> GetAll()
        {
            List<PenerbitViewModel> result = new List<PenerbitViewModel>();
            using (var db = new PerpusContext())
            {
                result = (from pnb in db.Penerbit
                          select new PenerbitViewModel
                          {
                              Id = pnb.Id,
                              KodePenerbit = pnb.KodePenerbit,
                              NamaPenerbit = pnb.NamaPenerbit,
                              AlamatPenerbit = pnb.AlamatPenerbit,
                              Telepon= pnb.Telepon
                          }).ToList();
            }
            return result;
        }

        public static bool Update(PenerbitViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    if (model.Id == 0)
                    {
                        Penerbit pnb = new Penerbit();
                        pnb.Id=model.Id ;
                        pnb.KodePenerbit=model.KodePenerbit;
                        pnb.NamaPenerbit=model.NamaPenerbit;
                        pnb.AlamatPenerbit=model.AlamatPenerbit;
                        pnb.Telepon = model.Telepon;
                        pnb.CreatedBy = "Admin";
                        pnb.Created = DateTime.Now;
                        db.Penerbit.Add(pnb);
                        db.SaveChanges();
                    }
                    else
                    {
                        Penerbit pnb = db.Penerbit.Where(o => o.Id == model.Id).FirstOrDefault();
                        if (pnb != null)
                        {
                            pnb.KodePenerbit = model.KodePenerbit;
                            pnb.NamaPenerbit = model.NamaPenerbit;
                            pnb.AlamatPenerbit = model.AlamatPenerbit;
                            pnb.Telepon = model.Telepon;
                            pnb.ModifiedBy = "Admin";
                            pnb.Modified = DateTime.Now;
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

        public static PenerbitViewModel GetById(int id)
        {
            PenerbitViewModel result = new PenerbitViewModel();
            using (var db = new PerpusContext())
            {
                result = (from pnb in db.Penerbit
                          where pnb.Id==id
                          select new PenerbitViewModel
                        {
                            Id = pnb.Id,
                            KodePenerbit = pnb.KodePenerbit,
                            NamaPenerbit = pnb.NamaPenerbit,
                            AlamatPenerbit = pnb.AlamatPenerbit,
                            Telepon = pnb.Telepon
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
                    Penerbit pnb = db.Penerbit.Where(o => o.Id == id).FirstOrDefault();
                    if (pnb != null)
                    {
                        db.Penerbit.Remove(pnb);
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
