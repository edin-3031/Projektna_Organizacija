#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "798cb2e96db29b2c936ccaeae3c1735e01bed3a0"
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798cb2e96db29b2c936ccaeae3c1735e01bed3a0", @"/Areas/UserReport/Views/UserReport/Index.cshtml")]
    public class Areas_UserReport_Views_UserReport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.uor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout_user_report.cshtml";

    byte[] pic = (byte[])ViewData["slika"];

    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

    var organizacija = Context.Session.GetString("organisation");
    var organizacijaId = Context.Session.GetInt32("organisation ID");
    var organizacionaJedinica = Context.Session.GetString("orgJed");
    var organizacionaJedinicaId = Context.Session.GetInt32("orgJed ID");
    var password = Context.Session.GetString("password");
    var role = Context.Session.GetString("role");
    var roleId = Context.Session.GetInt32("role ID");
    var user = Context.Session.GetString("user");
    var userId = Context.Session.GetInt32("user ID");
    var username = Context.Session.GetString("username");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n\r\n    td {\r\n        padding: 10px;\r\n    }\r\n\r\n    a, td {\r\n        text-align-last: center;\r\n    }\r\n</style>\r\n\r\n<img style=\"height:45vw; width:81vw;\"");
            BeginWriteAttribute("src", " src=\"", 1146, "\"", 1159, 1);
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
WriteAttributeValue("", 1152, imgsrc, 1152, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<br />\r\n<h1>Organizacija: ");
#nullable restore
#line 39 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
             Write(organizacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h1>Organizacija ID: ");
#nullable restore
#line 41 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
                Write(organizacijaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h1>Organizaciona Jedinica: ");
#nullable restore
#line 43 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
                       Write(organizacionaJedinica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h1>Organizaciona Jedinica ID: ");
#nullable restore
#line 45 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
                          Write(organizacionaJedinicaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h1>Lozinka: ");
#nullable restore
#line 47 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
        Write(password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h1>Uloga: ");
#nullable restore
#line 49 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
      Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h1>Uloga ID: ");
#nullable restore
#line 51 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
         Write(roleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h1>Korisnik: ");
#nullable restore
#line 53 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
         Write(user);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h1>Korisnik ID: ");
#nullable restore
#line 55 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
            Write(userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h1>Korisničko ime: ");
#nullable restore
#line 57 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\UserReport\Views\UserReport\Index.cshtml"
               Write(username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />");
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
