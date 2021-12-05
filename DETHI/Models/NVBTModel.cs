using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DETHI.Models
{
    public class NVBTModel
    {
        public string MaNhanVien {get; set;}
        public string MaThietBi {get; set;}
        public string MaCanHo {get; set;}
        public int LanThu {get; set;}
        public DateTime NgayBaoTri {get; set;}
    }
}