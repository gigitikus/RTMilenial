#pragma checksum "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03374f34e44746928ff310e25f4879a4107a9bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KepalaKeluarga_CreateKepalaKeluarga), @"mvc.1.0.view", @"/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03374f34e44746928ff310e25f4879a4107a9bbd", @"/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5733c5cc9b38699b0981d2d4536156737c0cdba6", @"/Views/_ViewImports.cshtml")]
    public class Views_KepalaKeluarga_CreateKepalaKeluarga : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RTMilenial.Models.VwAlamatKepalaKeluarga>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
  
    ViewData["Title"] = "Tambah Kepala Keluarga";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $('#JalanId').change(function () {
            $.getJSON('/KepalaKeluarga/GetBlokNoRumah/', {jalanId: $('#JalanId').val()}, function (data) {
                 var items = [];
                items.push(""<option>Pilih No. Rumah</option>"");
                $.each(data, function () {
                    items.push(""<option value="" + this.value + "">"" + this.text + ""</option>"");
                });
                $('#BlokNoRumah').html(items.join(' '));
            });
        });
    </script>
");
            }
            );
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
<div class=""container-fluid"">
<div class=""row mb-2"">
    <div class=""col-sm-6"">
    <h5>Tambah Kartu Keluarga</h5>
    </div>
    <div class=""col-sm-6"">
    <ol class=""breadcrumb float-sm-right"">
        <li class=""breadcrumb-item""><a href=""#"">Beranda</a></li>
        <li class=""breadcrumb-item active"">Tambah Kartu Keluarga</li>
    </ol>
    </div>
</div>
</div><!-- /.container-fluid -->
</section>

<div class=""content"">
    <div class=""row"">
        <div class=""col-sm-12"">
");
#nullable restore
#line 41 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
         using (Html.BeginForm("CreateKK", "KepalaKeluarga", 
        FormMethod.Post, new {@id="AgtKeluargaForm", role="form"}))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
       Write(Html.ValidationSummary(true, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card card-primary card-outline"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Data Kartu Keluarga</h3>
                    <div class=""card-tools"">
                        <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                            <i class=""fas fa-minus""></i>
                        </button>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""NoKK"">No. Kartu Keluarga</label>
");
            WriteLiteral(@"                                <input type=""text"" name=""NoKk"" class=""form-control"" 
                                id=""NoKk""
                                placeholder=""No. Kartu Keluarga"">
                            </div>
                           
                            <div class=""form-group"">
                                <label for=""NamaKK"">Nama Kepala Keluarga</label>
                                <input type=""text"" name=""NamaKk"" class=""form-control"" 
                                id=""NamaKk""
                                placeholder=""Nama Kepala Keluarga"">
");
            WriteLiteral(@"                            </div>
                            <div class=""form-group"">
                                <label for=""Alamat"">Alamat</label>
                                <input type=""text"" name=""Alamat"" class=""form-control"" 
                                id=""Alamat""
                                placeholder=""Alamat"">
");
            WriteLiteral(@"                            </div>
                            <div class=""form-group"">
                                <label for=""RtRw"">RT / RW</label>
                                <input type=""text"" name=""RtRw"" class=""form-control"" 
                                id=""RtRw""
                                placeholder=""RT / RW"">
");
            WriteLiteral(@"                            </div>
                            <div class=""form-group"">
                                <label for=""DesaKelurahan"">Desa / Kelurahan</label>
                                <input type=""text"" name=""DesaKelurahan"" class=""form-control"" 
                                id=""DesaKelurahan""
                                placeholder=""Desa / Kelurahan"">
");
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""Kecamatan"">Kecamatan</label>
                                <input type=""text"" name=""Kecamatan"" class=""form-control"" 
                                id=""Kecamatan""
                                placeholder=""Kecamatan"">
");
            WriteLiteral(@"                            </div>
                            <div class=""form-group"">
                                <label for=""KabupatenKota"">Kabupaten / Kota</label>
                                <input type=""text"" name=""KabupatenKota"" class=""form-control"" 
                                id=""KabupatenKota""
                                placeholder=""Kabupaten / Kota"">
");
            WriteLiteral(@"                            </div>
                            <div class=""form-group"">
                                <label for=""KodePos"">Kode Pos</label>
                                <input type=""text"" name=""KodePos"" class=""form-control"" 
                                id=""KodePos""
                                placeholder=""Kode Pos"">
");
            WriteLiteral(@"                            </div>
                            <div class=""form-group"">
                                <label for=""Provinsi"">Provinsi</label>
                                <input type=""text"" name=""Provinsi"" class=""form-control"" 
                                id=""Provinsi""
                                placeholder=""Provinsi"">
");
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card card-warning card-outline"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Data Alamat Rumah</h3>
                    <div class=""card-tools"">
                        <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                            <i class=""fas fa-minus""></i>
                        </button>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""JalanId"">Nama Jalan</label>
                                ");
#nullable restore
#line 151 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
                           Write(Html.DropDownListFor(model => model.JalanId, 
                                new SelectList(ViewBag.lsNamaJalan, "SelectValueMember", "SelectDisplayMember"),
                                new {@class="form-control select2",
                                @name="JalanId", @id="JalanId"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                            <div class=\"form-group\">\n                                <label for=\"BlokNoId\">Blok / No.</label>\n                                ");
#nullable restore
#line 158 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
                           Write(Html.DropDownListFor(model => model.BlokNoRumah, new SelectList(" "), "Pilih No. Rumah", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                                \n                            </div>\n                            <div class=\"form-group\">\n                                <label for=\"StatusHuniId\">Status Huni</label>\n                                ");
#nullable restore
#line 167 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
                           Write(Html.DropDownListFor(model => model.StatusHuniId, 
                                new SelectList(ViewBag.lsStatusHuni, "StatusHuniValue", "StatusHuniDisplay"),
                                new {@class="form-control select2",
                                @name="StatusHuniId", @id="StatusHuniId"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                            </div>\n                            <div class=\"form-group\">\n                                <label for=\"TanggalHuni\">Tanggal Huni</label>\n                                ");
#nullable restore
#line 177 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
                           Write(Html.TextBoxFor(m => m.TanggalHuni, "{0:dd/MM/yyyy", 
                                new {@class = "form-control", @type = "date"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                            </div>\n                            <div class=\"form-group\">\n                                <label for=\"TanggalHabisHuni\">Tanggal Habis Huni</label>\n                                ");
#nullable restore
#line 185 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
                           Write(Html.TextBoxFor(m => m.TanggalHabisHuni, "{0:dd/MM/yyyy", 
                        new {@class = "form-control", @type = "date"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""NIKPemilikRumah"">NIK Pemilik Rumah</label>
                                <input type=""text"" name=""NIKPemilikRumah"" class=""form-control"" 
                                id=""NIKPemilikRumah""
                                placeholder=""NIK Pemilik Rumah"">
                            </div>
                            <div class=""form-group"">
                                <label for=""NamaPemilikRumah"">Nama Pemilik Rumah</label>
                                <input type=""text"" name=""NamaPemilikRumah"" class=""form-control"" 
                                id=""NamaPemilikRumah""
                                placeholder=""Nama Pemilik Rumah"">
                            </div>
                            <div class=""form-group"">
                                <label for=""TenorKPR"">Tenor KPR</label>
   ");
            WriteLiteral(@"                             <input type=""text"" name=""TenorKPR"" class=""form-control"" 
                                id=""TenorKPR""
                                placeholder=""Tenor KPR"">
                            </div>
                            <div class=""form-group"">
                                <label for=""NoSuratDomisili"">No. Surat Domisili</label>
                                <input type=""text"" name=""NoSuratDomisili"" class=""form-control"" 
                                id=""NoSuratDomisili""
                                placeholder=""No. Surat Domisili"">
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <button type=""submit"" class=""btn btn-success btn-sm"">Simpan</button>
                    <button type=""submit"" class=""btn btn-warning btn-sm""");
            BeginWriteAttribute("onclick", " \n                    onclick=\"", 13251, "\"", 13350, 3);
            WriteAttributeValue("", 13282, "location.href=\'", 13282, 15, true);
#nullable restore
#line 223 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
WriteAttributeValue("", 13297, Url.Action("FetchKelapaKeluarga", "KepalaKeluarga"), 13297, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 13349, "\'", 13349, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >Batal</button>\n                </div>\n            </div>\n");
#nullable restore
#line 226 "/home/nandakapol/Project/GitRepo/RTMilenial/Views/KepalaKeluarga/CreateKepalaKeluarga.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RTMilenial.Models.VwAlamatKepalaKeluarga> Html { get; private set; }
    }
}
#pragma warning restore 1591
