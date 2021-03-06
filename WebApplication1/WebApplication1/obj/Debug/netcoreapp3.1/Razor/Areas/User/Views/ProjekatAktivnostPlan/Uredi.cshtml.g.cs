#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2175e03a491b47870776f16a070626e9e109bb19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_ProjekatAktivnostPlan_Uredi), @"mvc.1.0.view", @"/Areas/User/Views/ProjekatAktivnostPlan/Uredi.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2175e03a491b47870776f16a070626e9e109bb19", @"/Areas/User/Views/ProjekatAktivnostPlan/Uredi.cshtml")]
    public class Areas_User_Views_ProjekatAktivnostPlan_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_user.cshtml";

    ProjekatAktivnostPlan aktiv = (ProjekatAktivnostPlan)ViewData["aktiv"];

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .loader {
        position: relative;
        border: 2.5vw solid #c2fdc5;
        border-top: 2.5vw solid #28a524;
        border-radius: 50%;
        width: 8vw;
        height: 8vw;
        animation: spin 1s linear infinite;
        margin: auto;
    }

    ");
            WriteLiteral(@"@keyframes spin {
        0% {
            transform: rotate(0deg);
        }

        100% {
            transform: rotate(360deg);
        }
    }

    #tekst_ucitava {
        position: relative;
        text-align: center;
        font-family: Agency FB;
        font-size: 5vw;
        font-weight: bold;
        width: 100%;
        margin: auto;
    }

    #tekst_i_animacija {
        position: absolute;
        height: 30%;
        width: 30%;
        margin-left: 25%;
        margin-top: 8vw;
    }

    #podloga {
        position: absolute;
        width: 70%;
        height: 100%;
        margin-top: 5%;
    }
</style>
<center>
    <div id=""zaglavlje"" style=""width:100%"">
        <h1 style=""position:relative; display:inline;"">Uređivanje projektne aktivnosti</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 1569, "\"", 1582, 1);
#nullable restore
#line 64 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 1575, imgsrc, 1575, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <div id=\"podloga\">\r\n        <form method=\"post\" action=\"/User/ProjekatAktivnostPlan/UrediSnimi\">\r\n            <input hidden=\"hidden\" name=\"projekatPlanId\"");
            BeginWriteAttribute("value", " value=\"", 1782, "\"", 1812, 1);
#nullable restore
#line 70 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 1790, aktiv.ProjekatPlan_FK, 1790, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input hidden=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1862, "\"", 1901, 1);
#nullable restore
#line 71 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 1870, aktiv.ProjekatAktivnostPlan_ID, 1870, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

            <table>
                <tr>
                    <td>
                        <label>
                            Naziv
                        </label>
                    </td>
                    <td>
                        <input name=""naziv""");
            BeginWriteAttribute("value", " value=\"", 2176, "\"", 2196, 1);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 2184, aktiv.Naziv, 2184, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>
                            Šifra
                        </label>
                    </td>
                    <td>
                        <input name=""sifra""");
            BeginWriteAttribute("value", " value=\"", 2498, "\"", 2518, 1);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 2506, aktiv.Sifra, 2506, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>
                            Količina
                        </label>
                    </td>
                    <td>
                        <input name=""kolicina""");
            BeginWriteAttribute("value", " value=\"", 2826, "\"", 2849, 1);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 2834, aktiv.Kolicina, 2834, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>
                            Jedinica mjere
                        </label>
                    </td>
                    <td>
                        <input name=""jedinicaMjere""");
            BeginWriteAttribute("value", " value=\"", 3168, "\"", 3196, 1);
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 3176, aktiv.JedinicaMjere, 3176, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>
                            Datum od
                        </label>
                    </td>
                    <td>
                        <input name=""OD"" type=""datetime""");
            BeginWriteAttribute("value", " value=\"", 3514, "\"", 3536, 1);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 3522, aktiv.DatumOd, 3522, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>
                            Datum do
                        </label>
                    </td>
                    <td>
                        <input name=""DO"" type=""datetime""");
            BeginWriteAttribute("value", " value=\"", 3854, "\"", 3876, 1);
#nullable restore
#line 131 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 3862, aktiv.DatumDo, 3862, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </td>
                </tr>
            </table>
            <button class=""btn btn-primary"" type=""submit"" id=""go"">Snimi</button>
        </form>
    </div>
    <div id=""tekst_i_animacija"">
        <div class=""loader""></div>
        <p id=""tekst_ucitava"">Loading...</p>
    </div>
</center>

<script>
    $(document).ready(function () {
        $(""#tekst_i_animacija"").hide();
    });

    $(""#go"").click(function () {
        $(""#tekst_i_animacija"").show();
        document.getElementById(""podloga"").style.filter = ""blur(10px)"";
        document.getElementById(""zaglavlje"").style.filter = ""blur(10px)"";
    });
</script>");
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
