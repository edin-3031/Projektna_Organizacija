#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2807459988432e04e40cc7eebf9702b71e899174"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Korisnik_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Korisnik/Uredi.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2807459988432e04e40cc7eebf9702b71e899174", @"/Areas/SuperAdmin/Views/Korisnik/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_Korisnik_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    Korisnici k = (Korisnici)ViewData["korisnik"];

    List<Uloge> uloge = (List<Uloge>)ViewData["uloge"];

    Korisnici kor = (Korisnici)ViewData["korisnik"];

    bool postoji = (bool)ViewData["postoji"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .err {
        border: 2px solid red;
    }

    span {
        position: absolute;
        float: right;
        margin-left: 1%;
        background-color: indianred;
        color: white;
        font-weight: bold;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2807459988432e04e40cc7eebf9702b71e8991743841", async() => {
                WriteLiteral(@"
    <script>

        $(document).ready(function () {
            document.getElementById(""snimi"").disabled = false;
        });

        var prvi, drugi, treci, cetvrti, peti, sesti, sedmi, osmi = true;

        function provjera(id) {
            if (id == ""ime_input"") {
                var ime = document.getElementById(id).value;

                if (ime === """") {
                    document.getElementById(id).classList.add('err');
                    document.getElementById(""ime_span"").innerHTML = ""Polje nesmije biti prazno"";
                    document.getElementById(""ime_span"").classList.add(""err"");
                    prvi = false;
                    document.getElementById(""snimi"").disabled = true;
                }
                else if (ime != """") {
                    document.getElementById(id).classList.remove('err');
                    document.getElementById(""ime_span"").innerHTML = """";
                    document.getElementById(""ime_span"").classList.remove(""err"");");
                WriteLiteral(@"
                    prvi = true;
                }
                if (prvi === true && drugi === true && treci === true && cetvrti === true && peti === true && sesti === true && sedmi === true && osmi === true) {
                    document.getElementById(""snimi"").disabled = false;
                }
            }
            else if (id == ""prezime_input"") {
                var prezime = document.getElementById(id).value;

                if (prezime === """") {
                    document.getElementById(id).classList.add('err');
                    document.getElementById(""prezime_span"").innerHTML = ""Polje nesmije biti prazno"";
                    document.getElementById(""prezime_span"").classList.add(""err"");
                    document.getElementById(""snimi"").disabled = true;
                    drugi = false;
                }
                else if (prezime != """") {
                    document.getElementById(id).classList.remove('err');
                    document.getElementById(""p");
                WriteLiteral(@"rezime_span"").innerHTML = """";
                    document.getElementById(""prezime_span"").classList.remove(""err"");
                    drugi = true;
                }
                if (prvi === true && drugi === true && treci === true && cetvrti === true && peti === true && sesti === true && sedmi === true && osmi === true) {
                    document.getElementById(""snimi"").disabled = false;
                }
            }
            else if (id == ""lozinka_input"") {
                var sifra = document.getElementById(id).value;

                if (sifra === """") {
                    document.getElementById(id).classList.add('err');
                    document.getElementById(""pass_span"").innerHTML = ""Polje nesmije biti prazno"";
                    document.getElementById(""pass_span"").classList.add(""err"");
                    document.getElementById(""snimi"").disabled = true;
                    treci = false;
                }
                else if (sifra.length < 8) {
           ");
                WriteLiteral(@"         document.getElementById(id).classList.add('err');
                    document.getElementById(""pass_span"").innerHTML = ""Lozinka mora imati najmanje 8 karaktera"";
                    document.getElementById(""pass_span"").classList.add(""err"");
                    treci = false;
                    document.getElementById(""snimi"").disabled = true;
                }
                else if (sifra != """") {
                    document.getElementById(id).classList.remove('err');
                    document.getElementById(""pass_span"").innerHTML = """";
                    document.getElementById(""pass_span"").classList.remove(""err"");
                    treci = true;
                }
                if (prvi === true && drugi === true && treci === true && cetvrti === true && peti === true && sesti === true && sedmi === true && osmi === true) {
                    document.getElementById(""snimi"").disabled = false;
                }
            }
            else if (id == ""korisnickoIme_input"")");
                WriteLiteral(@" {
                var username = document.getElementById(id).value;

                if (username === """") {
                    document.getElementById(id).classList.add('err');
                    document.getElementById(""username_span"").innerHTML = ""Polje nesmije biti prazno"";
                    document.getElementById(""username_span"").classList.add(""err"");
                    document.getElementById(""snimi"").disabled = true;
                    cetvrti = false;
                }
                else if (username != """") {
                    document.getElementById(id).classList.remove('err');
                    document.getElementById(""username_span"").innerHTML = """";
                    document.getElementById(""username_span"").classList.remove(""err"");
                    cetvrti = true;
                }
                if (prvi === true && drugi === true && treci === true && cetvrti === true && peti === true && sesti === true && sedmi === true && osmi === true) {
                    do");
                WriteLiteral(@"cument.getElementById(""snimi"").disabled = false;
                }
            }
            else if (id == ""sifra_input"") {
                var lozinka = document.getElementById(id).value;

                if (lozinka === """") {
                    document.getElementById(id).classList.add('err');
                    document.getElementById(""sifra_span"").innerHTML = ""Polje nesmije biti prazno"";
                    document.getElementById(""sifra_span"").classList.add(""err"");
                    document.getElementById(""snimi"").disabled = true;
                    peti = false;
                }
                else if (lozinka != """") {
                    document.getElementById(id).classList.remove('err');
                    document.getElementById(""sifra_span"").innerHTML = """";
                    document.getElementById(""sifra_span"").classList.remove(""err"");
                    peti = true;
                }
                if (prvi === true && drugi === true && treci === true && cetvrti =");
                WriteLiteral(@"== true && peti === true && sesti === true && sedmi === true && osmi === true) {
                    document.getElementById(""snimi"").disabled = false;
                }
            }
            else if (id == ""mail_input"") {
                var mail = document.getElementById(id).value;

                if (mail === """") {
                    document.getElementById(id).classList.add('err');
                    document.getElementById(""mail_span"").innerHTML = ""Polje nesmije biti prazno"";
                    document.getElementById(""mail_span"").classList.add(""err"");
                    document.getElementById(""snimi"").disabled = true;
                    sesti = false;
                }
                else if (mail != """") {
                    document.getElementById(id).classList.remove('err');
                    document.getElementById(""mail_span"").innerHTML = """";
                    document.getElementById(""mail_span"").classList.remove(""err"");
                    sesti = true;
         ");
                WriteLiteral(@"       }
                if (prvi === true && drugi === true && treci === true && cetvrti === true && peti === true && sesti === true && sedmi === true && osmi === true) {
                    document.getElementById(""snimi"").disabled = false;
                }
            }
            else if (id == ""telefon_input"") {
                var telefon = document.getElementById(id).value;

                if (telefon === """") {
                    document.getElementById(id).classList.add('err');
                    document.getElementById(""telefon_span"").innerHTML = ""Polje nesmije biti prazno"";
                    document.getElementById(""telefon_span"").classList.add(""err"");
                    document.getElementById(""snimi"").disabled = true;
                    sedmi = false;
                }
                else if (telefon != """") {
                    document.getElementById(id).classList.remove('err');
                    document.getElementById(""telefon_span"").innerHTML = """";
              ");
                WriteLiteral(@"      document.getElementById(""telefon_span"").classList.remove(""err"");
                    sedmi = true;
                }
                if (prvi === true && drugi === true && treci === true && cetvrti === true && peti === true && sesti === true && sedmi === true && osmi === true) {
                    document.getElementById(""snimi"").disabled = false;
                }
            }
            else if (id === ""uloga_select"") {
                var selected = document.getElementById(id).value;

                if (selected == 0) {
                    document.getElementById(id).classList.add('err');
                    document.getElementById(""select_span"").innerHTML = ""Morate odabrati jedno polje"";
                    document.getElementById(""select_span"").classList.add(""err"");
                    document.getElementById(""snimi_korisnik_unos"").disabled = true;
                    document.getElementById(""snimi"").disabled = true;
                    osmi = false;
                }
        ");
                WriteLiteral(@"        else if (selected > 0) {
                    document.getElementById(id).classList.remove('err');
                    document.getElementById(""select_span"").innerHTML = """";
                    document.getElementById(""select_span"").classList.remove(""err"");
                    osmi = true;
                }
                if (prvi === true && drugi === true && treci === true && cetvrti === true && peti === true && sesti === true && sedmi === true && osmi === true) {
                    document.getElementById(""snimi"").disabled = false;
                }
            }
        }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 209 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
 if (postoji)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center>\r\n        <form method=\"post\" action=\"/SuperAdmin/Korisnik/UrediSnimi\">\r\n\r\n            <input name=\"id\" hidden=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10601, "\"", 10624, 1);
#nullable restore
#line 214 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 10609, k.Korisnici_ID, 10609, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            <table>\r\n                <tr>\r\n                    <td>\r\n                        <label>Ime</label>\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"text\" name=\"ime\"");
            BeginWriteAttribute("value", " value=\"", 10851, "\"", 10867, 1);
#nullable restore
#line 222 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 10859, kor.Ime, 10859, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""ime_input"" onkeypress=""provjera('ime_input')"" onchange=""provjera('ime_input')"" onblur=""provjera('ime_input')"" /><span id=""ime_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Prezime</label>
                    </td>
                    <td>
                        <input type=""text"" name=""prezime""");
            BeginWriteAttribute("value", " value=\"", 11270, "\"", 11290, 1);
#nullable restore
#line 230 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 11278, kor.Prezime, 11278, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""prezime_input"" onkeypress=""provjera('prezime_input')"" onchange=""provjera('prezime_input')"" onblur=""provjera('prezime_input')"" /><span id=""prezime_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Šifra</label>
                    </td>
                    <td>
                        <input type=""text"" name=""sifra""");
            BeginWriteAttribute("value", " value=\"", 11709, "\"", 11727, 1);
#nullable restore
#line 238 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 11717, kor.Sifra, 11717, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""sifra_input"" onkeypress=""provjera('sifra_input')"" onchange=""provjera('sifra_input')"" onblur=""provjera('sifra_input')"" /><span id=""sifra_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Korisničko ime</label>
                    </td>
                    <td>
                        <input type=""text"" name=""korisnicko_ime""");
            BeginWriteAttribute("value", " value=\"", 12154, "\"", 12181, 1);
#nullable restore
#line 246 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 12162, kor.Korisnicko_Ime, 12162, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""korisnickoIme_input"" onkeypress=""provjera('korisnickoIme_input')"" onchange=""provjera('korisnickoIme_input')"" onblur=""provjera('korisnickoIme_input')"" />
                        <span id=""username_span""></span>

                        <script>
                            document.getElementById(""korisnickoIme_input"").classList.add('err');
                            document.getElementById(""username_span"").innerHTML = ""Korisničko ime je već u upotrebi"";
                            document.getElementById(""username_span"").classList.add(""err"");
                        </script>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Lozinka</label>
                    </td>
                    <td>
                        <input type=""text"" name=""lozinka""");
            BeginWriteAttribute("value", " value=\"", 13034, "\"", 13054, 1);
#nullable restore
#line 261 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 13042, kor.Lozinka, 13042, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""lozinka_input"" onkeypress=""provjera('lozinka_input')"" onchange=""provjera('lozinka_input')"" onblur=""provjera('lozinka_input')"" /><span id=""pass_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Mail</label>
                    </td>
                    <td>
                        <input type=""text"" name=""mail""");
            BeginWriteAttribute("value", " value=\"", 13468, "\"", 13485, 1);
#nullable restore
#line 269 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 13476, kor.Mail, 13476, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""mail_input"" onkeypress=""provjera('mail_input')"" onchange=""provjera('mail_input')"" onblur=""provjera('mail_input')"" /><span id=""mail_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Telefon</label>
                    </td>
                    <td>
                        <input type=""text"" name=""telefon""");
            BeginWriteAttribute("value", " value=\"", 13893, "\"", 13913, 1);
#nullable restore
#line 277 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 13901, kor.Telefon, 13901, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""telefon_input"" onkeypress=""provjera('telefon_input')"" onchange=""provjera('telefon_input')"" onblur=""provjera('telefon_input')"" /><span id=""telefon_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Uloga</label>
                    </td>
                    <td>
                        <select name=""uloga"" id=""uloga_select"" onselect=""provjera('uloga_select')"" onchange=""provjera('uloga_select')"" onblur=""provjera('uloga_select')"">
                            <option");
            BeginWriteAttribute("value", " value=\"", 14483, "\"", 14504, 1);
#nullable restore
#line 286 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 14491, kor.Uloge_FK, 14491, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 286 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                                                     Write(kor.uloge.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 287 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                             foreach (var x in uloge)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 14658, "\"", 14677, 1);
#nullable restore
#line 289 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 14666, x.Uloge_ID, 14666, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 289 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                                                       Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 290 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                        <span id=""select_span""></span>
                    </td>
                </tr>
            </table>

            <button class=""btn btn-primary"" id=""snimi"">Snimi</button>


        </form>
    </center>
");
#nullable restore
#line 302 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 303 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
 if (!postoji)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n        <form method=\"post\" action=\"/SuperAdmin/Korisnik/UrediSnimi\">\r\n\r\n            <input name=\"id\" hidden=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 15148, "\"", 15171, 1);
#nullable restore
#line 307 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 15156, k.Korisnici_ID, 15156, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            <table>\r\n                <tr>\r\n                    <td>\r\n                        <label>Ime</label>\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"text\" name=\"ime\"");
            BeginWriteAttribute("value", " value=\"", 15398, "\"", 15412, 1);
#nullable restore
#line 315 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 15406, k.Ime, 15406, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""ime_input"" onkeypress=""provjera('ime_input')"" onchange=""provjera('ime_input')"" onblur=""provjera('ime_input')"" /><span id=""ime_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Prezime</label>
                    </td>
                    <td>
                        <input type=""text"" name=""prezime""");
            BeginWriteAttribute("value", " value=\"", 15815, "\"", 15833, 1);
#nullable restore
#line 323 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 15823, k.Prezime, 15823, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""prezime_input"" onkeypress=""provjera('prezime_input')"" onchange=""provjera('prezime_input')"" onblur=""provjera('prezime_input')"" /><span id=""prezime_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Šifra</label>
                    </td>
                    <td>
                        <input type=""text"" name=""sifra""");
            BeginWriteAttribute("value", " value=\"", 16252, "\"", 16268, 1);
#nullable restore
#line 331 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 16260, k.Sifra, 16260, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""sifra_input"" onkeypress=""provjera('sifra_input')"" onchange=""provjera('sifra_input')"" onblur=""provjera('sifra_input')"" /><span id=""sifra_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Korisničko ime</label>
                    </td>
                    <td>
                        <input type=""text"" name=""korisnicko_ime""");
            BeginWriteAttribute("value", " value=\"", 16695, "\"", 16720, 1);
#nullable restore
#line 339 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 16703, k.Korisnicko_Ime, 16703, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""korisnickoIme_input"" onkeypress=""provjera('korisnickoIme_input')"" onchange=""provjera('korisnickoIme_input')"" onblur=""provjera('korisnickoIme_input')"" /><span id=""username_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Lozinka</label>
                    </td>
                    <td>
                        <input type=""text"" name=""lozinka""");
            BeginWriteAttribute("value", " value=\"", 17168, "\"", 17186, 1);
#nullable restore
#line 347 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 17176, k.Lozinka, 17176, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""lozinka_input"" onkeypress=""provjera('lozinka_input')"" onchange=""provjera('lozinka_input')"" onblur=""provjera('lozinka_input')"" /><span id=""pass_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Mail</label>
                    </td>
                    <td>
                        <input type=""text"" name=""mail""");
            BeginWriteAttribute("value", " value=\"", 17600, "\"", 17615, 1);
#nullable restore
#line 355 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 17608, k.Mail, 17608, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""mail_input"" onkeypress=""provjera('mail_input')"" onchange=""provjera('mail_input')"" onblur=""provjera('mail_input')"" /><span id=""mail_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Telefon</label>
                    </td>
                    <td>
                        <input type=""text"" name=""telefon""");
            BeginWriteAttribute("value", " value=\"", 18023, "\"", 18041, 1);
#nullable restore
#line 363 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 18031, k.Telefon, 18031, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""telefon_input"" onkeypress=""provjera('telefon_input')"" onchange=""provjera('telefon_input')"" onblur=""provjera('telefon_input')"" /><span id=""telefon_span""></span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Uloga</label>
                    </td>
                    <td>
                        <select name=""uloga"" id=""uloga_select"" onselect=""provjera('uloga_select')"" onchange=""provjera('uloga_select')"" onblur=""provjera('uloga_select')"">
                            <option");
            BeginWriteAttribute("value", " value=\"", 18611, "\"", 18630, 1);
#nullable restore
#line 372 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 18619, k.Uloge_FK, 18619, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 372 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                                                   Write(k.uloge.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 373 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                             foreach (var x in uloge)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 18782, "\"", 18801, 1);
#nullable restore
#line 375 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 18790, x.Uloge_ID, 18790, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 375 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                                                       Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 376 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                        <span id=""select_span""></span>
                    </td>
                </tr>
            </table>

            <button class=""btn btn-primary"" id=""snimi"">Snimi</button>


        </form>
    </center>
");
#nullable restore
#line 388 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
}

#line default
#line hidden
#nullable disable
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
