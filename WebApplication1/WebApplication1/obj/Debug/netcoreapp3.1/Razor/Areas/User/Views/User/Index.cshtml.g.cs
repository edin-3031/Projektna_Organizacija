#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e612b416918a61d86ed678040c0214317cbd356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_User_Index), @"mvc.1.0.view", @"/Areas/User/Views/User/Index.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\User\Index.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e612b416918a61d86ed678040c0214317cbd356", @"/Areas/User/Views/User/Index.cshtml")]
    public class Areas_User_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\User\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout_user.cshtml";

    byte[] pic = (byte[])ViewData["slika"];


    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <img style=\"height:45vw; width:81vw;\"");
            BeginWriteAttribute("src", " src=\"", 313, "\"", 326, 1);
#nullable restore
#line 12 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\User\Index.cshtml"
WriteAttributeValue("", 319, imgsrc, 319, 7, false);

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
