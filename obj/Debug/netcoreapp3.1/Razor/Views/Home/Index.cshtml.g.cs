#pragma checksum "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b90c68173f4f7b32ace9ef9a85eba9f231d79c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/_ViewImports.cshtml"
using RTMilenial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/_ViewImports.cshtml"
using RTMilenial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b90c68173f4f7b32ace9ef9a85eba9f231d79c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5733c5cc9b38699b0981d2d4536156737c0cdba6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <h5 class=""mt-4 mb-2"">Kepala Keluarga & Anggota Keluarga</h5>
        <div class=""row"">
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 12 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                       Write(ViewBag.CountKK);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h5>Kepala Keluarga</h5>
                        <p>Kepala Keluarga</p>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-user""></i>
                    </div>
                    <a class=""small-box-footer"" href=""#"">
                        More info
                        <i class=""fas fa-arrow-circle-right""></i>
                    </a>
                </div>
            </div>
            <div class=""col-lg-3 col-6"">
                <!-- small card -->
                <div class=""small-box bg-warning"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 29 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                   Write(ViewBag.CountAngKK);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <h5>Anggota Keluarga</h5>
                    <p>yang tercatat di Kartu Keluarga</p>
                </div>
                <div class=""icon"">
                    <i class=""fas fa-users""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">
                    More info <i class=""fas fa-arrow-circle-right""></i>
                </a>
                </div>
            </div>
            <div class=""col-lg-3 col-6"">
                <!-- small card -->
                <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 45 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                   Write(ViewBag.TotalWarga);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <h5>Total Keseluruhan Warga</h5>
                    <p>Kepala Keluarga + Anggota Keluarga</p>
                </div>
                <div class=""icon"">
                    <i class=""fas fa-users""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">
                    More info <i class=""fas fa-arrow-circle-right""></i>
                </a>
                </div>
            </div>
        </div>

        <h5 class=""mt-4 mb-2"">BALITA (0-4 th), Anak (5-11 th), Remaja (12-18 th)</h5>
        <div class=""row"">
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-success"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 64 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                       Write(ViewBag.CountBalita);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h5>Bawah Lima Tahun</h5>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-user""></i>
                    </div>
                    <a class=""small-box-footer"" href=""#"">
                        More info
                        <i class=""fas fa-arrow-circle-right""></i>
                    </a>
                </div>
            </div>
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 79 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                       Write(ViewBag.CountAnak);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h5>Anak - anak</h5>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-user""></i>
                    </div>
                    <a class=""small-box-footer"" href=""#"">
                        More info
                        <i class=""fas fa-arrow-circle-right""></i>
                    </a>
                </div>
            </div>
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-warning"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 94 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                       Write(ViewBag.CountRemaja);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h5>Anak Remaja</h5>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-user""></i>
                    </div>
                    <a class=""small-box-footer"" href=""#"">
                        More info
                        <i class=""fas fa-arrow-circle-right""></i>
                    </a>
                </div>
            </div>
        </div>

        <h5 class=""mt-4 mb-2"">Pemeluk Agama</h5>
        <div class=""row"">
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-success"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 113 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                       Write(ViewBag.CountIslam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h5>Islam</h5>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-mosque""></i>
                    </div>
                    <a class=""small-box-footer"" href=""#"">
                        More info
                        <i class=""fas fa-arrow-circle-right""></i>
                    </a>
                </div>
            </div>
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-warning"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 128 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                       Write(ViewBag.CountKhatolik);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h5>Kristen Khatolik</h5>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-church""></i>
                    </div>
                    <a class=""small-box-footer"" href=""#"">
                        More info
                        <i class=""fas fa-arrow-circle-right""></i>
                    </a>
                </div>
            </div>
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 143 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                       Write(ViewBag.CountProtestan);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h5>Kristen Protestan</h5>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-cross""></i>
                    </div>
                    <a class=""small-box-footer"" href=""#"">
                        More info
                        <i class=""fas fa-arrow-circle-right""></i>
                    </a>
                </div>
            </div>
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-danger"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 158 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/Home/Index.cshtml"
                       Write(ViewBag.CountBudha);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h5>Budha</h5>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-yin-yang""></i>
                    </div>
                    <a class=""small-box-footer"" href=""#"">
                        More info
                        <i class=""fas fa-arrow-circle-right""></i>
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
