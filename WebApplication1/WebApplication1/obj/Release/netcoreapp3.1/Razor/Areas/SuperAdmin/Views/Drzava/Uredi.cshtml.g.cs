#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e98ab6685065cf2ef77095ef380e8d3750fdee52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Drzava_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Drzava/Uredi.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98ab6685065cf2ef77095ef380e8d3750fdee52", @"/Areas/SuperAdmin/Views/Drzava/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_Drzava_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/SuperUser/Drzava/Uredi.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/SuperUser/Drzava/Uredi.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    uor id = (uor)ViewData["id"];
    Drzava drzava = (Drzava)ViewData["uredi_drzava"];

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e98ab6685065cf2ef77095ef380e8d3750fdee524514", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e98ab6685065cf2ef77095ef380e8d3750fdee525628", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div id=\"kutijaZaMeni\">\r\n    <div id=\"menu\">\r\n        <br />\r\n        <a style=\"color:white; text-decoration-line:none; font-size:120%;\"");
            BeginWriteAttribute("href", " href=\"", 479, "\"", 561, 6);
            WriteAttributeValue("", 486, "/SuperAdmin/SuperAdmin/Index?u=", 486, 31, true);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 517, id.userId, 517, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 527, "&o=", 527, 3, true);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 530, id.organisationId, 530, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 548, "&r=", 548, 3, true);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 551, id.roleId, 551, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 717, "\"", 796, 6);
            WriteAttributeValue("", 724, "/SuperAdmin/Drzava/Prikaz?u=", 724, 28, true);
#nullable restore
#line 19 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 752, id.userId, 752, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 762, "&o=", 762, 3, true);
#nullable restore
#line 19 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 765, id.organisationId, 765, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 783, "&r=", 783, 3, true);
#nullable restore
#line 19 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 786, id.roleId, 786, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 837, "\"", 913, 6);
            WriteAttributeValue("", 844, "/SuperAdmin/PTT/Prikaz?u=", 844, 25, true);
#nullable restore
#line 20 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 869, id.userId, 869, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 879, "&o=", 879, 3, true);
#nullable restore
#line 20 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 882, id.organisationId, 882, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 900, "&r=", 900, 3, true);
#nullable restore
#line 20 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 903, id.roleId, 903, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 951, "\"", 1036, 6);
            WriteAttributeValue("", 958, "/SuperAdmin/Organizacija/Prikaz?u=", 958, 34, true);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 992, id.userId, 992, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1002, "&o=", 1002, 3, true);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1005, id.organisationId, 1005, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1023, "&r=", 1023, 3, true);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1026, id.roleId, 1026, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1083, "\"", 1177, 6);
            WriteAttributeValue("", 1090, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 1090, 43, true);
#nullable restore
#line 22 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1133, id.userId, 1133, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1143, "&o=", 1143, 3, true);
#nullable restore
#line 22 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1146, id.organisationId, 1146, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1164, "&r=", 1164, 3, true);
#nullable restore
#line 22 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1167, id.roleId, 1167, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1234, "\"", 1318, 6);
            WriteAttributeValue("", 1241, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 1241, 33, true);
#nullable restore
#line 23 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1274, id.userId, 1274, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1284, "&o=", 1284, 3, true);
#nullable restore
#line 23 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1287, id.organisationId, 1287, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1305, "&r=", 1305, 3, true);
#nullable restore
#line 23 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1308, id.roleId, 1308, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1481, "\"", 1566, 6);
            WriteAttributeValue("", 1488, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 1488, 34, true);
#nullable restore
#line 27 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1522, id.userId, 1522, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1532, "&o=", 1532, 3, true);
#nullable restore
#line 27 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1535, id.organisationId, 1535, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1553, "&r=", 1553, 3, true);
#nullable restore
#line 27 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1556, id.roleId, 1556, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1605, "\"", 1699, 6);
            WriteAttributeValue("", 1612, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 1612, 43, true);
#nullable restore
#line 28 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1655, id.userId, 1655, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1665, "&o=", 1665, 3, true);
#nullable restore
#line 28 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1668, id.organisationId, 1668, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1686, "&r=", 1686, 3, true);
#nullable restore
#line 28 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1689, id.roleId, 1689, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1839, "\"", 1940, 6);
            WriteAttributeValue("", 1846, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 1846, 50, true);
#nullable restore
#line 32 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1896, id.userId, 1896, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1906, "&o=", 1906, 3, true);
#nullable restore
#line 32 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1909, id.organisationId, 1909, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1927, "&r=", 1927, 3, true);
#nullable restore
#line 32 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 1930, id.roleId, 1930, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2071, "\"", 2152, 6);
            WriteAttributeValue("", 2078, "/SuperAdmin/Korisnik/Prikaz?u=", 2078, 30, true);
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2108, id.userId, 2108, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2118, "&o=", 2118, 3, true);
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2121, id.organisationId, 2121, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2139, "&r=", 2139, 3, true);
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2142, id.roleId, 2142, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2196, "\"", 2274, 6);
            WriteAttributeValue("", 2203, "/SuperAdmin/Uloge/Prikaz?u=", 2203, 27, true);
#nullable restore
#line 37 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2230, id.userId, 2230, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2240, "&o=", 2240, 3, true);
#nullable restore
#line 37 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2243, id.organisationId, 2243, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2261, "&r=", 2261, 3, true);
#nullable restore
#line 37 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2264, id.roleId, 2264, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2314, "\"", 2393, 6);
            WriteAttributeValue("", 2321, "/SuperAdmin/Status/Prikaz?u=", 2321, 28, true);
#nullable restore
#line 38 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2349, id.userId, 2349, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2359, "&o=", 2359, 3, true);
#nullable restore
#line 38 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2362, id.organisationId, 2362, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2380, "&r=", 2380, 3, true);
#nullable restore
#line 38 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2383, id.roleId, 2383, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<center>\r\n    <h1>Uredi Državu</h1>\r\n    <form method=\"post\" action=\"/SuperAdmin/Drzava/UrediSnimi\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 2610, "\"", 2628, 1);
#nullable restore
#line 47 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2618, id.userId, 2618, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 2673, "\"", 2699, 1);
#nullable restore
#line 48 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2681, id.organisationId, 2681, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 2744, "\"", 2762, 1);
#nullable restore
#line 49 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2752, id.roleId, 2752, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <input hidden=\"hidden\" name=\"id_drzava\"");
            BeginWriteAttribute("value", " value=\"", 2817, "\"", 2842, 1);
#nullable restore
#line 51 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 2825, drzava.Drzava_ID, 2825, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <table>\r\n            <tr>\r\n                <td><label>Šifra</label></td>\r\n                <td><input type=\"text\" id=\"sfr\" onkeypress=\"provjera(\'sfr\')\" onchange=\"provjera(\'sfr\')\" name=\"sifra\"");
            BeginWriteAttribute("value", " value=\"", 3046, "\"", 3067, 1);
#nullable restore
#line 55 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 3054, drzava.Sifra, 3054, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><span id=\"sifra_span\"></span></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Naziv</label></td>\r\n                <td><input type=\"text\" id=\"n\" onkeypress=\"provjera(\'n\')\" onchange=\"provjera(\'n\')\" name=\"naziv\"");
            BeginWriteAttribute("value", " value=\"", 3301, "\"", 3322, 1);
#nullable restore
#line 59 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Uredi.cshtml"
WriteAttributeValue("", 3309, drzava.Naziv, 3309, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><span id=\"naziv_span\"></span></td>\r\n            </tr>\r\n        </table>\r\n        <button type=\"submit\" id=\"snimi\" class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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
