#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356ed42bf924bd5570aa750b13c4417871b0b9ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Status_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Status/Uredi.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"356ed42bf924bd5570aa750b13c4417871b0b9ab", @"/Areas/SuperAdmin/Views/Status/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_Status_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    Status stat = (Status)ViewData["status"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <h1>Uređivanje statusa</h1><br /><br />\r\n    <form method=\"post\" action=\"/SuperAdmin/Status/UrediSnimi\">\r\n        <input hidden=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 336, "\"", 358, 1);
#nullable restore
#line 11 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 344, stat.StatusID, 344, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>Naziv</label>\r\n                </td>\r\n                <td>\r\n                    <input name=\"naziv\"");
            BeginWriteAttribute("value", " value=\"", 547, "\"", 566, 1);
#nullable restore
#line 18 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 555, stat.Naziv, 555, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Šifra</label>\r\n                </td>\r\n                <td>\r\n                    <input name=\"sifra\"");
            BeginWriteAttribute("value", " value=\"", 780, "\"", 799, 1);
#nullable restore
#line 26 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 788, stat.Sifra, 788, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <button class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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
