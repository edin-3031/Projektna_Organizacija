#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Uloge\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4e86da9e23b913d683c7db2aa9e933c4491641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Uloge_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Uloge/Uredi.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Uloge\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Uloge\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4e86da9e23b913d683c7db2aa9e933c4491641", @"/Areas/SuperAdmin/Views/Uloge/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_Uloge_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Uloge\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    Uloge uloga = (Uloge)ViewData["uloga"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <form method=""post"" action=""/SuperAdmin/Uloge/UrediSnimi"">
        <table>
            <tr>
                <td>
                    <label>Naziv</label>
                </td>
                <td>
                    <input type=""text"" name=""naziv""");
            BeginWriteAttribute("value", " value=\"", 443, "\"", 463, 1);
#nullable restore
#line 16 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Uloge\Uredi.cshtml"
WriteAttributeValue("", 451, uloga.Naziv, 451, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Šifra</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"sifra\"");
            BeginWriteAttribute("value", " value=\"", 689, "\"", 709, 1);
#nullable restore
#line 24 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Uloge\Uredi.cshtml"
WriteAttributeValue("", 697, uloga.Sifra, 697, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Opis</label>\r\n                </td>\r\n                <td>\r\n                    <input style=\"width:600px;\" type=\"text\" name=\"opis\"");
            BeginWriteAttribute("value", " value=\"", 954, "\"", 973, 1);
#nullable restore
#line 32 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Uloge\Uredi.cshtml"
WriteAttributeValue("", 962, uloga.Opis, 962, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n\r\n        <button class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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
