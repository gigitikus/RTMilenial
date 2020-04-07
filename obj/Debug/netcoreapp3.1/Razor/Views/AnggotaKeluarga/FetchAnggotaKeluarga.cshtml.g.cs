#pragma checksum "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f257eeba2505c57722c6dab9a330968985e6513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnggotaKeluarga_FetchAnggotaKeluarga), @"mvc.1.0.view", @"/Views/AnggotaKeluarga/FetchAnggotaKeluarga.cshtml")]
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
#line 1 "G:\NANDA\Project\RTMilenial\Views\_ViewImports.cshtml"
using RTMilenial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\NANDA\Project\RTMilenial\Views\_ViewImports.cshtml"
using RTMilenial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f257eeba2505c57722c6dab9a330968985e6513", @"/Views/AnggotaKeluarga/FetchAnggotaKeluarga.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"448354958208fd39d7c44ae67953ccc4c54ef73d", @"/Views/_ViewImports.cshtml")]
    public class Views_AnggotaKeluarga_FetchAnggotaKeluarga : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RTMilenial.Models.AnggotaKeluarga>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
  
    ViewData["Title"] = "Anggota Keluarga";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
<div class=""container-fluid"">
<div class=""row mb-2"">
    <div class=""col-sm-6"">
    <h1>Data Anggota Keluarga</h1>
    </div>
    <div class=""col-sm-6"">
    <ol class=""breadcrumb float-sm-right"">
        <li class=""breadcrumb-item""><a href=""#"">Beranda</a></li>
        <li class=""breadcrumb-item active"">Anggota Keluarga</li>
    </ol>
    </div>
</div>
</div><!-- /.container-fluid -->
</section>

<section class=""content"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card card-primary card-outline"">
                <div class=""card-header"">
                    
                    <div class=""card-tools"">
                        <div class=""input-group input-group-sm"">
                            <input type=""text"" class=""form-control"" placeholder=""Search"">
                            <div class=""input-group-append"">
                                <div class=""btn btn-primary"">
 ");
            WriteLiteral(@"                                   <i class=""fas fa-search""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <table id=""example2"" class=""table table-responsive table-hover"" 
                    style=""font-size: small;"">
                        <thead>
                            <tr>
                                <th>No.KK</th>
                                <th>No.Urut</th>
                                <th>Nama Lengkap</th>
                                <th>NIK</th>
                                <th>Jenis Kelamin</th>
                                <th>Tempat Lahir</th>
                                <th>Tanggal Lahir</th>
                                <th>Agama</th>
                                <th>Pendidikan</th>
                                <th>Pekerjaan</th>
                                <th>A");
            WriteLiteral("ction</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 60 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 63 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Html.DisplayFor(model => item.NoKk));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 64 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Html.DisplayFor(model => item.NoUrut));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 65 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Html.DisplayFor(model => item.NamaLengkap));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 66 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Html.DisplayFor(model => item.Nik));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 67 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Html.DisplayFor(model => item.JenisKelamin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 68 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Html.DisplayFor(model => item.TempatLahir));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 69 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Convert.ToDateTime(item.TanggalLahir).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 70 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Html.DisplayFor(model => item.Agama));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 71 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Html.DisplayFor(model => item.Pendidikan));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 72 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                                   Write(Html.DisplayFor(model => item.JenisPekerjaan));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <div class=""mailbox-controls"">
                                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-edit""></i></button>
                                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""far fa-trash-alt""></i></button>
                                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-search""></i></button>            
                                        </div>
                                    </td>
                                </tr>   
");
#nullable restore
#line 81 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>


<script>
    $(function () {
        $('#example1').DataTable();
    });
    function Delete(id){
        var txt;
        var r = confirm(""Are you sure you want to Delete?"");
        if (r == true) {
            
            $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 103 "G:\NANDA\Project\RTMilenial\Views\AnggotaKeluarga\FetchAnggotaKeluarga.cshtml"
                 Write(Url.Action("Delete", "AnggotaKeluarga"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl=""/AnggotaKeluarga"";
                        window.location.reload();
                    }
                    else {
                        alert(""There is a problem, Try Later!"");
                    }
                }
            });
        } 
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RTMilenial.Models.AnggotaKeluarga>> Html { get; private set; }
    }
}
#pragma warning restore 1591
