#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a1808fa79f603ab8fab89a9a6151c08e70e9deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserReport_Views_ProjekatAktivnostRealizacija_Uredi), @"mvc.1.0.view", @"/Areas/UserReport/Views/ProjekatAktivnostRealizacija/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1808fa79f603ab8fab89a9a6151c08e70e9deb", @"/Areas/UserReport/Views/ProjekatAktivnostRealizacija/Uredi.cshtml")]
    public class Areas_UserReport_Views_ProjekatAktivnostRealizacija_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
  
    ProjekatAktivnostRealizacija temp = (ProjekatAktivnostRealizacija)ViewData["uredi"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <h1>Uređivanje Realizacija</h1>\r\n    <form method=\"post\" action=\"/UserReport/ProjekatAktivnostRealizacija/UrediSnimi\">\r\n        <table>\r\n            <tr>\r\n                <input hidden=\"hidden\" name=\"realizacijaId\"");
            BeginWriteAttribute("value", " value=\"", 482, "\"", 527, 1);
#nullable restore
#line 14 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 490, temp.ProjekatAktivnostRealizacija_ID, 490, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></input>\r\n                <input hidden=\"hidden\" name=\"aktivnostId\"");
            BeginWriteAttribute("value", " value=\"", 596, "\"", 634, 1);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 604, temp.ProjekatAktivnostPlan_FK, 604, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></input>\r\n                <td><label>Naziv aktivnosti</label></td>\r\n                <td><input name=\"projekat\" readonly=\"readonly\"");
            BeginWriteAttribute("value", " value=\"", 766, "\"", 807, 1);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 774, temp.projekatAktivnostPlan.Naziv, 774, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Količina</label></td>\r\n                <td><input");
            BeginWriteAttribute("value", " value=\"", 931, "\"", 953, 1);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 939, temp.Kolicina, 939, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"kolicina\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Datum</label></td>\r\n                <td><input type=\"datetime\"");
            BeginWriteAttribute("value", " value=\"", 1106, "\"", 1130, 1);
#nullable restore
#line 25 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1114, temp.Datum.Date, 1114, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"datum\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Opis</label></td>\r\n                <td><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1275, "\"", 1293, 1);
#nullable restore
#line 29 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1283, temp.Opis, 1283, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"opis\" /></td>\r\n            </tr>\r\n        </table>\r\n\r\n        <button class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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
