#pragma checksum "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e54f79a941bfb9d6648e8214b86418465c3eede0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjekatAktivnostRealizacija_Detalji), @"mvc.1.0.view", @"/Views/ProjekatAktivnostRealizacija/Detalji.cshtml")]
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
#line 1 "D:\New Project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54f79a941bfb9d6648e8214b86418465c3eede0", @"/Views/ProjekatAktivnostRealizacija/Detalji.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjekatAktivnostRealizacija_Detalji : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.lista_realizacijaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ProjekatAktivnostRealizacija/Detalji"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"

    List<ProjekatPlan> projekti = (List<ProjekatPlan>)ViewData["projekti"];

    List<WebApplication1.Models.VM.RealizacijaVM> lista_projekata = (List<WebApplication1.Models.VM.RealizacijaVM>)ViewData["lista_projekata"];

    RealizacijaDetaljiSuma suma = (RealizacijaDetaljiSuma)ViewData["suma"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #cb{
        width:50%;
    }
    td{
        padding:2%; 
    }
    #progressBar {
        border: 1px solid black;
        background-color: dimgray;
        height: 25px;
        width: 100%;
    }
    #vrijednost {
        position: relative;
        background-color: dodgerblue;
        height: 100%;
        display:block;
    }
    #dat2{
        width:100%;
    }

</style>
<center>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e54f79a941bfb9d6648e8214b86418465c3eede05087", async() => {
                WriteLiteral("\r\n\r\n        <table>\r\n            <tr>\r\n                <td><label>Projekat</label></td>\r\n                <td>\r\n                    <select name=\"projekatId\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e54f79a941bfb9d6648e8214b86418465c3eede05540", async() => {
                    WriteLiteral("---Odaberi---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 47 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                         foreach (var x in projekti)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e54f79a941bfb9d6648e8214b86418465c3eede06883", async() => {
#nullable restore
#line 49 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                          Write(x.Naziv);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                               WriteLiteral(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 50 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td><label>Datum od</label></td>
                <td><input id=""dat2"" type=""datetime-local"" name=""OD"" /></td>
            </tr>
            <tr>
                <td><label>Datum do</label></td>
                <td><input id=""dat2"" type=""datetime-local"" name=""DO"" /></td>
            </tr>
");
                WriteLiteral("        </table>\r\n        <button type=\"submit\" class=\"btn btn-primary\" id=\"tragaj\" name=\"traziDugme\" value=\"10\">Traži</button>\r\n    ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 69 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
     if (Model.liste != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
         if (Model.liste.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <center>
                <div id=""podaci"">
                    <br /><br />
                    <h3>Rezultati projekata</h3>

                    <table style=""border:5px solid black"" class=""table"">
                        <thead>
                        <th>Projekat</th>
                        <th>Aktivnost</th>
                        <th>Datum</th>
                        <th>Planirano</th>
                        <th>Ostvareno</th>
                        <th>Procenti</th>
                        <th>Grafički</th>
                        <th>Detalji</th>
                        </thead>
                        <tbody>
");
#nullable restore
#line 90 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                             foreach (var x in Model.liste)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 93 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(x.nazivProjekta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 94 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(x.naziv_aktivnosti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 95 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                    Write(x.datum.Day + "." + x.datum.Month + "." + x.datum.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 96 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(x.planirano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 97 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(x.odradjeno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 98 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                    Write(Math.Round((x.odradjeno / x.planirano) * 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                    <td>\r\n                                        <div id=\"progressBar\" style=\"width:100%;\">\r\n                                            <div");
            BeginWriteAttribute("style", " style=\"", 3620, "\"", 3684, 3);
            WriteAttributeValue("", 3628, "width:", 3628, 6, true);
#nullable restore
#line 101 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3634, Math.Round((x.odradjeno / x.planirano) * 100), 3634, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3682, "%;", 3682, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"vrijednost\"></div>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-warning\"");
            BeginWriteAttribute("id", " id=\"", 3909, "\"", 3937, 2);
            WriteAttributeValue("", 3914, "Detalji__", 3914, 9, true);
#nullable restore
#line 105 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3923, x.aktivnostId, 3923, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalji</a>\r\n                                        <script>\r\n                                        $(\"#Detalji__");
#nullable restore
#line 107 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                Write(x.aktivnostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function (event) {\r\n                                            $.get(\"/Ajax/DetaljiRealizacija?idAktivnost=");
#nullable restore
#line 108 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                   Write(x.aktivnostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&idProjekat=");
#nullable restore
#line 108 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                             Write(x.projekatId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&idRealizacija=");
#nullable restore
#line 108 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                                                         Write(x.realizacijaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&korisnikId=");
#nullable restore
#line 108 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                                                                                     Write(x.korisnikId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", function (result) {
                                                $(""#box"").show();
                                                $(""#glavni"").show();
                                                $(""#box"").html(result);
                                                $(""#glavni"").css(""border"", ""5px solid black"");
                                            });
                                        });
                                        </script>
                                    </td>
                                </tr>
");
#nullable restore
#line 118 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                             if (suma != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tr>
                                    <hr />
                                    <td style=""font-weight:bold;"">Projekat</td>
                                    <td style=""font-weight:bold;"">Planirano</td>
                                    <td style=""font-weight:bold;"">Ostvareno</td>
                                    <td style=""font-weight:bold;"">Procentualno</td>
                                    <td style=""font-weight:bold;"">Grafički</td>
                                </tr>
                                <tr>
                                    <hr />
                                    <td>");
#nullable restore
#line 131 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(suma.naziv_projekta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 132 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(suma.planirano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 133 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(suma.ostvareno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 134 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                    Write(Math.Round(suma.procenti) + "%");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <div id=\"progressBar\" style=\"width:100%;\">\r\n                                            <div");
            BeginWriteAttribute("style", " style=\"", 6008, "\"", 6052, 3);
            WriteAttributeValue("", 6016, "width:", 6016, 6, true);
#nullable restore
#line 137 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 6022, Math.Round(suma.procenti), 6022, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6050, "%;", 6050, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"vrijednost\"></div>\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 141 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </center>\r\n");
#nullable restore
#line 147 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</center>\r\n<center>\r\n    <div id=\"glavni\">\r\n        <div id=\"box\">\r\n        </div>\r\n    </div>\r\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.lista_realizacijaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
