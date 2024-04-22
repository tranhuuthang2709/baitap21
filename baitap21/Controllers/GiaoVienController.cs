using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap21.Models;

namespace baitap21.Controllers
{
    public class GiaoVienController : Controller
    {
        QuanLySinhVienEntities db = new QuanLySinhVienEntities();
        public ActionResult Index()
        {
            List<Giaovien> ketqua = db.Giaovien.ToList();
            return View(ketqua);
        }
      
        public ActionResult them()
        {
            return View(new Giaovien());
        }
        [HttpPost]
        public ActionResult them(Giaovien giaovien)
        {
            if (string.IsNullOrEmpty(giaovien.MaGV))
            {
                ModelState.AddModelError("", "Vui lòng nhập mã giáo viên.");
                return View(giaovien);
            }

            try
            {
                db.Giaovien.Add(giaovien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã xảy ra lỗi. Vui lòng thử lại sau.");
                return View(giaovien);
            }
        }

        public ActionResult sua(string MaGV)
        {
            var sua = db.Giaovien.Find(MaGV);
            return View(sua);
        }
        [HttpPost]
        public ActionResult sua(Giaovien giaovien)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var suagiaovien = db.Giaovien.Find(giaovien.MaGV);
                    suagiaovien.HotenGV = giaovien.HotenGV;
                    suagiaovien.DOB = giaovien.DOB;
                    suagiaovien.gioitinh = giaovien.gioitinh;
                    suagiaovien.diachi = giaovien.diachi;
                    suagiaovien.tel = giaovien.tel;
                    suagiaovien.mobile = giaovien.mobile;
                    suagiaovien.email = giaovien.email;
                    suagiaovien.emailDCT = giaovien.emailDCT;
                    suagiaovien.maDV = giaovien.maDV;
                    suagiaovien.hocvi = giaovien.hocvi;
                    suagiaovien.chucdanh = giaovien.chucdanh;
                    suagiaovien.chucvu = giaovien.chucvu;
                    suagiaovien.password = giaovien.password;
                    suagiaovien.website = giaovien.website;
                    suagiaovien.tenviet = giaovien.tenviet;
                    suagiaovien.status = giaovien.status;
                    suagiaovien.accright = giaovien.accright;

                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Đã xảy ra lỗi. Vui lòng thử lại sau.");
                }
            }

            return View(giaovien);
        }
        public ActionResult xoa(string MaGV)
        {
            var xoa = db.Giaovien.Find(MaGV);
            if (xoa == null)
            {
                return HttpNotFound();
            }

            try
            {
                db.Giaovien.Remove(xoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã xảy ra lỗi khi xóa giáo viên. Vui lòng thử lại sau.");
                return View("Index");
            }
        }
    }

}
