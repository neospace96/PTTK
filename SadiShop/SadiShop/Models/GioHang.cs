using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SadiShop.Models
{
    public class GioHang
    {
        dbQLMayTinhDataContext data = new dbQLMayTinhDataContext();
        public int sMaSanPham { set; get; }
        public string sTenSanPham { set; get; }
        public string sHinh { set; get; }
        public Double dGiaBan { set; get; }
        public int iSoLuong { set; get; }
        public Double dThanhTien
        {
            get { return iSoLuong * dGiaBan; }
        }
        public GioHang(int MaSanPham)
        {
            sMaSanPham = MaSanPham;
            SanPham sanpham = data.SanPhams.Single(n => n.MaSanPham == sMaSanPham);
            sTenSanPham = sanpham.TenSanPham;
            sHinh = sanpham.Hinh1;
            dGiaBan = double.Parse(sanpham.GiaBan.ToString());
            iSoLuong = 1;
        }
    }
}