using PerpustakaanDataModel;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanDataAccess
{
    public class AnggotaDataAccess
    {
        public static string Message = string.Empty;
        public static List<AnggotaViewModel> GetAll()
        {
            List<AnggotaViewModel> result = new List<AnggotaViewModel>();
            using (var db = new PerpusContext())
            {
                result = (from ag in db.Anggota
                           //join pdf in db.Pendaftaran
                           //on ag.KodeAnggota equals pdf.KodeKartu
                          select new AnggotaViewModel
                          {
                              Id = ag.Id,
                              KodeAnggota = ag.KodeAnggota,
                              Nama = ag.Nama,
                              Alamat = ag.Alamat,
                              Email = ag.Email,
                              Telepon = ag.Telepon
                              //CreatedBy = ag.CreatedBy,
                              //Created = ag.Created,
                              //ModifiedBy = ag.ModifiedBy,
                              //Modified = ag.Modified
                          }).ToList();
            }
            return result;
        }

        public static List<AnggotaViewModel> GetByPendaftaran(string kodeKartu)
        {
            List<AnggotaViewModel> result = new List<AnggotaViewModel>();

            using (var db = new PerpusContext())
            {
                result = (from ag in db.Anggota
                          //join pdf in db.Pendaftaran
                          //on ag.KodeAnggota equals pdf.KodeKartu
                          select new AnggotaViewModel
                          {
                              Id = ag.Id,
                              KodeAnggota = ag.KodeAnggota,
                              Nama = ag.Nama,
                              Alamat = ag.Alamat,
                              Email = ag.Email,
                              Telepon = ag.Telepon
                              //CreatedBy = ag.CreatedBy,
                              //Created = ag.Created,
                              //ModifiedBy = ag.ModifiedBy,
                              //Modified = ag.Modified
                          }).ToList();
            }

            return result;
        }

        public static bool Update(AnggotaViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    if (model.Id == 0)
                    {
                        Anggota anggota = new Anggota
                        {
                            KodeAnggota = model.KodeAnggota,
                            Nama = model.Nama,
                            Alamat = model.Alamat,
                            Email = model.Email,
                            Telepon = model.Telepon
                            //CreatedBy = model.CreatedBy,
                            //Created = model.Created,
                            //ModifiedBy = model.Modified,
                            //Modified = model.Modified
                        };
                        db.Anggota.Add(anggota);
                        db.SaveChanges();
                    }
                    else
                    {
                        Anggota anggota = db.Anggota.Where(o => o.Id == model.Id).FirstOrDefault();
                        if (anggota != null)
                        {
                            anggota.KodeAnggota = model.KodeAnggota;
                            anggota.Nama = model.Nama;
                            anggota.Alamat = model.Alamat;
                            anggota.Email = model.Email;
                            anggota.Telepon = model.Telepon;
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
        public static AnggotaViewModel GetById(int id)
        {
            AnggotaViewModel result = new AnggotaViewModel();
            using (var db = new PerpusContext())
            {
                result = (from ag in db.Anggota
                          //join pdf in db.Pendaftaran
                          //on ag.KodeAnggota equals pdf.KodeKartu
                         where ag.Id == id
                         select new AnggotaViewModel
                            {
                                Id = ag.Id,
                                KodeAnggota = ag.KodeAnggota,
                                Nama = ag.Nama,
                                Alamat = ag.Alamat,
                                Email = ag.Email,
                                Telepon = ag.Telepon
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
                    Anggota anggota = db.Anggota.Where(o => o.Id == id).FirstOrDefault();
                    if (anggota != null)
                    {
                        db.Anggota.Remove(anggota);
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
