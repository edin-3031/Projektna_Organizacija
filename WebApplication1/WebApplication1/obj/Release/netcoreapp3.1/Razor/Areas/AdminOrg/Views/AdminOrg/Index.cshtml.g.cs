#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04cb885abc1149813ab7badfe0f99a227b058ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_AdminOrg_Index), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/AdminOrg/Index.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04cb885abc1149813ab7badfe0f99a227b058ab0", @"/Areas/AdminOrg/Views/AdminOrg/Index.cshtml")]
    public class Areas_AdminOrg_Views_AdminOrg_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
  
    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    tr {
        /*border: 1px solid black;*/
    }

    td {
        padding: 10px;
    }

    a, td {
        /*font-weight: bold;*/
        text-align-last: center;
    }
</style>

<style>


    li, ul {
        list-style: none;
        margin-top: 5%;
    }

    ul {
        margin: 0px;
        padding: 0px;
        border: 0px;
    }

    #sifarnik, #transakcije, #izvjestaji, #admin {
        font-weight: bold;
    }

    a {
        color: white;
        text-decoration-line: none;
    }

    #dodaj, #detalji, #print_preview, #print_excel, #print_pdf {
        display: inline-block;
        margin: 2%;
    }

    #print_preview, #print_excel, #print_pdf {
        color: white;
    }

    #dugmad {
        margin-bottom: 2%;
        margin-top: 2%;
    }

    a:hover {
        color: white;
        text-decoration: none;
        text-decoration-line: none;
    }

    #kutijaZaMeni {
        position: fixed;
        height: 100%;
   ");
            WriteLiteral(@"     width: 17%;
        /*            background-color:green;*/
        display: block;
        margin-left: -17.8%;
    }

    #menu {
        position: fixed;
        /*height: 65%;*/
        width: 15%;
        margin-left: 0px;
        background-color: rgba(0, 0, 0, 0.8);
        color: white;
        top: 20%;
        font-size: 1vw;
        border-radius: 0px 25px 25px 0px;
    }
</style>
<div id=""kutijaZaMeni"">
    <div id=""menu"">
        <br />
        <a style=""color:white; text-decoration-line:none; font-size:120%;""");
            BeginWriteAttribute("href", " href=\"", 1867, "\"", 1945, 6);
            WriteAttributeValue("", 1874, "/AdminOrg/AdminOrg/Index?u=", 1874, 27, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 1901, id.userId, 1901, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1911, "&o=", 1911, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 1914, id.organisationId, 1914, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1932, "&r=", 1932, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 1935, id.roleId, 1935, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2103, "\"", 2195, 6);
            WriteAttributeValue("", 2110, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2110, 41, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2151, id.userId, 2151, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2161, "&o=", 2161, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2164, id.organisationId, 2164, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2182, "&r=", 2182, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2185, id.roleId, 2185, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2351, "\"", 2443, 6);
            WriteAttributeValue("", 2358, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2358, 41, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2399, id.userId, 2399, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2409, "&o=", 2409, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2412, id.organisationId, 2412, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2430, "&r=", 2430, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2433, id.roleId, 2433, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n\r\n        </ul>\r\n    </div>\r\n</div>\r\n<center>\r\n\r\n");
            WriteLiteral("\r\n    <h1>Admin_Org</h1><br />\r\n\r\n    <h1>Meni</h1>\r\n    <table>\r\n\r\n        <tr>\r\n            <td>Organizaciona Jedinica</td>\r\n            <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3504, "\"", 3596, 6);
            WriteAttributeValue("", 3511, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 3511, 41, true);
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3552, id.userId, 3552, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3562, "&o=", 3562, 3, true);
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3565, id.organisationId, 3565, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3583, "&r=", 3583, 3, true);
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3586, id.roleId, 3586, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Prikaz</a></td>\r\n            <td><a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3657, "\"", 3747, 6);
            WriteAttributeValue("", 3664, "/AdminOrg/OrganizacionaJedinica/Unos?u=", 3664, 39, true);
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3703, id.userId, 3703, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3713, "&o=", 3713, 3, true);
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3716, id.organisationId, 3716, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3734, "&r=", 3734, 3, true);
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3737, id.roleId, 3737, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Unos</a></td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>Projekat Aktivnost Plan</td>\r\n            <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3883, "\"", 3975, 6);
            WriteAttributeValue("", 3890, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 3890, 41, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3931, id.userId, 3931, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3941, "&o=", 3941, 3, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3944, id.organisationId, 3944, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3962, "&r=", 3962, 3, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3965, id.roleId, 3965, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Prikaz</a></td>\r\n            <td><a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 4036, "\"", 4126, 6);
            WriteAttributeValue("", 4043, "/AdminOrg/ProjekatAktivnostPlan/Unos?u=", 4043, 39, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 4082, id.userId, 4082, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4092, "&o=", 4092, 3, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 4095, id.organisationId, 4095, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4113, "&r=", 4113, 3, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 4116, id.roleId, 4116, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Unos</a></td>\r\n        </tr>\r\n\r\n    </table>\r\n</center>");
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