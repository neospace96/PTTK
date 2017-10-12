using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanMayTinh.Models;

namespace BanMayTinh.Controllers
{
    public class HomeController : Controller
    {
        dbQuanLyMayTinhDataContext data = new dbQuanLyMayTinhDataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DacSac()
        {
            var sanpham = data.SanPhams.OrderByDescending(a => a.GiaBan).Take(4).ToList();
            //var sanpham = from sp in data.SanPhams orderby sp.MaSanPham ascending select sp;
            return PartialView(sanpham);
        }

        public ActionResult XuHuong()
        {
            var sanpham = data.SanPhams.OrderByDescending(a => a.TenSanPham).Take(4).ToList();
            //var sanpham = from sp in data.SanPhams orderby sp.MaSanPham ascending select sp;
            return PartialView(sanpham);
        }

        public ActionResult TopSales()
        {
            var sanpham = data.SanPhams.OrderBy(a => a.GiaBan).Take(4).ToList();
            //var sanpham = from sp in data.SanPhams orderby sp.MaSanPham ascending select sp;
            return PartialView(sanpham);
        }

    }
}