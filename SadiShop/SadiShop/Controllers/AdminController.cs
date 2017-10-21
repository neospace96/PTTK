using SadiShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SadiShop.Controllers
{
    public class AdminController : Controller
    {
        dbQLMayTinhDataContext data = new dbQLMayTinhDataContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SanPham()
        {
            return View(data.SanPhams.ToList());
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            var tendn = collection["username"];
            var matkhau = collection["password"];

            Admin ad = data.Admins.SingleOrDefault(n => n.TenDangNhapAdmin == tendn && n.MatKhauDangNhapAdmin == matkhau);
            if (ad != null)
            {
                Session["TaiKhoanAdmin"] = ad;
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.ThongBao = "Sai thông tin đăng nhập";
            }
            return View();
        }

        //-------------------------------------------SAN PHAM----------------------------------------------------------------------
        //tạo list danh sách
        [HttpGet]
        public ActionResult ThemMoiSanPham()
        {
            ViewBag.MaThuongHieu = new SelectList(data.ThuongHieus.ToList().OrderBy(n => n.TenThuongHieu), "MaThuongHieu", "TenThuongHieu");
            ViewBag.MaThuongHieu = new SelectList(data.ThuongHieus.ToList().OrderBy(n => n.TenThuongHieu), "MaThuongHieu", "TenThuongHieu");
            return View();
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoiSanPham(SanPham sp, HttpPostedFileBase fileUpload)
        {
            ViewBag.MaThuongHieu = new SelectList(data.ThuongHieus.ToList().OrderBy(n => n.TenThuongHieu), "MaThuongHieu", "TenThuongHieu");
            ViewBag.MaThuongHieu = new SelectList(data.ThuongHieus.ToList().OrderBy(n => n.TenThuongHieu), "MaThuongHieu", "TenThuongHieu");
            if (fileUpload == null)
            {
                ViewBag.ThongBao = "Vui lòng chọn hình sản phẩm";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileUpload.FileName);
                    var path = Path.Combine(Server.MapPath("~/images/hinhsanpham/"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                        return View();
                    }
                    else
                    {
                        fileUpload.SaveAs(path);
                    }
                    sp.Hinh1 = fileName;
                    data.SanPhams.InsertOnSubmit(sp);
                    data.SubmitChanges();
                }
                return RedirectToAction("SanPham");
            }
        }

        public ActionResult ChiTietSanPham(int id)
        {
            SanPham sp = data.SanPhams.SingleOrDefault(n => n.MaSanPham == id);
            //ViewBag.MaSanPham = sp.MaSanPham;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }

        [HttpGet]
        public ActionResult XoaSanPham(int id)
        {
            SanPham sp = data.SanPhams.SingleOrDefault(n => n.MaSanPham == id);
            //ViewBag.MaSanPham = sp.MaSanPham;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }

        [HttpPost, ActionName("XoaSanPham")]
        public ActionResult XacNhanXoaSanPham(int id)
        {
            SanPham sp = data.SanPhams.SingleOrDefault(n => n.MaSanPham == id);
            ViewBag.Anh = sp.Hinh1;
            ViewBag.MaSanPham = sp.MaSanPham;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.SanPhams.DeleteOnSubmit(sp);
            data.SubmitChanges();
            return RedirectToAction("SanPham");
        }

        [HttpGet]
        public ActionResult SuaSanPham(int id)
        {
            SanPham sp = data.SanPhams.SingleOrDefault(n => n.MaSanPham == id);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.MaThuongHieu = new SelectList(data.ThuongHieus.ToList().OrderBy(n => n.TenThuongHieu), "MaThuongHieu", "TenThuongHieu");
            ViewBag.MaThuongHieu = new SelectList(data.ThuongHieus.ToList().OrderBy(n => n.TenThuongHieu), "MaThuongHieu", "TenThuongHieu");
            return View(sp);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaSanPham(SanPham sp, HttpPostedFileBase fileUpload)
        {

            if (ModelState.IsValid)
            {


                SanPham sp1 = data.SanPhams.SingleOrDefault(n => n.MaSanPham == sp.MaSanPham);
                if (sp1 == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                 if (fileUpload != null)
                {
                    var fileName = Path.GetFileName(fileUpload.FileName);
                    var path = Path.Combine(Server.MapPath("~/images/hinhsanpham/"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileUpload.SaveAs(path);
                        sp1.Hinh1 = fileName;
                       // data.SubmitChanges();
                    }
                }
                sp1.TenSanPham = sp.TenSanPham;
                sp1.MaThuongHieu = sp.MaThuongHieu;
                sp1.MaThuongHieu = sp.MaThuongHieu;
                sp1.Thongtin = sp.Thongtin;
                sp1.GiaBan = sp.GiaBan;
                data.SubmitChanges();
            }
            return RedirectToAction("SanPham");
        }

        //----------------------------------------------LOAI SAN PHAM---------------------------------------------
        public ActionResult ThuongHieu()
        {
            return View(data.ThuongHieus.ToList());
        }

        [HttpGet]
        public ActionResult ThemMoiThuongHieu()
        {
            return View();
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoiThuongHieu(ThuongHieu sp)
        {
            data.ThuongHieus.InsertOnSubmit(sp);
            data.SubmitChanges();
            return RedirectToAction("ThuongHieu");
        }

        public ActionResult ChiTietThuongHieu(int id)
        {
            ThuongHieu sp = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == id);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }

        [HttpGet]
        public ActionResult XoaThuongHieu(int id)
        {
            ThuongHieu sp = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == id);
            //ViewBag.MaSanPham = sp.MaSanPham;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }

        [HttpPost, ActionName("XoaThuongHieu")]
        public ActionResult XacNhanXoaThuongHieu(int id)
        {
            ThuongHieu sp = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == id);
            ViewBag.MaThuongHieuSanPham = sp.MaThuongHieu;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.ThuongHieus.DeleteOnSubmit(sp);
            data.SubmitChanges();
            return RedirectToAction("ThuongHieu");
        }

        [HttpGet]
        public ActionResult SuaThuongHieu(int id)
        {
            ThuongHieu sp = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == id);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaThuongHieu(ThuongHieu sp)
        {

            if (ModelState.IsValid)
            {
                ThuongHieu sp1 = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == sp.MaThuongHieu);
                if (sp1 == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                sp1.TenThuongHieu = sp.TenThuongHieu;
                data.SubmitChanges();
            }
            return RedirectToAction("ThuongHieu");
        }
        //----------------------------------------------NHA SAN XUAT----------------------------------------------
        //public ActionResult NhaSanXuat()
        //{
        //    return View(data.ThuongHieus.ToList());
        //}

        //[HttpGet]
        //public ActionResult ThemMoiNhaSanXuat()
        //{
        //    return View();
        //}


        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult ThemMoiNhaSanXuat(NhanSanXuat sp)
        //{
        //    data.ThuongHieus.InsertOnSubmit(sp);
        //    data.SubmitChanges();
        //    return RedirectToAction("NhaSanXuat");
        //}

        //public ActionResult ChiTietNhaSanXuat(string id)
        //{
        //    NhanSanXuat sp = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == id);
        //    if (sp == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    return View(sp);
        //}

        //[HttpGet]
        //public ActionResult XoaNhaSanXuat(string id)
        //{
        //    NhanSanXuat sp = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == id);
        //    //ViewBag.MaSanPham = sp.MaSanPham;
        //    if (sp == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    return View(sp);
        //}

        //[HttpPost, ActionName("XoaNhaSanXuat")]
        //public ActionResult XacNhanXoaNhaSanXuat(string id)
        //{
        //    NhanSanXuat sp = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == id);
        //    ViewBag.MaThuongHieu = sp.MaThuongHieu;
        //    if (sp == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    data.ThuongHieus.DeleteOnSubmit(sp);
        //    data.SubmitChanges();
        //    return RedirectToAction("NhaSanXuat");
        //}

        //[HttpGet]
        //public ActionResult SuaNhaSanXuat(string id)
        //{
        //    NhanSanXuat sp = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == id);
        //    if (sp == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    return View(sp);
        //}

        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult SuaNhaSanXuat(NhanSanXuat sp)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        NhanSanXuat sp1 = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == sp.MaThuongHieu);
        //        if (sp1 == null)
        //        {
        //            Response.StatusCode = 404;
        //            return null;
        //        }
        //        sp1.TenThuongHieu = sp.TenThuongHieu;
        //        sp1.QuocGia = sp.QuocGia;
        //        data.SubmitChanges();
        //    }
        //    return RedirectToAction("NhaSanXuat");
        //}
        //----------------------------------------------DON HANG--------------------------------------------------
        public ActionResult QuanLyDonHangChuaDyet()
        {
            return View(data.DonDatHangs.Where(n => n.MaTinhTrang == 1).ToList());
        }

        public ActionResult DaDuyet(int MaDonDatHang = 0)
        {
            DonDatHang ddh = data.DonDatHangs.SingleOrDefault(n => n.MaDonDatHang == MaDonDatHang);
            if(ddh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ddh.MaTinhTrang = 2;
            data.SubmitChanges();
            return Redirect("QuanLyDonHangChuaDyet");
        }

        public ActionResult QuanLyDonHangDaDyet()
        {
            return View(data.DonDatHangs.Where(n => n.MaTinhTrang != 1 && n.MaTinhTrang!=4).ToList());
        }

        public ActionResult DaDuyet1(int MaDonDatHang = 0)
        {
            DonDatHang ddh = data.DonDatHangs.SingleOrDefault(n => n.MaDonDatHang == MaDonDatHang);
            if (ddh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ddh.MaTinhTrang = 3;
            data.SubmitChanges();
            return Redirect("QuanLyDonHangDaDyet");
        }

        public ActionResult ChiTietDonHang(int id)
        {
            var sp = data.ChiTietDonDatHangs.Where(n => n.MaDonDatHang == id).ToList();
            //ViewBag.MaSanPham = sp.MaSanPham;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }
        //----------------------------------------------TAIKHOAN-------------------------------------------------
    }
}