#pragma checksum "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Resursi\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15a981bc663028706b4426cc67f30f2d8bc6d55c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Resursi_Unos), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Resursi/Unos.cshtml")]
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
#line 1 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Resursi\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Resursi\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15a981bc663028706b4426cc67f30f2d8bc6d55c", @"/Areas/SuperAdmin/Views/Resursi/Unos.cshtml")]
    public class Areas_SuperAdmin_Views_Resursi_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Resursi\Unos.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <h1>Prikaz Resursa</h1>
    <form action=""/SuperAdmin/Resursi/UnosSnimi"">
        <table>
            <tr>
                <td><label>Naziv</label></td>
                <td><input type=""text"" name=""naziv"" /></td>
            </tr>
        </table>
        <button class=""btn btn-primary"" type=""submit"">Spremi</button>
    </form>
</center>");
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
