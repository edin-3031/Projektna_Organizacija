#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0b61e1af404a5cbbd6da138e6f237a094f962d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProjekatAktivnostRealizacija_Uredi), @"mvc.1.0.view", @"/Areas/Admin/Views/ProjekatAktivnostRealizacija/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0b61e1af404a5cbbd6da138e6f237a094f962d", @"/Areas/Admin/Views/ProjekatAktivnostRealizacija/Uredi.cshtml")]
    public class Areas_Admin_Views_ProjekatAktivnostRealizacija_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
  
    ProjekatAktivnostRealizacija temp = (ProjekatAktivnostRealizacija)ViewData["uredi"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <h1>Uređivanje Realizacija</h1>\r\n    <form method=\"post\" action=\"/Admin/ProjekatAktivnostRealizacija/UrediSnimi\">\r\n        <table>\r\n            <tr>\r\n                <input hidden=\"hidden\" name=\"realizacijaId\"");
            BeginWriteAttribute("value", " value=\"", 477, "\"", 522, 1);
#nullable restore
#line 14 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 485, temp.ProjekatAktivnostRealizacija_ID, 485, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></input>\r\n                <input hidden=\"hidden\" name=\"aktivnostId\"");
            BeginWriteAttribute("value", " value=\"", 591, "\"", 629, 1);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 599, temp.ProjekatAktivnostPlan_FK, 599, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></input>\r\n                <td><label>Naziv aktivnosti</label></td>\r\n                <td><input name=\"projekat\" readonly=\"readonly\"");
            BeginWriteAttribute("value", " value=\"", 761, "\"", 802, 1);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 769, temp.projekatAktivnostPlan.Naziv, 769, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Količina</label></td>\r\n                <td><input");
            BeginWriteAttribute("value", " value=\"", 926, "\"", 948, 1);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 934, temp.Kolicina, 934, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"kolicina\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Datum</label></td>\r\n                <td><input type=\"datetime\"");
            BeginWriteAttribute("value", " value=\"", 1101, "\"", 1125, 1);
#nullable restore
#line 25 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1109, temp.Datum.Date, 1109, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"datum\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Opis</label></td>\r\n                <td><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1270, "\"", 1288, 1);
#nullable restore
#line 29 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1278, temp.Opis, 1278, 10, false);

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