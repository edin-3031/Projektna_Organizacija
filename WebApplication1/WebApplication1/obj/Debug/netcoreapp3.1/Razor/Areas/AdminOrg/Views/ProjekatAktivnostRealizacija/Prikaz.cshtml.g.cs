#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a03d2a4e0c1139f05f90cf7bc3c6e007464b03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_ProjekatAktivnostRealizacija_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/ProjekatAktivnostRealizacija/Prikaz.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62a03d2a4e0c1139f05f90cf7bc3c6e007464b03", @"/Areas/AdminOrg/Views/ProjekatAktivnostRealizacija/Prikaz.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatAktivnostRealizacija_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
  
    List<par_final_VM> lista = (List<par_final_VM>)ViewData["lista_relizacija"];

    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .loader {
        position: relative;
        border: 2.5vw solid #c2fdc5;
        border-top: 2.5vw solid #28a524;
        border-radius: 50%;
        width: 8vw;
        height: 8vw;
        animation: spin 1s linear infinite;
        margin: auto;
    }

    ");
            WriteLiteral(@"@keyframes spin {
        0% {
            transform: rotate(0deg);
        }

        100% {
            transform: rotate(360deg);
        }
    }

    #tekst_ucitava {
        position: relative;
        text-align: center;
        font-family: Agency FB;
        font-size: 5vw;
        font-weight: bold;
        width: 100%;
        margin: auto;
    }

    #tekst_i_animacija {
        position: absolute;
        height: 30%;
        width: 30%;
        margin-left: 25%;
        margin-top: 8vw;
    }

    #podloga {
        position: absolute;
        width: 70%;
        height: 100%;
        margin-top: 5%;
    }
</style>
<center>
    <div id=""zaglavlje"" style=""width:100%"">
        <h1 style=""position:relative; display:inline;"">Prikaz Realizacija</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 1566, "\"", 1579, 1);
#nullable restore
#line 64 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 1572, imgsrc, 1572, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <div id=""podloga"">
        <div id=""dugmad"">
            <div id=""dodaj"">
                <a class=""btn btn-success"" href=""/AdminOrg/ProjekatAktivnostRealizacija/Unos"">Unesi novu</a>
            </div>
            <div id=""detalji"">
                <a class=""btn btn-warning"" href=""/AdminOrg/ProjekatAktivnostRealizacija/Detalji"">Detalji</a>
            </div>
            <div id=""print_excel""><a href=""/AdminOrg/ProjekatAktivnostRealizacija/Excel"" class=""btn btn-info"">Export to Excel</a></div>
            <div></div>
            <div></div>
        </div>
        <table class=""table"">
            <thead>
            <th>Projekat plan</th>
            <th>Projekat aktivnost plan</th>
            <th>Organizaciona jedinica</th>
            <th>Korisnik</th>
            <th>Datum</th>
            <th>Količina</th>
            <th>Opis</th>
            <th>Akcija</th>
            </thead>
            <tbody>
");
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                 foreach (var x in lista)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.proj_plan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.ProjekatAktivnostPlan_all.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.OrgJed.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.korisnik_ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                        Write(x.Datum.Date.Day+"."+ x.Datum.Date.Month + "." + x.Datum.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3133, "\"", 3222, 2);
            WriteAttributeValue("", 3140, "/AdminOrg/ProjekatAktivnostRealizacija/Uredi?id=", 3140, 48, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3188, x.ProjekatAktivnostRealizacija_ID, 3188, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                            <a");
            BeginWriteAttribute("id", " id=\"", 3265, "\"", 3311, 2);
            WriteAttributeValue("", 3270, "ukloni_", 3270, 7, true);
#nullable restore
#line 102 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3277, x.ProjekatAktivnostRealizacija_ID, 3277, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                            <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 3470, "\"", 3516, 2);
            WriteAttributeValue("", 3475, "poruka_", 3475, 7, true);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3482, x.ProjekatAktivnostRealizacija_ID, 3482, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 3529, "\"", 3619, 2);
            WriteAttributeValue("", 3536, "/AdminOrg/ProjekatAktivnostRealizacija/Ukloni?id=", 3536, 49, true);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3585, x.ProjekatAktivnostRealizacija_ID, 3585, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 3669, "\"", 3711, 2);
            WriteAttributeValue("", 3674, "no_", 3674, 3, true);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3677, x.ProjekatAktivnostRealizacija_ID, 3677, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                            <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostRealizacija_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostRealizacija_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostRealizacija_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                              Write(x.ProjekatAktivnostRealizacija_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 114 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostRealizacija_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                            </script>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div id=""tekst_i_animacija"">
        <div class=""loader""></div>
        <p id=""tekst_ucitava"">Loading...</p>
    </div>
    <script>
        $(document).ready(function () {
            $(""#tekst_i_animacija"").show().delay(2000).hide();
        });
    </script>
</center>");
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
