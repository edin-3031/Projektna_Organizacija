#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87a99c063b6d424388f4ee8dc49b8866c270bbce"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a99c063b6d424388f4ee8dc49b8866c270bbce", @"/Areas/AdminOrg/Views/AdminOrg/Index.cshtml")]
    public class Areas_AdminOrg_Views_AdminOrg_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
  
    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["slika"];


    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

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
            BeginWriteAttribute("href", " href=\"", 2035, "\"", 2113, 6);
            WriteAttributeValue("", 2042, "/AdminOrg/AdminOrg/Index?u=", 2042, 27, true);
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2069, id.userId, 2069, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2079, "&o=", 2079, 3, true);
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2082, id.organisationId, 2082, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2100, "&r=", 2100, 3, true);
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2103, id.roleId, 2103, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2269, "\"", 2361, 6);
            WriteAttributeValue("", 2276, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2276, 41, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2317, id.userId, 2317, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2327, "&o=", 2327, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2330, id.organisationId, 2330, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2348, "&r=", 2348, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2351, id.roleId, 2351, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2418, "\"", 2500, 6);
            WriteAttributeValue("", 2425, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2425, 31, true);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2456, id.userId, 2456, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2466, "&o=", 2466, 3, true);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2469, id.organisationId, 2469, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2487, "&r=", 2487, 3, true);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2490, id.roleId, 2490, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2663, "\"", 2746, 6);
            WriteAttributeValue("", 2670, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2670, 32, true);
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2702, id.userId, 2702, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2712, "&o=", 2712, 3, true);
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2715, id.organisationId, 2715, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2733, "&r=", 2733, 3, true);
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2736, id.roleId, 2736, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2785, "\"", 2877, 6);
            WriteAttributeValue("", 2792, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2792, 41, true);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2833, id.userId, 2833, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2843, "&o=", 2843, 3, true);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2846, id.organisationId, 2846, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2864, "&r=", 2864, 3, true);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 2867, id.roleId, 2867, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3017, "\"", 3116, 6);
            WriteAttributeValue("", 3024, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 3024, 48, true);
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3072, id.userId, 3072, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3082, "&o=", 3082, 3, true);
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3085, id.organisationId, 3085, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3103, "&r=", 3103, 3, true);
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3106, id.roleId, 3106, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3247, "\"", 3326, 6);
            WriteAttributeValue("", 3254, "/AdminOrg/Korisnik/Prikaz?u=", 3254, 28, true);
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3282, id.userId, 3282, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3292, "&o=", 3292, 3, true);
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3295, id.organisationId, 3295, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3313, "&r=", 3313, 3, true);
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 3316, id.roleId, 3316, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <img style=\"height:45vw; width:81vw;\"");
            BeginWriteAttribute("src", " src=\"", 5211, "\"", 5224, 1);
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\AdminOrg\Index.cshtml"
WriteAttributeValue("", 5217, imgsrc, 5217, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</center>");
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
