using PerpustakaanDataModel;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanDataAccess
{
    public class BukuDataAccess
    {
        public static string Message = string.Empty;

        public static List<BukuViewModel> GetAll()
        {
            List<BukuViewModel> result = new List<BukuViewModel>();
            using (var db = new PerpusContext())
            {
                result = (from bk in db.Buku
                          join pnt in db.Penerbit
                          on bk.KodePenerbit equals pnt.KodePenerbit
                          select new BukuViewModel
                          {
                              Id = bk.Id,
                              KodeBuku = bk.KodeBuku,
                              Kategori = bk.Kategori,
                              KodePenerbit = bk.KodePenerbit,
                              JudulBuku = bk.JudulBuku,
                              jumlahBuku = bk.jumlahBuku,
                              Pengarang = bk.Pengarang,
                              TahunTerbit =bk.TahunTerbit
                              //CreatedBy = bk.CreatedBy,
                              //Created = bk.Created,
                              //ModifiedBy = bk.ModifiedBy,
                              //Modified = bk.Modified
                          }).ToList();
            }

            return result;
        }

        public static List<BukuViewModel> GetByPenerbit(string kodePenerbit)
        {
            List<BukuViewModel> result = new List<BukuViewModel>();

            using (var db = new PerpusContext())
            {
                result = (from bk in db.Buku
                          join pnt in db.Penerbit
                          on bk.KodePenerbit equals pnt.KodePenerbit
                          select new BukuViewModel
                          {
                              Id = bk.Id,
                              KodeBuku = bk.KodeBuku,
                              Kategori = bk.Kategori,
                              KodePenerbit = bk.KodePenerbit,
                              JudulBuku = bk.JudulBuku,
                              jumlahBuku = bk.jumlahBuku,
                              Pengarang = bk.Pengarang,
                              TahunTerbit = bk.TahunTerbit
                              //CreatedBy = bk.CreatedBy,
                              //Created = bk.Created,
                              //ModifiedBy = bk.ModifiedBy,
                              //Modified = bk.Modified
                          }).ToList();
            }

            return result;
        }

        public static bool Update(BukuViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    if (model.Id == 0)
                    {
                        Buku buku = new Buku();
                        buku.KodeBuku = model.KodeBuku;
                        buku.Kategori = model.Kategori;
                        buku.KodePenerbit = model.KodePenerbit;
                        buku.JudulBuku = model.JudulBuku;
                        buku.jumlahBuku = model.jumlahBuku;
                        buku.Pengarang = model.Pengarang;
                        buku.TahunTerbit = model.TahunTerbit;
                              //buku.CreatedBy = model.CreatedBy;
                              //buku.Created = model.Created;
                              //buku.ModifiedBy = model.ModifiedBy;
                              //buku.Modified = model.Modified;
                        db.Buku.Add(buku);
                        db.SaveChanges();
                    }
                    else
                    {
                        Buku buku = db.Buku.Where(o => o.Id == model.Id).FirstOrDefault();
                        if (buku != null)
                        {
                            buku.KodeBuku = model.KodeBuku;
                            buku.Kategori = model.Kategori;
                            buku.KodePenerbit = model.KodePenerbit;
                            buku.JudulBuku = model.JudulBuku;
                            buku.jumlahBuku = model.jumlahBuku;
                            buku.Pengarang = model.Pengarang;
                            buku.TahunTerbit = model.TahunTerbit;
                            //buku.CreatedBy = model.CreatedBy;
                            //buku.Created = model.Created;
                            //buku.ModifiedBy = model.ModifiedBy;
                            //buku.Modified = model.Modified;
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
        public static BukuViewModel GetById(int id)
        {
            BukuViewModel result = new BukuViewModel();
            using (var db = new PerpusContext())
            {
                result = (from bk in db.Buku
                          join pnt in db.Penerbit
                          on bk.KodePenerbit equals pnt.KodePenerbit
                          where bk.Id == id
                          select new BukuViewModel
                          {
                              Id = bk.Id,
                              KodeBuku = bk.KodeBuku,
                              Kategori = bk.Kategori,
                              KodePenerbit = bk.KodePenerbit,
                              JudulBuku = bk.JudulBuku,
                              jumlahBuku = bk.jumlahBuku,
                              Pengarang = bk.Pengarang,
                              TahunTerbit = bk.TahunTerbit
                              //CreatedBy = bk.CreatedBy,
                              //Created = bk.Created,
                              //ModifiedBy = bk.ModifiedBy,
                              //Modified = bk.Modified
                          }).FirstOrDefault();
                //result = db.MST_Department.Where(o => o.Id == id).FirstOrDefault();
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
                    Buku buku = db.Buku.Where(o => o.Id == id).FirstOrDefault();
                    if (buku != null)
                    {
                        db.Buku.Remove(buku);
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
