using Microsoft.AspNetCore.Mvc;
using DETHI.Models;
using System;

namespace DETHI.Controllers
{
    public class NhanVienController:Controller
    {
        public IActionResult LietKeNhanVienTheoSoLan()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ListByTime(int solan)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(DETHI.Models.DataContext)) as DataContext;
            return View(context.sqlListByTimeNhanVien(solan));
        }

        public IActionResult LietKeNhanVienCombobox()
        {
            return View();
        }
        public IActionResult ListNhanVien()
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(DETHI.Models.DataContext)) as DataContext;
            return View(context.sqlListNhanVien());
        }

        [HttpPost]
        public IActionResult ListNhanVienTheoThietBi()
        {
            string manv = Request.Form["MaNhanVien"].ToString();
            DataContext context = HttpContext.RequestServices.GetService(typeof(DETHI.Models.DataContext)) as DataContext;
            return View(context.sqlListNhanVienTheoThietBi(manv));
        }

        public string Delete(string manv, string matb, string mach, int lt)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(DETHI.Models.DataContext)) as DataContext;
            if (context.sqlDeleteNVBT(manv, matb, mach, lt) > 0)
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public IActionResult View(string manv, string matb, string mach, int lt, DateTime nbt)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(DETHI.Models.DataContext)) as DataContext;
            NVBTModel nvbt = new NVBTModel();
            nvbt.MaNhanVien = manv;
            nvbt.MaThietBi = matb;
            nvbt.MaCanHo = mach;
            nvbt.LanThu = lt;
            nvbt.NgayBaoTri = nbt;
            ViewData.Model = nvbt;
            return View();
        }

        public string Update(string manv, string matb, string mach, int lt, DateTime nbt)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(DETHI.Models.DataContext)) as DataContext;
            // return View(context.sqlUpdateNVBT(manv,matb,mach,lt,nbt));
            if (context.sqlUpdateNVBT(manv, matb, mach, lt, nbt) > 0)
                return "Cập nhật thành công";
            return "Cập nhật thất bại";
        }
    }
}
