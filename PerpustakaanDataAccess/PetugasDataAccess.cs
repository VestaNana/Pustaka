using PerpustakaanDataModel;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanDataAccess
{
    public class PetugasDataAccess
    {
        public static string Message = string.Empty;
        public static List<PetugasViewModel> GetAll()
        {
            List<PetugasViewModel> result = new List<PetugasViewModel>();
            using (var db = new PerpusContext())
            {
                result = (from pts in db.Petugas
                          select new PetugasViewModel
                          {
                              Id = pts.Id,
                              KodePetugas = pts.KodePetugas,
                              Nama = pts.Nama
                              //CreatedBy = ag.CreatedBy,
                              //Created = ag.Created,
                              //ModifiedBy = ag.ModifiedBy,
                              //Modified = ag.Modified
                          }).ToList();
            }
            return result;
        }

        public static bool Update(PetugasViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    if (model.Id == 0)
                    {
                        Petugas petugas = new Petugas
                        {
                            KodePetugas = model.KodePetugas,
                            Nama = model.Nama
                            //CreatedBy = model.CreatedBy,
                            //Created = model.Created,
                            //ModifiedBy = model.Modified,
                            //Modified = model.Modified
                        };
                        db.Petugas.Add(petugas);
                        db.SaveChanges();
                    }
                    else
                    {
                        Petugas petugas = db.Petugas.Where(o => o.Id == model.Id).FirstOrDefault();
                        if (petugas != null)
                        {
                            petugas.KodePetugas = model.KodePetugas;
                            petugas.Nama = model.Nama;
                            //anggota.CreatedBy = model.CreatedBy;
                            //anggota.Created = model.Created;
                            //anggota.ModifiedBy = model.ModifiedBy;
                            //anggota.Modified = model.Modified;
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
        public static PetugasViewModel GetById(int id)
        {
            PetugasViewModel result = new PetugasViewModel();
            using (var db = new PerpusContext())
            {
                result = (from pts in db.Petugas
                          where pts.Id == id
                          select new PetugasViewModel
                          {
                              Id = pts.Id,
                              KodePetugas = pts.KodePetugas,
                              Nama = pts.Nama
                              //CreatedBy = ag.CreatedBy,
                              //Created = ag.Created,
                              //ModifiedBy = ag.ModifiedBy,
                              //Modified = ag.Modified
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
                    Petugas petugas = db.Petugas.Where(o => o.Id == id).FirstOrDefault();
                    if (petugas != null)
                    {
                        db.Petugas.Remove(petugas);
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
