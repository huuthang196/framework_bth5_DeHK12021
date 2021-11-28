using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DETHI.Models;

namespace DETHI.Controllers
{
    public class CanHoController:Controller
    {
        public IActionResult ThemCanHo()
        {
            return View();
        }

        [HttpPost]
        public string AddCH(CanHoModel canho)
        {
            int count;
            DataContext context = HttpContext.RequestServices.GetService(typeof(DETHI.Models.DataContext)) as DataContext;
            count = context.sqlInsertCanHo(canho);
            if(count == 1)
            {
                return "Thêm Thành Công!";
            }
            return "Thêm thất bại";
        }
    }
}





