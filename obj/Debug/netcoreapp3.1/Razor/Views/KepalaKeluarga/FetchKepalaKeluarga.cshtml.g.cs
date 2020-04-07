#pragma checksum "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9475fef1b5bb283aa72b2b0e86c6133430d5e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KepalaKeluarga_FetchKepalaKeluarga), @"mvc.1.0.view", @"/Views/KepalaKeluarga/FetchKepalaKeluarga.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9475fef1b5bb283aa72b2b0e86c6133430d5e9", @"/Views/KepalaKeluarga/FetchKepalaKeluarga.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"448354958208fd39d7c44ae67953ccc4c54ef73d", @"/Views/_ViewImports.cshtml")]
    public class Views_KepalaKeluarga_FetchKepalaKeluarga : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RTMilenial.Models.KepalaKeluarga>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
  
    ViewData["Title"] = "Kepala Keluarga";
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
    <h1>Data Kepala Keluarga</h1>
    </div>
    <div class=""col-sm-6"">
    <ol class=""breadcrumb float-sm-right"">
        <li class=""breadcrumb-item""><a href=""#"">Beranda</a></li>
        <li class=""breadcrumb-item active"">Kepala Keluarga</li>
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
            <button type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 811, "\"", 890, 3);
            WriteAttributeValue("", 821, "location.href=\'", 821, 15, true);
#nullable restore
#line 29 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
WriteAttributeValue("", 836, Url.Action("CreateKepalaKeluarga", "KepalaKeluarga"), 836, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 889, "\'", 889, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" 
            class=""btn btn-success btn-sm"">Tambah Kepala Keluarga</button>
            <div class=""card-tools"">
                <div class=""input-group input-group-sm"">
                    <input type=""text"" class=""form-control"" placeholder=""Search"">
                    <div class=""input-group-append"">
                        <div class=""btn btn-primary"">
                            <i class=""fas fa-search""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.box-header -->
        <div class=""card-body"">
            <table id=""example2"" class=""table table-responsive table-hover""
            style=""font-size: small;"">
            <thead>
            <tr>
                <th>No. KK</th>
                <th>NIK</th>
                <th>Nama KK</th>
                <th>Alamat</th>
                <th>RT/RW</th>
                <th>Desa/Kelurahan</th>
                <th>Kecamatan</th>
                <th>Kabupaten/Kota</th>
     ");
            WriteLiteral("           <th>KodePos</th>\n                <th>Provinsi</th>\n                <th>Action</th>\n            </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 62 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 65 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NoKk));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 66 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NIK));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 67 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NamaKk));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 68 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Alamat));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 69 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Rtrw));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 70 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DesaKelurahan));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 71 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Kecamatan));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 72 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.KabupatenKota));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 73 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.KodePos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 74 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Provinsi));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <div class=""mailbox-controls"">
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-edit""></i></button>
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""far fa-trash-alt""></i></button>
                                <button type=""button""");
            BeginWriteAttribute("onclick", " \n                                onclick=\"", 3319, "\"", 3481, 3);
            WriteAttributeValue("", 3362, "location.href=\'", 3362, 15, true);
#nullable restore
#line 80 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
WriteAttributeValue("", 3377, Url.Action("CreateAnggotaKeluarga", "AnggotaKeluarga", new {NoKK = @item.NoKk, NamaKK = @item.NamaKk}), 3377, 103, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3480, "\'", 3480, 1, true);
            EndWriteAttribute();
            WriteLiteral("\n                                class=\"btn btn-default btn-sm\"><i class=\"fas fa-user-plus\"></i></button>            \n                            </div>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 85 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
            </table>
        </div>
        <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->
    </div>
    <!-- /.row -->
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
#line 110 "G:\NANDA\Project\RTMilenial\Views\KepalaKeluarga\FetchKepalaKeluarga.cshtml"
                 Write(Url.Action("Delete", "KepalaKeluarga"));

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
                        var baseUrl=""/KepalaKeluarga"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RTMilenial.Models.KepalaKeluarga>> Html { get; private set; }
    }
}
#pragma warning restore 1591
