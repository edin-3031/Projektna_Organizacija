#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deed1926734c5244c7989e487b8e6a08e897425f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjekatAktivnostRealizacija_Uredi), @"mvc.1.0.view", @"/Views/ProjekatAktivnostRealizacija/Uredi.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deed1926734c5244c7989e487b8e6a08e897425f", @"/Views/ProjekatAktivnostRealizacija/Uredi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjekatAktivnostRealizacija_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ProjekatAktivnostRealizacija/UrediSnimi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
  
    ProjekatAktivnostRealizacija temp = (ProjekatAktivnostRealizacija)ViewData["uredi"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <h1>Uređivanje Realizacija</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deed1926734c5244c7989e487b8e6a08e897425f4412", async() => {
                WriteLiteral("\r\n        <table>\r\n            <tr>\r\n                <input hidden=\"hidden\" name=\"realizacijaId\"");
                BeginWriteAttribute("value", " value=\"", 439, "\"", 484, 1);
#nullable restore
#line 13 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 447, temp.ProjekatAktivnostRealizacija_ID, 447, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n                <input hidden=\"hidden\" name=\"aktivnostId\"");
                BeginWriteAttribute("value", " value=\"", 553, "\"", 591, 1);
#nullable restore
#line 14 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 561, temp.ProjekatAktivnostPlan_FK, 561, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n                <td><label>Naziv aktivnosti</label></td>\r\n                <td><input name=\"projekat\" readonly=\"readonly\"");
                BeginWriteAttribute("value", " value=\"", 723, "\"", 764, 1);
#nullable restore
#line 16 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 731, temp.projekatAktivnostPlan.Naziv, 731, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Količina</label></td>\r\n                <td><input");
                BeginWriteAttribute("value", " value=\"", 888, "\"", 910, 1);
#nullable restore
#line 20 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 896, temp.Kolicina, 896, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"kolicina\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Datum</label></td>\r\n                <td><input type=\"datetime\"");
                BeginWriteAttribute("value", " value=\"", 1063, "\"", 1087, 1);
#nullable restore
#line 24 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1071, temp.Datum.Date, 1071, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"datum\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Opis</label></td>\r\n                <td><input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1232, "\"", 1250, 1);
#nullable restore
#line 28 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Uredi.cshtml"
WriteAttributeValue("", 1240, temp.Opis, 1240, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"opis\" /></td>\r\n            </tr>\r\n        </table>\r\n\r\n        <button class=\"btn btn-primary\">Snimi</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</center>");
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
