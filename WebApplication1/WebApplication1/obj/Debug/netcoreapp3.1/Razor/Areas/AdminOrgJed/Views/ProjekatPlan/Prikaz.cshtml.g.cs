#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d1d76190691f2a53306da6513e28c99f19f3a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrgJed_Views_ProjekatPlan_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrgJed/Views/ProjekatPlan/Prikaz.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d1d76190691f2a53306da6513e28c99f19f3a0b", @"/Areas/AdminOrgJed/Views/ProjekatPlan/Prikaz.cshtml")]
    public class Areas_AdminOrgJed_Views_ProjekatPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
  
    List<ProjekatPlan> lista = (List<ProjekatPlan>)ViewData["proj_plan"];

    Layout = "~/Views/Shared/_Layout_admin_org_jed.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .aktiv {
        background-color: lawngreen;
        font-weight: bold;
    }

    .prek {
        background-color: dodgerblue;
        color: white;
        font-weight: bold;
    }

    .zavrs {
        background-color: orangered;
        color: white;
        font-weight: bold;
    }

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
        <h1 style=""position:relative; display:inline;"">Prikaz Projektnih Planova</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 1879, "\"", 1892, 1);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 1885, imgsrc, 1885, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <div id=""podloga"">
        <div id=""dugmad"">
            <div id=""dodaj"">
                <a class=""btn btn-success"" href=""/AdminOrgJed/ProjekatPlan/Unos"">Dodaj novi</a>
            </div>
            <div id=""print_excel"">
                <a href=""/AdminOrgJed/ProjekatPlan/Excel"" class=""btn btn-info"">Export to Excel</a>
            </div>
        </div>
        <table class=""table"">
            <thead>
            <th>Naziv</th>
            <th>Šifra</th>
            <th>Datum od</th>
            <th>Datum do</th>
            <th>Status</th>
            <th>Akcija</th>
            </thead>
            <tbody>
");
#nullable restore
#line 100 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                 foreach (var x in lista)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                       Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                       Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                        Write(x.DatumOd.Date.Day+"."+x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                        Write(x.DatumDo.Date.Day+"."+x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td");
            BeginWriteAttribute("id", " id=\"", 2982, "\"", 3012, 2);
            WriteAttributeValue("", 2987, "status_", 2987, 7, true);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2994, x.ProjekatPlan_ID, 2994, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                                                      Write(x.status.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <script>\r\n                        var element = document.getElementById(\"status_");
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                                                                 Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");

                        if (element.innerText == ""Aktivan"") {
                            element.classList.add(""aktiv"");
                        }
                        else if (element.innerText == ""Prekinut"") {
                            element.classList.add(""prek"");
                        }
                        else if (element.innerText == ""Završen"") {
                            element.classList.add(""zavrs"");
                        }
                        </script>
                        <td>
                            <a class=""btn btn-primary""");
            BeginWriteAttribute("href", " href=\"", 3747, "\"", 3807, 2);
            WriteAttributeValue("", 3754, "/AdminOrgJed/ProjekatPlan/Uredi?id=", 3754, 35, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3789, x.ProjekatPlan_ID, 3789, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                            <a");
            BeginWriteAttribute("id", " id=\"", 3850, "\"", 3880, 2);
            WriteAttributeValue("", 3855, "ukloni_", 3855, 7, true);
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3862, x.ProjekatPlan_ID, 3862, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                            <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 4039, "\"", 4069, 2);
            WriteAttributeValue("", 4044, "poruka_", 4044, 7, true);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4051, x.ProjekatPlan_ID, 4051, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 4082, "\"", 4143, 2);
            WriteAttributeValue("", 4089, "/AdminOrgJed/ProjekatPlan/Ukloni?id=", 4089, 36, true);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4125, x.ProjekatPlan_ID, 4125, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 4193, "\"", 4219, 2);
            WriteAttributeValue("", 4198, "no_", 4198, 3, true);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4201, x.ProjekatPlan_ID, 4201, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                            <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                                  Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                                  Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 131 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                                      Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 134 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                              Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                                      Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                            </script>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
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
