#pragma checksum "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cd7a2dd29d55f466d4e4c5278a762bdbc6bfe95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_ProjekatAktivnostRealizacija_PrintPreview), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
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
#line 1 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd7a2dd29d55f466d4e4c5278a762bdbc6bfe95", @"/Areas/AdminOrg/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatAktivnostRealizacija_PrintPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.lista_DetaljiRealizacijaVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"

    Layout = null;

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"zaglavlje\" style=\"width:100%\">\r\n    <h1 style=\"position:relative; display:inline;\">Print Preview</h1>\r\n    <img style=\"height:7vw; width:7vw; position:relative; float:right; display:inline;\"");
            BeginWriteAttribute("src", " src=\"", 523, "\"", 536, 1);
#nullable restore
#line 14 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 529, imgsrc, 529, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n\r\n<div id=\"forPrint\">\r\n    <table class=\"table\">\r\n        <thead>\r\n        <th>Realizacija ID</th>\r\n");
            WriteLiteral("        <th>Aktivnost</th>\r\n        <th>Korisnik</th>\r\n        <th>Datum</th>\r\n        <th>Količnia</th>\r\n        <th>Opis</th>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 29 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
             foreach (var x in Model.lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 32 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.idRealizacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 34 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.NazivAktivnosti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.korisnik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.datum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.lista_DetaljiRealizacijaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
