using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap21.Models;
namespace baitap21.Controllers
{
    public class SinhVienController : Controller
    {
        QuanLySinhVienEntities db = new QuanLySinhVienEntities();
        // GET: SinhVien
        public ActionResult Index()
        {
            List<Sinhvien> sv = db.Sinhvien.ToList();

            return View(sv);
        }
        public ActionResult them()
        {
            return View(new Sinhvien());
        }
        [HttpPost]
        public ActionResult them(Sinhvien sinhvien)
        {

            if (string.IsNullOrEmpty(sinhvien.Masv))
            {
                ModelState.AddModelError("", "Vui lòng nhập mã sinh viên.");
                return View(sinhvien);
            }

            try
            {
                db.Sinhvien.Add(sinhvien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã xảy ra lỗi. Vui lòng thử lại sau.");
                return View(sinhvien);
            }
        }
        public ActionResult sua(string Masv)
        {
            var sua = db.Sinhvien.Find(Masv);
            return View(sua);
        }
        [HttpPost]
        public ActionResult sua(Sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var suasinhvien = db.Sinhvien.Find(sinhvien.Masv);
                    suasinhvien.Ho = sinhvien.Ho;
                    suasinhvien.Ten = sinhvien.Ten;
                    suasinhvien.TenViet = sinhvien.TenViet;
                    suasinhvien.DOB = sinhvien.DOB;
                    suasinhvien.Noisinh = sinhvien.Noisinh;
                    suasinhvien.goitinh = sinhvien.goitinh;
                    suasinhvien.diachi = sinhvien.diachi;
                    suasinhvien.tel = sinhvien.tel;
                    suasinhvien.mobile = sinhvien.mobile;
                    suasinhvien.email = sinhvien.email;
                    suasinhvien.emailDCT = sinhvien.emailDCT;
                    suasinhvien.diemTS = sinhvien.diemTS; 
                    suasinhvien.accno = sinhvien.accno;
                    suasinhvien.password = sinhvien.password;
                    suasinhvien.status = sinhvien.status;
                    suasinhvien.ghichu = sinhvien.ghichu;
                    suasinhvien.makh = sinhvien.makh;
                    suasinhvien.scmnd = sinhvien.scmnd;
                    suasinhvien.tenKD = sinhvien.tenKD;
                    suasinhvien.special = sinhvien.special;
                    suasinhvien.diemRl = sinhvien.diemRl;
                    suasinhvien.QDTT = sinhvien.QDTT;
                    suasinhvien.SCMND_IMG = sinhvien.SCMND_IMG;
                    suasinhvien.CapDT = sinhvien.CapDT;
                    suasinhvien.ks = sinhvien.ks;
                    suasinhvien.dantoc = sinhvien.dantoc;

                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Đã xảy ra lỗi. Vui lòng thử lại sau.");
                }
            }

            return View(sinhvien);
        }
        public ActionResult xoa(string Masv)
        {
            var xoa = db.Sinhvien.Find(Masv);
            if (xoa == null)
            {
                return HttpNotFound();
            }

            try
            {
                db.Sinhvien.Remove(xoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã xảy ra lỗi khi xóa sinh viên. Vui lòng thử lại sau.");
                return View("Index");
            }
        }
    }

}
