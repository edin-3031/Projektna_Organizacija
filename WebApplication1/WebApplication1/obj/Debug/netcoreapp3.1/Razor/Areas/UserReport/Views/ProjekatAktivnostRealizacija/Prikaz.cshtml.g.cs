#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71dbc8446320453cfe41e33bf1cd48d7fa960554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserReport_Views_ProjekatAktivnostRealizacija_Prikaz), @"mvc.1.0.view", @"/Areas/UserReport/Views/ProjekatAktivnostRealizacija/Prikaz.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71dbc8446320453cfe41e33bf1cd48d7fa960554", @"/Areas/UserReport/Views/ProjekatAktivnostRealizacija/Prikaz.cshtml")]
    public class Areas_UserReport_Views_ProjekatAktivnostRealizacija_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
  
    List<par_final_VM> lista = (List<par_final_VM>)ViewData["lista_relizacija"];

    Layout = "~/Views/Shared/_Layout_user_report.cshtml";

    byte[] pic = (byte[])ViewData["logo"];

    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

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
            BeginWriteAttribute("src", " src=\"", 1603, "\"", 1616, 1);
#nullable restore
#line 65 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 1609, imgsrc, 1609, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>

    <div id=""dugmad"">

        <div id=""detalji"">
            <a class=""btn btn-warning"" href=""/UserReport/ProjekatAktivnostRealizacija/Detalji"">Detalji</a>
        </div>
        <div id=""print_excel""><a href=""/UserReport/ProjekatAktivnostRealizacija/Excel"" class=""btn btn-info"">Export to Excel</a></div>
        <div></div>
        <div></div>
    </div>
    <div id=""podloga"">
        <table class=""table"">
            <thead>
            <th>Projekat plan</th>
            <th>Projekat aktivnost plan</th>
            <th>Organizaciona jedinica</th>
            <th>Korisnik</th>
            <th>Datum</th>
            <th>Količina</th>
            <th>Opis</th>
            </thead>
            <tbody>
");
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                 foreach (var x in lista)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.proj_plan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.ProjekatAktivnostPlan_all.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.OrgJed.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                        Write(x.Korisnici.Ime+" "+x.Korisnici.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                        Write(x.Datum.Date.Day+"."+ x.Datum.Date.Month + "." + x.Datum.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                       Write(x.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 100 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div id=""podloga""></div>

    <div id=""tekst_i_animacija"">
        <div class=""loader""></div>
        <p id=""tekst_ucitava"">Loading...</p>
    </div>
</center>
<script>
    $(document).ready(function () {
        $(""#tekst_i_animacija"").show().delay(2000).hide();
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
