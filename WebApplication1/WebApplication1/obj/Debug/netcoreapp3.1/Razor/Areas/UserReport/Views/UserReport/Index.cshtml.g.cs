#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "086900247ffe762553d4a693033a3edf289e014e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserReport_Views_UserReport_Index), @"mvc.1.0.view", @"/Areas/UserReport/Views/UserReport/Index.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"086900247ffe762553d4a693033a3edf289e014e", @"/Areas/UserReport/Views/UserReport/Index.cshtml")]
    public class Areas_UserReport_Views_UserReport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.uor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout_user_report.cshtml";

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
<center>

    <h1>User_Report</h1><br />

    <h1>Meni</h1>
    <table>
        <tr>
            <td>Projekat Aktivnost Realizacija</td>
            <td><a class=""btn btn-primary""");
            BeginWriteAttribute("href", " href=\"", 689, "\"", 799, 6);
            WriteAttributeValue("", 696, "/UserReport/ProjekatAktivnostRealizacija/Prikaz?u=", 696, 50, true);
#nullable restore
#line 33 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
WriteAttributeValue("", 746, Model.userId, 746, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 759, "&o=", 759, 3, true);
#nullable restore
#line 33 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
WriteAttributeValue("", 762, Model.organisationId, 762, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 783, "&r=", 783, 3, true);
#nullable restore
#line 33 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
WriteAttributeValue("", 786, Model.roleId, 786, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Prikaz</a></td>\r\n");
            WriteLiteral("            <td><a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 975, "\"", 1086, 6);
            WriteAttributeValue("", 982, "/UserReport/ProjekatAktivnostRealizacija/Detalji?u=", 982, 51, true);
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
WriteAttributeValue("", 1033, Model.userId, 1033, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1046, "&o=", 1046, 3, true);
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
WriteAttributeValue("", 1049, Model.organisationId, 1049, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1070, "&r=", 1070, 3, true);
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
WriteAttributeValue("", 1073, Model.roleId, 1073, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalji</a></td>\r\n        </tr>\r\n    </table>\r\n</center>");
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
