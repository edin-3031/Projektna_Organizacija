#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b39f6762f7200c86980a0d7b18dd5cddc35f858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrgJed_Views_ProjekatPlan_Unos), @"mvc.1.0.view", @"/Areas/AdminOrgJed/Views/ProjekatPlan/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b39f6762f7200c86980a0d7b18dd5cddc35f858", @"/Areas/AdminOrgJed/Views/ProjekatPlan/Unos.cshtml")]
    public class Areas_AdminOrgJed_Views_ProjekatPlan_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
  
    List<OrganizacionaJedinica> lista_org_jed = (List<OrganizacionaJedinica>)ViewData["lista_org_jed"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    List<Status> stat_lista = (List<Status>)ViewData["statusi"];

    uor id = (uor)ViewData["id"];

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    td {
        padding: 10px;
    }

    a, td {
        /*font-weight: bold;*/
        text-align-last: center;
    }

    li, ul {
        list-style: none;
        margin-top: 5%;
    }

    ul {
        margin: 0px;
        padding: 0px;
        border: 0px;
    }

    #sifarnik, #transakcije, #izvjestaji, #admin {
        font-weight: bold;
    }

    a {
        color: white;
        text-decoration-line: none;
    }

        a:hover {
            color: white;
            text-decoration: none;
            text-decoration-line: none;
        }

    #kutijaZaMeni {
        position: fixed;
        height: 100%;
        width: 17%;
        /*            background-color:green;*/
        display: block;
        margin-left: -17.8%;
    }

    #menu {
        position: fixed;
        /*height: 65%;*/
        width: 15%;
        margin-left: 0px;
        background-color: rgba(0, 0, 0, 0.8);
        color: white;
        top: 20%;
        font-s");
            WriteLiteral("ize: 1vw;\r\n        border-radius: 0px 25px 25px 0px;\r\n    }\r\n</style>\r\n<div id=\"kutijaZaMeni\">\r\n    <div id=\"menu\">\r\n        <br />\r\n        <a style=\"color:white; text-decoration-line:none; font-size:120%;\"");
            BeginWriteAttribute("href", " href=\"", 1858, "\"", 1942, 6);
            WriteAttributeValue("", 1865, "/AdminOrgJed/AdminOrgJed/Index?u=", 1865, 33, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1898, id.userId, 1898, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1908, "&o=", 1908, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1911, id.organisationId, 1911, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1929, "&r=", 1929, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1932, id.roleId, 1932, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2100, "\"", 2186, 6);
            WriteAttributeValue("", 2107, "/AdminOrgJed/ProjekatPlan/Prikaz?u=", 2107, 35, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2142, id.userId, 2142, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2152, "&o=", 2152, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2155, id.organisationId, 2155, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2173, "&r=", 2173, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2176, id.roleId, 2176, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2225, "\"", 2320, 6);
            WriteAttributeValue("", 2232, "/AdminOrgJed/ProjekatAktivnostPlan/Prikaz?u=", 2232, 44, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2276, id.userId, 2276, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2286, "&o=", 2286, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2289, id.organisationId, 2289, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2307, "&r=", 2307, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2310, id.roleId, 2310, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2460, "\"", 2562, 6);
            WriteAttributeValue("", 2467, "/AdminOrgJed/ProjekatAktivnostRealizacija/Prikaz?u=", 2467, 51, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2518, id.userId, 2518, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2528, "&o=", 2528, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2531, id.organisationId, 2531, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2549, "&r=", 2549, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2552, id.roleId, 2552, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2693, "\"", 2775, 6);
            WriteAttributeValue("", 2700, "/AdminOrgJed/Korisnik/Prikaz?u=", 2700, 31, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2731, id.userId, 2731, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2741, "&o=", 2741, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2744, id.organisationId, 2744, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2762, "&r=", 2762, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2765, id.roleId, 2765, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Korisnici</a></li>
            </ul>
        </ul>
    </div>
</div>
<center>
    <div id=""zaglavlje"" style=""width:100%"">
        <h1 style=""position:relative; display:inline;"">Unos Projektnog Plana</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3080, "\"", 3093, 1);
#nullable restore
#line 100 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3086, imgsrc, 3086, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <form method=\"post\" action=\"/AdminOrgJed/ProjekatPlan/UnosSnimi\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3245, "\"", 3263, 1);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3253, id.userId, 3253, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3308, "\"", 3334, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3316, id.organisationId, 3316, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3379, "\"", 3397, 1);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3387, id.roleId, 3387, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

        <table>

            <tr>
                <td>
                    <label>
                        Šifra
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""sifra"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Naziv
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""naziv"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Datum od
                    </label>
                </td>
                <td>
                    <input type=""datetime-local"" name=""Od"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Datum do
                    </label>
                </td>
             ");
            WriteLiteral(@"   <td>
                    <input type=""datetime-local"" name=""Do"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Status
                    </label>
                </td>
                <td>
                    <select name=""status_id"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 160 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
                         foreach (var x in stat_lista)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4933, "\"", 4952, 1);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 4941, x.StatusID, 4941, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Unesi</button>\r\n    </form>\r\n</center>");
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
