#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86d3174d51a251587b30b1f0e733447212fba49c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Drzava_Unos), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Drzava/Unos.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d3174d51a251587b30b1f0e733447212fba49c", @"/Areas/SuperAdmin/Views/Drzava/Unos.cshtml")]
    public class Areas_SuperAdmin_Views_Drzava_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/SuperUser/Drzava/Unos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/SuperUser/Drzava/Unos.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";
    uor id = (uor)ViewData["id"];

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86d3174d51a251587b30b1f0e733447212fba49c4447", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86d3174d51a251587b30b1f0e733447212fba49c5561", async() => {
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
            BeginWriteAttribute("href", " href=\"", 420, "\"", 502, 6);
            WriteAttributeValue("", 427, "/SuperAdmin/SuperAdmin/Index?u=", 427, 31, true);
#nullable restore
#line 13 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 458, id.userId, 458, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 468, "&o=", 468, 3, true);
#nullable restore
#line 13 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 471, id.organisationId, 471, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 489, "&r=", 489, 3, true);
#nullable restore
#line 13 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 492, id.roleId, 492, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 658, "\"", 737, 6);
            WriteAttributeValue("", 665, "/SuperAdmin/Drzava/Prikaz?u=", 665, 28, true);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 693, id.userId, 693, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 703, "&o=", 703, 3, true);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 706, id.organisationId, 706, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 724, "&r=", 724, 3, true);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 727, id.roleId, 727, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 778, "\"", 854, 6);
            WriteAttributeValue("", 785, "/SuperAdmin/PTT/Prikaz?u=", 785, 25, true);
#nullable restore
#line 18 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 810, id.userId, 810, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 820, "&o=", 820, 3, true);
#nullable restore
#line 18 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 823, id.organisationId, 823, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 841, "&r=", 841, 3, true);
#nullable restore
#line 18 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 844, id.roleId, 844, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 892, "\"", 977, 6);
            WriteAttributeValue("", 899, "/SuperAdmin/Organizacija/Prikaz?u=", 899, 34, true);
#nullable restore
#line 19 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 933, id.userId, 933, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 943, "&o=", 943, 3, true);
#nullable restore
#line 19 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 946, id.organisationId, 946, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 964, "&r=", 964, 3, true);
#nullable restore
#line 19 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 967, id.roleId, 967, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1024, "\"", 1118, 6);
            WriteAttributeValue("", 1031, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 1031, 43, true);
#nullable restore
#line 20 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1074, id.userId, 1074, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1084, "&o=", 1084, 3, true);
#nullable restore
#line 20 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1087, id.organisationId, 1087, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1105, "&r=", 1105, 3, true);
#nullable restore
#line 20 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1108, id.roleId, 1108, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1175, "\"", 1259, 6);
            WriteAttributeValue("", 1182, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 1182, 33, true);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1215, id.userId, 1215, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1225, "&o=", 1225, 3, true);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1228, id.organisationId, 1228, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1246, "&r=", 1246, 3, true);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1249, id.roleId, 1249, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1422, "\"", 1507, 6);
            WriteAttributeValue("", 1429, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 1429, 34, true);
#nullable restore
#line 25 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1463, id.userId, 1463, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1473, "&o=", 1473, 3, true);
#nullable restore
#line 25 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1476, id.organisationId, 1476, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1494, "&r=", 1494, 3, true);
#nullable restore
#line 25 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1497, id.roleId, 1497, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1546, "\"", 1640, 6);
            WriteAttributeValue("", 1553, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 1553, 43, true);
#nullable restore
#line 26 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1596, id.userId, 1596, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1606, "&o=", 1606, 3, true);
#nullable restore
#line 26 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1609, id.organisationId, 1609, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1627, "&r=", 1627, 3, true);
#nullable restore
#line 26 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1630, id.roleId, 1630, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1780, "\"", 1881, 6);
            WriteAttributeValue("", 1787, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 1787, 50, true);
#nullable restore
#line 30 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1837, id.userId, 1837, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1847, "&o=", 1847, 3, true);
#nullable restore
#line 30 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1850, id.organisationId, 1850, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1868, "&r=", 1868, 3, true);
#nullable restore
#line 30 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1871, id.roleId, 1871, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2012, "\"", 2093, 6);
            WriteAttributeValue("", 2019, "/SuperAdmin/Korisnik/Prikaz?u=", 2019, 30, true);
#nullable restore
#line 34 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2049, id.userId, 2049, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2059, "&o=", 2059, 3, true);
#nullable restore
#line 34 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2062, id.organisationId, 2062, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2080, "&r=", 2080, 3, true);
#nullable restore
#line 34 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2083, id.roleId, 2083, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2137, "\"", 2215, 6);
            WriteAttributeValue("", 2144, "/SuperAdmin/Uloge/Prikaz?u=", 2144, 27, true);
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2171, id.userId, 2171, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2181, "&o=", 2181, 3, true);
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2184, id.organisationId, 2184, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2202, "&r=", 2202, 3, true);
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2205, id.roleId, 2205, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2255, "\"", 2334, 6);
            WriteAttributeValue("", 2262, "/SuperAdmin/Status/Prikaz?u=", 2262, 28, true);
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2290, id.userId, 2290, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2300, "&o=", 2300, 3, true);
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2303, id.organisationId, 2303, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2321, "&r=", 2321, 3, true);
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2324, id.roleId, 2324, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Statusi</a></li>
            </ul>
        </ul>
    </div>
</div>

<center>
    <h1>Unos države</h1>

    <form method=""post"" action=""/SuperAdmin/Drzava/UnosSnimi"">
        <table>
            <tr>
                <td><label>Šifra</label></td>
                <td><input onkeypress=""provjera('sfr')"" onchange=""provjera('sfr')"" onblur=""provjera('sfr')"" id=""sfr"" type=""text"" name=""sifra"" /><span id=""sifra_span""></span></td>
            </tr>
            <tr>
                <td><label>Naziv</label></td>
                <td><input onchange=""provjera('n')"" onblur=""provjera('n')"" onkeypress=""provjera('n')"" id=""n"" type=""text"" name=""naziv"" /><span id=""naziv_span""></span></td>
            </tr>
            <input hidden=""hidden"" name=""u""");
            BeginWriteAttribute("value", " value=\"", 3092, "\"", 3110, 1);
#nullable restore
#line 55 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 3100, id.userId, 3100, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3159, "\"", 3177, 1);
#nullable restore
#line 56 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 3167, id.roleId, 3167, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3226, "\"", 3252, 1);
#nullable restore
#line 57 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 3234, id.organisationId, 3234, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </table>\r\n\r\n        <button type=\"submit\" id=\"snimi\" class=\"btn btn-primary\">Snimi</button>\r\n\r\n    </form>\r\n</center>");
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
