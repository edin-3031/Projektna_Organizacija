#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5e113f828aa7675c8465bf04df87e71e0792a65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_OrganizacionaJedinica_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/OrganizacionaJedinica/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5e113f828aa7675c8465bf04df87e71e0792a65", @"/Areas/AdminOrg/Views/OrganizacionaJedinica/Prikaz.cshtml")]
    public class Areas_AdminOrg_Views_OrganizacionaJedinica_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
  
    List<OrganizacionaJedinica> lista = (List<OrganizacionaJedinica>)ViewData["org_jed"];

    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <h1>Prikaz Organizacionih Jedinica</h1>\r\n\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 502, "\"", 592, 6);
            WriteAttributeValue("", 509, "/AdminOrg/OrganizacionaJedinica/Unos?u=", 509, 39, true);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
WriteAttributeValue("", 548, id.userId, 548, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 558, "&o=", 558, 3, true);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
WriteAttributeValue("", 561, id.organisationId, 561, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 579, "&r=", 579, 3, true);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
WriteAttributeValue("", 582, id.roleId, 582, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">Unesi novu</a>
        </div>
    </div>

    <table class=""table"">
        <thead>
        <th>ID</th>
        <th>Organizacija</th>
        <th>PTT</th>
        <th>Država</th>
        <th>Naziv</th>
        <th>Adresa</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 32 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
                   Write(x.OrganizacionaJedinica_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
                   Write(x.organizacija.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
                   Write(x.ptt.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
                   Write(x.drzava.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
                   Write(x.Adresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1296, "\"", 1419, 8);
            WriteAttributeValue("", 1303, "/AdminOrg/OrganizacionaJedinica/Ukloni?id=", 1303, 42, true);
#nullable restore
#line 41 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
WriteAttributeValue("", 1345, x.OrganizacionaJedinica_ID, 1345, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1372, "&u=", 1372, 3, true);
#nullable restore
#line 41 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
WriteAttributeValue("", 1375, id.userId, 1375, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1385, "&o=", 1385, 3, true);
#nullable restore
#line 41 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
WriteAttributeValue("", 1388, id.organisationId, 1388, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1406, "&r=", 1406, 3, true);
#nullable restore
#line 41 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
WriteAttributeValue("", 1409, id.roleId, 1409, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Ukloni</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Prikaz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</center>");
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
