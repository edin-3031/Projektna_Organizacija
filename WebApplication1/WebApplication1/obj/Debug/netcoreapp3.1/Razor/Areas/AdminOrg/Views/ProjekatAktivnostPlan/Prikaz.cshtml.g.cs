#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d64c48752e9d999b469021d37129ead32d144757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_ProjekatAktivnostPlan_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d64c48752e9d999b469021d37129ead32d144757", @"/Areas/AdminOrg/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatAktivnostPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
  
    List<ProjekatAktivnostPlan> lista = (List<ProjekatAktivnostPlan>)ViewData["pro_aktiv_plan"];

    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

    var organizacijaId = (int)Context.Session.GetInt32("organisation ID");

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
        <h1 style=""position:relative; display:inline;"">Prikaz Projektnih aktivnosti</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 1705, "\"", 1718, 1);
#nullable restore
#line 67 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1711, imgsrc, 1711, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <div id=""podloga"">
        <div id=""dugmad"">
            <div id=""dodaj"">
                <a class=""btn btn-success"" href=""/AdminOrg/ProjekatAktivnostPlan/Unos"">Dodaj novi</a>
            </div>
            <div id=""print_excel"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1994, "\"", 2049, 2);
            WriteAttributeValue("", 2001, "/Report/IndexAdminOrgAktivnost?o=", 2001, 33, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2034, organizacijaId, 2034, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">Export to Excel</a>
            </div>
        </div>
        <table class=""table"">
            <thead>
            <th>Projekat plan</th>
            <th>Šifra</th>
            <th>Naziv</th>
            <th>Datum od</th>
            <th>Datum do</th>
            <th>Jedinica mjere</th>
            <th>Količina</th>
            <th>Akcija</th>
            </thead>
            <tbody>
");
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                 foreach (var x in lista)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                        Write(x.projekatPlan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                       Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                       Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                        Write(x.DatumOd.Date.Day+"."+ x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                        Write(x.DatumDo.Date.Day+"."+ x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                       Write(x.JedinicaMjere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                       Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3120, "\"", 3195, 2);
            WriteAttributeValue("", 3127, "/AdminOrg/ProjekatAktivnostPlan/Uredi?id=", 3127, 41, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3168, x.ProjekatAktivnostPlan_ID, 3168, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                            <a");
            BeginWriteAttribute("id", " id=\"", 3238, "\"", 3277, 2);
            WriteAttributeValue("", 3243, "ukloni_", 3243, 7, true);
#nullable restore
#line 102 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3250, x.ProjekatAktivnostPlan_ID, 3250, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                            <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 3436, "\"", 3475, 2);
            WriteAttributeValue("", 3441, "poruka_", 3441, 7, true);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3448, x.ProjekatAktivnostPlan_ID, 3448, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 3488, "\"", 3564, 2);
            WriteAttributeValue("", 3495, "/AdminOrg/ProjekatAktivnostPlan/Ukloni?id=", 3495, 42, true);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3537, x.ProjekatAktivnostPlan_ID, 3537, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 3614, "\"", 3649, 2);
            WriteAttributeValue("", 3619, "no_", 3619, 3, true);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3622, x.ProjekatAktivnostPlan_ID, 3622, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                            <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                              Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 114 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                            </script>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
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
