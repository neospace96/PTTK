using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SadiShop.Models;

using PagedList;
using PagedList.Mvc;
namespace SadiShop.Controllers
{
    public class ShopController : Controller
    {
        dbQLMayTinhDataContext data = new dbQLMayTinhDataContext();
        //--------------------------------HIỂN THỊ SẢN PHẨM TRANG INDEX--------------------------------
        private List<SanPham> Laysanphammoi(int count)
        {
            return data.SanPhams.OrderByDescending(a => a.MaSanPham).Take(count).ToList();
        }

        public ActionResult XemNhanh(int id)
        {
            //if (IsNullOrEmpty(id))
            //{
            //    return View();
            //}
            var sanpham = data.SanPhams.SingleOrDefault(n => n.MaSanPham == id);
            var nhasanxuat = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == sanpham.MaThuongHieu);
            ViewBag.nsx = nhasanxuat.TenThuongHieu;
            //var sanpham = (from sp
            //               in data.SanPhams
            //               where sp.MaSanPham == id
            //               select sp
            //               ).SingleOrDefault();
            return PartialView("XemNhanh", sanpham);
        }

        // GET: Shop
        public ActionResult Index()
        {
            var sanphammoi = Laysanphammoi(6);
            return View(sanphammoi);
        }



        //-------------------------------HIỂN THỊ SẢN PHẨM THEO LOẠI--------------------------------
        //Acer
        public ActionResult HienThiSanPhamAcer(int? page)
        {
            //page 
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var TenThuongHieu = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == 1000);
            ViewBag.TenThuongHieu = TenThuongHieu.TenThuongHieu;
            //hienthisanpham

            var sanpham = from sp in data.SanPhams where sp.MaThuongHieu == 1000 select sp;
            int sl = 0;
            foreach (var count in sanpham)
            {
                sl++;
            }
            ViewBag.soluong = sl;
            return View(sanpham.ToPagedList(pageNum, pageSize));
        }
        //Macbook
        public ActionResult HienThiSanPhamMacbook(int? page)
        {
            //page 
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var TenThuongHieu = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == 1001);
            ViewBag.TenThuongHieu = TenThuongHieu.TenThuongHieu;
            //hienthisanpham

            var sanpham = from sp in data.SanPhams where sp.MaThuongHieu == 1001 select sp;
            int sl = 0;
            foreach (var count in sanpham)
            {
                sl++;
            }
            ViewBag.soluong = sl;
            return View(sanpham.ToPagedList(pageNum, pageSize));
        }
        //Asus
        public ActionResult HienThiSanPhamAsus(int? page)
        {
            //page 
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var TenThuongHieu = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == 1002);
            ViewBag.TenThuongHieu = TenThuongHieu.TenThuongHieu;
            //hienthisanpham

            var sanpham = from sp in data.SanPhams where sp.MaThuongHieu == 1002 select sp;
            int sl = 0;
            foreach (var count in sanpham)
            {
                sl++;
            }
            ViewBag.soluong = sl;
            return View(sanpham.ToPagedList(pageNum, pageSize));
        }
        //HP
        public ActionResult HienThiSanPhamHP(int? page)
        {
            //page 
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var TenThuongHieu = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == 1003);
            ViewBag.TenThuongHieu = TenThuongHieu.TenThuongHieu;
            //hienthisanpham

            var sanpham = from sp in data.SanPhams where sp.MaThuongHieu == 1003 select sp;
            int sl = 0;
            foreach (var count in sanpham)
            {
                sl++;
            }
            ViewBag.soluong = sl;
            return View(sanpham.ToPagedList(pageNum, pageSize));
        }
        //DELL
        public ActionResult HienThiSanPhamDell(int? page)
        {
            //page 
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var TenThuongHieu = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == 1004);
            ViewBag.TenThuongHieu = TenThuongHieu.TenThuongHieu;
            //hienthisanpham

            var sanpham = from sp in data.SanPhams where sp.MaThuongHieu == 1004 select sp;
            int sl = 0;
            foreach (var count in sanpham)
            {
                sl++;
            }
            ViewBag.soluong = sl;
            return View(sanpham.ToPagedList(pageNum, pageSize));
        }
        //Toshiba
        public ActionResult HienThiSanPhamToshiba(int? page)
        {
            //page 
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var TenThuongHieu = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == 1005);
            ViewBag.TenThuongHieu = TenThuongHieu.TenThuongHieu;
            //hienthisanpham

            var sanpham = from sp in data.SanPhams where sp.MaThuongHieu == 1005 select sp;
            int sl = 0;
            foreach (var count in sanpham)
            {
                sl++;
            }
            ViewBag.soluong = sl;
            return View(sanpham.ToPagedList(pageNum, pageSize));
        }
        //Microsoft
        public ActionResult HienThiSanPhamMicrosoft(int? page)
        {
            //page 
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var TenThuongHieu = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == 1006);
            ViewBag.TenThuongHieu = TenThuongHieu.TenThuongHieu;
            //hienthisanpham

            var sanpham = from sp in data.SanPhams where sp.MaThuongHieu == 1006 select sp;
            int sl = 0;
            foreach (var count in sanpham)
            {
                sl++;
            }
            ViewBag.soluong = sl;
            return View(sanpham.ToPagedList(pageNum, pageSize));
        }
        //LG Gram
        public ActionResult HienThiSanPhamLGGram(int? page)
        {
            //page 
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var TenThuongHieu = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == 1007);
            ViewBag.TenThuongHieu = TenThuongHieu.TenThuongHieu;
            //hienthisanpham

            var sanpham = from sp in data.SanPhams where sp.MaThuongHieu == 1007 select sp;
            int sl = 0;
            foreach (var count in sanpham)
            {
                sl++;
            }
            ViewBag.soluong = sl;
            return View(sanpham.ToPagedList(pageNum, pageSize));
        }                                                               

        

        //------------------------------HIỂN THỊ CHI TIẾT--------------------------------
        public ActionResult ChiTiet(int id)
        {
            var sanpham = data.SanPhams.SingleOrDefault(n => n.MaSanPham == id);
            var nhasanxuat = data.ThuongHieus.SingleOrDefault(n => n.MaThuongHieu == sanpham.MaThuongHieu);
            ViewBag.nsx = nhasanxuat.TenThuongHieu;
            return View(sanpham);
        }

        public ActionResult SanPhamKhac()
        {
            var sanphamkhac = Laysanphammoi(4);
            return PartialView(sanphamkhac);
        }
        //--------------------------------XU HƯỚNG MỚI--------------------------------
        public ActionResult XuHuongMoi()
        {
            var sanpham = from sp in data.SanPhams orderby sp.MaSanPham ascending select sp;
            return PartialView(sanpham);
        }

        //--------------------------------SẢN PHẨM SALE--------------------------------
        private List<SanPham> SanPhamSale(int count)
        {
            return data.SanPhams.OrderByDescending(a => a.GiaBan).Take(count).ToList();
        }

        public ActionResult Sale()
        {
            var sanphamsale = SanPhamSale(10);
            return View(sanphamsale);
        }



        //-------------------------------ABOUT + LIÊN HỆ--------------------------------
        public ActionResult About()
        {
            return View();
        }

        public ActionResult LienHe()
        {
            return View();
        }

        //------------------------------TÌM KIỂM-----------------------------------------
        [HttpPost]
        public ActionResult KetQuaTimKiem(int? page, FormCollection f)
        {
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            string sTuKhoa = f["txtTimKiem"].ToString();
            ViewBag.TuKhoa = sTuKhoa;
            var lstSP = data.SanPhams.Where(n => n.TenSanPham.Contains(sTuKhoa)).ToList().OrderByDescending(n => n.MaSanPham).ToPagedList(pageNumber, pageSize);
            if (lstSP.Count == 0)
            {
                ViewBag.ThongBao = "Không có sản phẩm phù hợp";
            }
            else
            {
                ViewBag.ThongBao = "Đã tìm thấy " + lstSP.Count + " kết quả!";
            }

            return View(lstSP);
        }

        [HttpGet]
        public ActionResult KetQuaTimKiem(int? page, string sTuKhoa)
        {
            ViewBag.TuKhoa = sTuKhoa;
            List<SanPham> sp = data.SanPhams.Where(n => n.TenSanPham.Contains(sTuKhoa)).ToList();
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            if (sp.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy sản phẩm nào :(";
                return View(data.SanPhams.OrderBy(n => n.TenSanPham).ToPagedList(pageNumber, pageSize));
            }
            else
            {
                ViewBag.ThongBao = "Đã tìm thấy " + sp.Count + " kết quả";
                return View(sp.OrderBy(n => n.TenSanPham).ToPagedList(pageNumber, pageSize));
            }
        }

    }
}
