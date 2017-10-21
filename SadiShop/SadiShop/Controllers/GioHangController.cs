﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SadiShop.Models;
using Microsoft.AspNet.Identity;

namespace SadiShop.Controllers
{
    public class GioHangController : Controller
    {
        dbQLMayTinhDataContext data = new dbQLMayTinhDataContext();

        //private ActionResult RedirectToLocal(string returnUrl)
        //{
        //    if (Url.IsLocalUrl(returnUrl))
        //    {
        //        return Redirect(returnUrl);
        //    }
        //    return RedirectToAction("Index", "Shop");
        //}

        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGiohang = Session["Giohang"] as List<GioHang>;
            if (lstGiohang == null)
            {
                lstGiohang = new List<GioHang>();
                Session["Giohang"] = lstGiohang;
            }
            return lstGiohang;
        }
        // GET: GioHang
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        //THEM GIO HANG
        public ActionResult ThemGioHang(int sMaSanPham, string returnUrl)
        {
            List<GioHang> lstGiohang = LayGioHang();
            GioHang sanpham = lstGiohang.Find(n => n.sMaSanPham == sMaSanPham);
            if(sanpham == null)
            {
                sanpham = new GioHang(sMaSanPham);
                lstGiohang.Add(sanpham);
                return RedirectToAction("Index", "Shop");
               // return RedirectToLocal(returnUrl);
            }
            else
            {
                sanpham.iSoLuong++;
                return RedirectToAction("Index", "Shop");
                //return RedirectToLocal(returnUrl);
            }
        }
        //TINH SO LUONG
        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<GioHang> lstGiohang = Session["GioHang"] as List<GioHang>;
            if (lstGiohang != null)
            {
                iTongSoLuong = lstGiohang.Sum(n => n.iSoLuong);
            }
            return iTongSoLuong;
        }
        //TONG TIEN
        private double TongTien()
        {
            double iTongTien = 0;
            List<GioHang> lstGiohang = Session["GioHang"] as List<GioHang>;
            if(lstGiohang!= null)
            {
                iTongTien = lstGiohang.Sum(n => n.dThanhTien);
            }
            return iTongTien;
        }
        //GIO HANG
        public ActionResult GioHang()
        {
            List<GioHang> lstGiohang = LayGioHang();
            if(lstGiohang.Count == 0)
            {
                return RedirectToAction("Index", "Shop");
            }
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return View(lstGiohang);
        }
        //GIO HANG MENU
        public ActionResult GioHangPartial()
        {
            List<GioHang> lstGiohang = LayGioHang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return PartialView(lstGiohang);
        }

        //XOA SAN PHAM
        public ActionResult XoaGioHang(int sMaSP)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.SingleOrDefault(n => n.sMaSanPham == sMaSP);
            if(sanpham != null)
            {
                lstGioHang.RemoveAll(n => n.sMaSanPham == sMaSP);
                return RedirectToAction("GioHang");
            }
            if(lstGioHang.Count == 0)
            {
                return RedirectToAction("Index", "Shop");
            }
            return RedirectToAction("GioHang");
        }

        //CAP NHAT LAI GIO HANG
        public ActionResult CapNhatGioHang (int sMaSP, FormCollection f)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.SingleOrDefault(n => n.sMaSanPham == sMaSP);
            if(sanpham != null)
            {
                sanpham.iSoLuong = int.Parse(f["txtSoLuong"].ToString());
            }
            return RedirectToAction("GioHang");
        }

        //XOA TAT CA TRONG GIO HANG
        public ActionResult XoaTatCaGioHang()
        {
            List<GioHang> lstGioHang = LayGioHang();
            lstGioHang.Clear();
            return RedirectToAction("Index", "Shop");
        }

        //[HttpGet]
        //[Authorize]
        //public ActionResult DatHang()
        //{
        //    //if(Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == "")
        //    //{
        //    //    return RedirectToAction("DangNhap", "NguoiDung");
        //    //}
        //    if (Session["GioHang"] == null)
        //    {
        //        return RedirectToAction("Index", "Shop");
        //    }
        //    List<GioHang> lstGioHang = LayGioHang();
        //    ViewBag.TongSoLuong = TongSoLuong();
        //    ViewBag.TongTien = TongTien();
        //    return View(lstGioHang);
        //}
        [Authorize]
        public ActionResult DatHang(FormCollection collection)
        {
            DonDatHang ddh = new DonDatHang();
            List<GioHang> gh = LayGioHang();
            ddh.MaTaiKhoan = User.Identity.GetUserId();
            ddh.NgayDatHang = DateTime.Now;
            ddh.ThanhTien = TongTien();
            ddh.MaTinhTrang = 1;
            data.DonDatHangs.InsertOnSubmit(ddh);
            data.SubmitChanges();
            foreach (var item in gh)
            {
                ChiTietDonDatHang ctdh = new ChiTietDonDatHang();
                ctdh.MaDonDatHang = ddh.MaDonDatHang;
                ctdh.MaSanPham = item.sMaSanPham;
                ctdh.SoLuong = item.iSoLuong;
                data.ChiTietDonDatHangs.InsertOnSubmit(ctdh);
            }
            data.SubmitChanges();
            Session["GioHang"] = null;
            return RedirectToAction("XacNhanDonHang", "GioHang");

        }

        [HttpGet]
        [Authorize]
        public ActionResult ThongTinKhachHang()
        {
            var tt = data.AspNetUsers.SingleOrDefault(n => n.Id == User.Identity.GetUserId());
            if(tt == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tt);
        }

        [HttpPost]
        public ActionResult ThongTinKhachHang(AspNetUser user)
        {
            var user1 = data.AspNetUsers.SingleOrDefault(n => n.Id == user.Id);
            if(user1 == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            user1.FullName = user.FullName;
            user1.PhoneNumber = user.PhoneNumber;
            user1.Address = user.Address;
            data.SubmitChanges();
            return Redirect("DatHang");
        }

        public PartialViewResult ThongTinGioHang()
        {
            List<GioHang> gh = LayGioHang();
            ViewBag.TongTien = TongTien();
            return PartialView(gh);
        }

        public ActionResult XacNhanDonHang()
        {
            return View();
        }

        public ActionResult LichSuDonHang()
        {
            return View(data.DonDatHangs.Where(n => n.MaTaiKhoan == User.Identity.GetUserId()).ToList());
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

        public ActionResult HuyDonHang(int id)
        {
            DonDatHang ddh = data.DonDatHangs.SingleOrDefault(n => n.MaDonDatHang == id);
            if (ddh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ddh.MaTinhTrang = 4;
            data.SubmitChanges();
            return RedirectToAction("LichSuDonHang", "GioHang");
        }
    }
}