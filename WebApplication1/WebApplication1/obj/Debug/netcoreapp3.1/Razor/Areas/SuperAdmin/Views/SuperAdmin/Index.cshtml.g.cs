#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\SuperAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eda035a9c4f9e81349e3062fa8f7d2d217dbb371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_SuperAdmin_Index), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/SuperAdmin/Index.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\SuperAdmin\Index.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\SuperAdmin\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda035a9c4f9e81349e3062fa8f7d2d217dbb371", @"/Areas/SuperAdmin/Views/SuperAdmin/Index.cshtml")]
    public class Areas_SuperAdmin_Views_SuperAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.uor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\SuperAdmin\Index.cshtml"
  Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<center>
    <h1>Admin</h1><br />
    <h1>Meni</h1>

    <table>
        <tr>
            <td>Država</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/Drzava/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/Drzava/Unos"">Unos</a></td>
        </tr>
        <tr>
            <td>Korisnici</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/Korisnik/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/Korisnik/Unos"">Unos</a></td>
        </tr>
        <tr>
            <td>Korisnici - Organizaciona Jedinica</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/KorisnikOrg/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/KorisnikOrg/Unos"">Unos</a></td>
        </tr>
        <tr>
            <td>Organizacija</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/Organizacija/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-succe");
            WriteLiteral(@"ss"" href=""/SuperAdmin/Organizacija/Unos"">Unos</a></td>
        </tr>
        <tr>
            <td>Organizaciona Jedinica</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/OrganizacionaJedinica/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/OrganizacionaJedinica/Unos"">Unos</a></td>
        </tr>
        <tr>
            <td>Projekat Aktivnost Plan</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/ProjekatAktivnostPlan/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/ProjekatAktivnostPlan/Unos"">Unos</a></td>
        </tr>
        <tr>
            <td>Projekat Aktivnost Realizacija</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/ProjekatAktivnostRealizacija/Unos"">Unos</a></td>
            <td><a class=""btn btn-warning"" href=""/SuperAdmin/ProjekatAktivnostRealizaci");
            WriteLiteral(@"ja/Detalji"">Detalji</a></td>
        </tr>
        <tr>
            <td>Projekat Plan</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/ProjekatPlan/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/ProjekatPlan/Unos"">Unos</a></td>
        </tr>
        <tr>
            <td>PTT</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/PTT/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/PTT/Unos"">Unos</a></td>
        </tr>
        <tr>
            <td>Resursi</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/Resursi/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/Resursi/Unos"">Unos</a></td>
        </tr>
        <tr>
            <td>Uloge</td>
            <td><a class=""btn btn-primary"" href=""/SuperAdmin/Uloge/Prikaz"">Prikaz</a></td>
            <td><a class=""btn btn-success"" href=""/SuperAdmin/Uloge/Unos"">Unos</a></td>
        </tr>
    </tab");
            WriteLiteral("le>\r\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.uor> Html { get; private set; }
    }
}
#pragma warning restore 1591
