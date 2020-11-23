#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0db129fafc1406c8530f4ce8bf1d0a655dad045"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrgJed_Views_ProjekatAktivnostRealizacija_Unos), @"mvc.1.0.view", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostRealizacija/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0db129fafc1406c8530f4ce8bf1d0a655dad045", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostRealizacija/Unos.cshtml")]
    public class Areas_AdminOrgJed_Views_ProjekatAktivnostRealizacija_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
  
    List<dropdownAdminOrgUnosRealVM> lista_proj_aktiv_plan = (List<dropdownAdminOrgUnosRealVM>)ViewData["lista_proj_aktiv_plan"];
    List<Korisnici> lista_korisnici = (List<Korisnici>)ViewData["lista_korisnici"];

    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>


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

    #dodaj, #detalji, #print_preview, #print_excel, #print_pdf {
        display: inline-block;
        margin: 2%;
    }

    #print_preview, #print_excel, #print_pdf {
        color: white;
    }

    #dugmad {
        margin-bottom: 2%;
        margin-top: 2%;
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
        width");
            WriteLiteral(@": 15%;
        margin-left: 0px;
        background-color: rgba(0, 0, 0, 0.8);
        color: white;
        top: 20%;
        font-size: 1vw;
        border-radius: 0px 25px 25px 0px;
    }
</style>
<div id=""kutijaZaMeni"">
    <div id=""menu"">
        <br />
        <a style=""color:white; text-decoration-line:none; font-size:120%;""");
            BeginWriteAttribute("href", " href=\"", 2039, "\"", 2123, 6);
            WriteAttributeValue("", 2046, "/AdminOrgJed/AdminOrgJed/Index?u=", 2046, 33, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2079, id.userId, 2079, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2089, "&o=", 2089, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2092, id.organisationId, 2092, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2110, "&r=", 2110, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2113, id.roleId, 2113, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2281, "\"", 2367, 6);
            WriteAttributeValue("", 2288, "/AdminOrgJed/ProjekatPlan/Prikaz?u=", 2288, 35, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2323, id.userId, 2323, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2333, "&o=", 2333, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2336, id.organisationId, 2336, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2354, "&r=", 2354, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2357, id.roleId, 2357, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2406, "\"", 2501, 6);
            WriteAttributeValue("", 2413, "/AdminOrgJed/ProjekatAktivnostPlan/Prikaz?u=", 2413, 44, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2457, id.userId, 2457, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2467, "&o=", 2467, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2470, id.organisationId, 2470, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2488, "&r=", 2488, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2491, id.roleId, 2491, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2641, "\"", 2743, 6);
            WriteAttributeValue("", 2648, "/AdminOrgJed/ProjekatAktivnostRealizacija/Prikaz?u=", 2648, 51, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2699, id.userId, 2699, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2709, "&o=", 2709, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2712, id.organisationId, 2712, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2730, "&r=", 2730, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2733, id.roleId, 2733, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2874, "\"", 2956, 6);
            WriteAttributeValue("", 2881, "/AdminOrgJed/Korisnik/Prikaz?u=", 2881, 31, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2912, id.userId, 2912, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2922, "&o=", 2922, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2925, id.organisationId, 2925, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2943, "&r=", 2943, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2946, id.roleId, 2946, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <div id=\"zaglavlje\" style=\"width:100%\">\r\n        <h1 style=\"position:relative; display:inline;\">Unos realizacije</h1>\r\n        <img style=\"height:7vw; width:7vw; position:relative; float:right; display:inline;\"");
            BeginWriteAttribute("src", " src=\"", 4065, "\"", 4078, 1);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 4071, imgsrc, 4071, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n\r\n    <form method=\"post\" action=\"/AdminOrgJed/ProjekatAktivnostRealizacija/UnosSnimi\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 4226, "\"", 4244, 1);
#nullable restore
#line 131 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 4234, id.userId, 4234, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 4289, "\"", 4315, 1);
#nullable restore
#line 132 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 4297, id.organisationId, 4297, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4360, "\"", 4378, 1);
#nullable restore
#line 133 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 4368, id.roleId, 4368, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <table>\r\n            <tr>\r\n                <td><label>Projektna aktivnost</label></td>\r\n                <td>\r\n                    <select name=\"projekatAktivnostPlan\">\r\n                        <option>---Odaberi---</option>\r\n");
#nullable restore
#line 141 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_proj_aktiv_plan)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4748, "\"", 4770, 1);
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 4756, x.aktivnostId, 4756, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                      Write(x.aktivnost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                                    Write(x.projekat);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</option>\r\n");
#nullable restore
#line 144 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td><label>Korisnik</label></td>
                <td>
                    <select name=""korisnik"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 153 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_korisnici)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5224, "\"", 5247, 1);
#nullable restore
#line 155 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 5232, x.Korisnici_ID, 5232, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 155 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                        Write(x.Ime+" "+x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 156 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td><label>Datum</label></td>
                <td>
                    <input name=""datum"" type=""datetime-local"" />
                </td>
            </tr>
            <tr>
                <td><label>Količina</label></td>
                <td>
                    <input name=""kolicina"" type=""text"" />
                </td>
            </tr>
            <tr>
                <td><label>Opis</label></td>
                <td>
                    <input name=""opis"" type=""text"" />
                </td>
            </tr>
        </table>

        <button type=""submit"" class=""btn btn-primary"">Spremi</button>
    </form>
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