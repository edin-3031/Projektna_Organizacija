#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b6f6e2f8f28faeb12d031c0f3577e775ca2db6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_ProjekatAktivnostRealizacija_Uredi), @"mvc.1.0.view", @"/Areas/User/Views/ProjekatAktivnostRealizacija/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b6f6e2f8f28faeb12d031c0f3577e775ca2db6", @"/Areas/User/Views/ProjekatAktivnostRealizacija/Uredi.cshtml")]
    public class Areas_User_Views_ProjekatAktivnostRealizacija_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
  
    ProjekatAktivnostRealizacija temp = (ProjekatAktivnostRealizacija)ViewData["uredi"];

    uor id = (uor)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <h1>Uređivanje Realizacija</h1>\r\n    <form method=\"post\" action=\"/User/ProjekatAktivnostRealizacija/UrediSnimi\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 493, "\"", 511, 1);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 501, id.userId, 501, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 556, "\"", 582, 1);
#nullable restore
#line 16 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 564, id.organisationId, 564, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 627, "\"", 645, 1);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 635, id.roleId, 635, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <table>\r\n            <tr>\r\n                <input hidden=\"hidden\" name=\"realizacijaId\"");
            BeginWriteAttribute("value", " value=\"", 745, "\"", 790, 1);
#nullable restore
#line 20 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 753, temp.ProjekatAktivnostRealizacija_ID, 753, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></input>\r\n                <input hidden=\"hidden\" name=\"aktivnostId\"");
            BeginWriteAttribute("value", " value=\"", 859, "\"", 897, 1);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 867, temp.ProjekatAktivnostPlan_FK, 867, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></input>\r\n                <td><label>Naziv aktivnosti</label></td>\r\n                <td><input name=\"projekat\" readonly=\"readonly\"");
            BeginWriteAttribute("value", " value=\"", 1029, "\"", 1070, 1);
#nullable restore
#line 23 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1037, temp.projekatAktivnostPlan.Naziv, 1037, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Količina</label></td>\r\n                <td><input");
            BeginWriteAttribute("value", " value=\"", 1194, "\"", 1216, 1);
#nullable restore
#line 27 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1202, temp.Kolicina, 1202, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"kolicina\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Datum</label></td>\r\n                <td><input type=\"datetime\"");
            BeginWriteAttribute("value", " value=\"", 1369, "\"", 1393, 1);
#nullable restore
#line 31 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1377, temp.Datum.Date, 1377, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"datum\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Opis</label></td>\r\n                <td><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1538, "\"", 1556, 1);
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1546, temp.Opis, 1546, 10, false);

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