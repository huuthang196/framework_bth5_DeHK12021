#pragma checksum "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11fe7690571c0c4833faa561f7bb757f38541985"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_ListNhanVienTheoThietBi), @"mvc.1.0.view", @"/Views/NhanVien/ListNhanVienTheoThietBi.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\_ViewImports.cshtml"
using DETHI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\_ViewImports.cshtml"
using DETHI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11fe7690571c0c4833faa561f7bb757f38541985", @"/Views/NhanVien/ListNhanVienTheoThietBi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"860ebde39894b1513ab1416e2fd159d25ff5f99f", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_ListNhanVienTheoThietBi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DETHI.Models.NVBTModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
  
    ViewData["Title"] = "Liệt các thiết bị theo từng nhân viên";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table border=\"1\">\r\n    <tr>\r\n        <th>Mã thiết bị</th>\r\n        <th>Mã căn hộ</th>\r\n        <th>Lần thứ</th>\r\n        <th>Ngày bảo trì</th>\r\n        <th>Chức năng</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 14 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 18 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
       Write(item.GetType().GetProperty("MaThietBi").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 21 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
       Write(item.GetType().GetProperty("MaCanHo").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 24 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
       Write(item.GetType().GetProperty("LanThu").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 27 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
       Write(item.GetType().GetProperty("NgayBaoTri").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 787, "\"", 878, 8);
            WriteAttributeValue("", 794, "Delete?manv=", 794, 12, true);
#nullable restore
#line 30 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
WriteAttributeValue("", 806, item.MaNhanVien, 806, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 822, "&matb=", 822, 6, true);
#nullable restore
#line 30 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
WriteAttributeValue("", 828, item.MaThietBi, 828, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 843, "&mach=", 843, 6, true);
#nullable restore
#line 30 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
WriteAttributeValue("", 849, item.MaCanHo, 849, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 862, "&lt=", 862, 4, true);
#nullable restore
#line 30 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
WriteAttributeValue("", 866, item.LanThu, 866, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 906, "\"", 1016, 10);
            WriteAttributeValue("", 913, "View?manv=", 913, 10, true);
#nullable restore
#line 31 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
WriteAttributeValue("", 923, item.MaNhanVien, 923, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 939, "&matb=", 939, 6, true);
#nullable restore
#line 31 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
WriteAttributeValue("", 945, item.MaThietBi, 945, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 960, "&mach=", 960, 6, true);
#nullable restore
#line 31 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
WriteAttributeValue("", 966, item.MaCanHo, 966, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 979, "&lt=", 979, 4, true);
#nullable restore
#line 31 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
WriteAttributeValue("", 983, item.LanThu, 983, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 995, "&nbt=", 995, 5, true);
#nullable restore
#line 31 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
WriteAttributeValue("", 1000, item.NgayBaoTri, 1000, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 34 "D:\Hữu Thắng\FRAMEWORK\DETHICKY\DETHI\Views\NhanVien\ListNhanVienTheoThietBi.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DETHI.Models.NVBTModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
