#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fe1f8fe3f243289be185716e2945d353af43457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrgJed_Views_ProjekatAktivnostRealizacija_Detalji), @"mvc.1.0.view", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostRealizacija/Detalji.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe1f8fe3f243289be185716e2945d353af43457", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostRealizacija/Detalji.cshtml")]
    public class Areas_AdminOrgJed_Views_ProjekatAktivnostRealizacija_Detalji : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.lista_realizacijaVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"

    List<ProjekatPlan> projekti = (List<ProjekatPlan>)ViewData["projekti"];

    List<WebApplication1.Models.VM.RealizacijaVM> lista_projekata = (List<WebApplication1.Models.VM.RealizacijaVM>)ViewData["lista_projekata"];

    RealizacijaDetaljiSuma suma = (RealizacijaDetaljiSuma)ViewData["suma"];

    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    #progressBar {
        border: 1px solid black;
        background-color: rgb(255, 62, 62);
        height: 25px;
        width: 100%;
    }
    #vrijednost {
        position: relative;
        background-color: rgb(5, 230, 0);
        height: 100%;
        display: block;
    }
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
        text-decoration-line: non");
            WriteLiteral(@"e;
    }

    #kutijaZaMeni {
        position: fixed;
        height: 100%;
        width: 17%;
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
            BeginWriteAttribute("href", " href=\"", 2483, "\"", 2567, 6);
            WriteAttributeValue("", 2490, "/AdminOrgJed/AdminOrgJed/Index?u=", 2490, 33, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 2523, id.userId, 2523, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2533, "&o=", 2533, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 2536, id.organisationId, 2536, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2554, "&r=", 2554, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 2557, id.roleId, 2557, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2725, "\"", 2811, 6);
            WriteAttributeValue("", 2732, "/AdminOrgJed/ProjekatPlan/Prikaz?u=", 2732, 35, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 2767, id.userId, 2767, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2777, "&o=", 2777, 3, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 2780, id.organisationId, 2780, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2798, "&r=", 2798, 3, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 2801, id.roleId, 2801, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2850, "\"", 2945, 6);
            WriteAttributeValue("", 2857, "/AdminOrgJed/ProjekatAktivnostPlan/Prikaz?u=", 2857, 44, true);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 2901, id.userId, 2901, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2911, "&o=", 2911, 3, true);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 2914, id.organisationId, 2914, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2932, "&r=", 2932, 3, true);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 2935, id.roleId, 2935, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3085, "\"", 3187, 6);
            WriteAttributeValue("", 3092, "/AdminOrgJed/ProjekatAktivnostRealizacija/Prikaz?u=", 3092, 51, true);
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3143, id.userId, 3143, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3153, "&o=", 3153, 3, true);
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3156, id.organisationId, 3156, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3174, "&r=", 3174, 3, true);
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3177, id.roleId, 3177, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3318, "\"", 3400, 6);
            WriteAttributeValue("", 3325, "/AdminOrgJed/Korisnik/Prikaz?u=", 3325, 31, true);
#nullable restore
#line 115 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3356, id.userId, 3356, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3366, "&o=", 3366, 3, true);
#nullable restore
#line 115 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3369, id.organisationId, 3369, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3387, "&r=", 3387, 3, true);
#nullable restore
#line 115 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3390, id.roleId, 3390, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Korisnici</a></li>
            </ul>
        </ul>
    </div>
</div>

<center>
    <div id=""zaglavlje"" style=""width:100%"">
        <h1 style=""position:relative; display:inline;"">Detalji realizacije</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3705, "\"", 3718, 1);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3711, imgsrc, 3711, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <br />\r\n    <br />\r\n\r\n    <form method=\"post\"");
            BeginWriteAttribute("action", " action=\"", 3785, "\"", 3890, 6);
            WriteAttributeValue("", 3794, "/AdminOrgJed/ProjekatAktivnostRealizacija/Detalji?u=", 3794, 52, true);
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3846, id.userId, 3846, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3856, "&o=", 3856, 3, true);
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3859, id.organisationId, 3859, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3877, "&r=", 3877, 3, true);
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 3880, id.roleId, 3880, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <table>\r\n            <tr>\r\n                <td><label>Projekat</label></td>\r\n                <td>\r\n                    <select name=\"projekatId\">\r\n                        <option>---Odaberi---</option>\r\n");
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                         foreach (var x in projekti)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4223, "\"", 4249, 1);
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 4231, x.ProjekatPlan_ID, 4231, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                          Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
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
            WriteLiteral("        </table>\r\n        <button type=\"submit\" class=\"btn btn-primary\" id=\"tragaj\" name=\"traziDugme\" value=\"10\">Traži</button>\r\n    </form>\r\n");
#nullable restore
#line 159 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
     if (Model.liste != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
         if (Model.liste.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <center>
                <div id=""podaci"">
                    <br /><br />
                    <h3>Rezultati projekata</h3>
                    <div id=""dugmad"">
                        <div id=""print_excel"" style=""display:inline;"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 5382, "\"", 5556, 12);
            WriteAttributeValue("", 5389, "/AdminOrgJed/ProjekatAktivnostRealizacija/Excel2?uloga=", 5389, 55, true);
#nullable restore
#line 169 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 5444, id.roleId, 5444, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5454, "&u=", 5454, 3, true);
#nullable restore
#line 169 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 5457, id.userId, 5457, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5467, "&organizacijaId=", 5467, 16, true);
#nullable restore
#line 169 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 5483, id.organisationId, 5483, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5501, "&projekatId=", 5501, 12, true);
#nullable restore
#line 169 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 5513, Model.projekatId, 5513, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5530, "&OD=", 5530, 4, true);
#nullable restore
#line 169 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 5534, Model.Od, 5534, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5543, "&DO=", 5543, 4, true);
#nullable restore
#line 169 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 5547, Model.Do, 5547, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">Export to Excel</a>
                        </div>
                        <li style="" margin:3%; position:relative; display:inline;""><a class=""btn"" id=""fb"" style=""color:white; background-color:cornflowerblue;"">Share on Facebook</a></li>
                        <script>
                            $(""#fb"").click(function () {
                                document.getElementById(""fb"").href = ""http://www.facebook.com/sharer.php?u="" + ""https://localhost:44343/Report/Index?uloga=");
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                                                                      Write(id.roleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&organizacijaId=");
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                                                                                                Write(Model.organizacijaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&projekatId=");
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                                                                                                                                 Write(Model.projekatId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&OD=");
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                                                                                                                                                      Write(Model.Od);

#line default
#line hidden
#nullable disable
            WriteLiteral("&DO=");
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                                                                                                                                                                   Write(Model.Do);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                            });\r\n                        </script>\r\n                    </div>\r\n");
#nullable restore
#line 178 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                     if (suma != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table"">
                            <tr>
                                <hr />
                                <td style=""font-weight:bold;"">Projekat</td>
                                <td style=""font-weight:bold;"">Organizaciona jedinica</td>
                                <td style=""font-weight:bold;"">Planirano</td>
                                <td style=""font-weight:bold;"">Ostvareno</td>
                                <td style=""font-weight:bold;"">Procentualno</td>
                                <td style=""font-weight:bold;"">Grafički</td>
                            </tr>
                            <tr>
                                <hr />
                                <td>");
#nullable restore
#line 192 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                               Write(suma.naziv_projekta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 193 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                               Write(suma.organizacionaJedinica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 194 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                               Write(suma.planirano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 195 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                               Write(suma.ostvareno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 196 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                Write(Math.Round(suma.procenti) + "%");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div id=\"progressBar\" style=\"width:100%;\">\r\n                                        <div");
            BeginWriteAttribute("style", " style=\"", 7532, "\"", 7576, 3);
            WriteAttributeValue("", 7540, "width:", 7540, 6, true);
#nullable restore
#line 199 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 7546, Math.Round(suma.procenti), 7546, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7574, "%;", 7574, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"vrijednost\"></div>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n                        </table>\r\n");
#nullable restore
#line 204 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
#line 218 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                             foreach (var x in Model.liste)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 221 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(x.nazivProjekta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 222 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(x.naziv_aktivnosti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 223 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                    Write(x.datum.Day + "." + x.datum.Month + "." + x.datum.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 224 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(x.planirano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 225 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                   Write(x.odradjeno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 226 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                    Write(Math.Round((x.odradjeno / x.planirano) * 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                    <td>\r\n                                        <div id=\"progressBar\" style=\"width:100%;\">\r\n                                            <div");
            BeginWriteAttribute("style", " style=\"", 9053, "\"", 9117, 3);
            WriteAttributeValue("", 9061, "width:", 9061, 6, true);
#nullable restore
#line 229 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 9067, Math.Round((x.odradjeno / x.planirano) * 100), 9067, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9115, "%;", 9115, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"vrijednost\"></div>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-warning\"");
            BeginWriteAttribute("id", " id=\"", 9342, "\"", 9370, 2);
            WriteAttributeValue("", 9347, "Detalji__", 9347, 9, true);
#nullable restore
#line 233 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
WriteAttributeValue("", 9356, x.aktivnostId, 9356, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalji</a>\r\n                                        <script>\r\n                                        $(\"#Detalji__");
#nullable restore
#line 235 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                Write(x.aktivnostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function (event) {\r\n                                            $.get(\"/AdminOrgJed/Ajax/DetaljiRealizacija?idAktivnost=");
#nullable restore
#line 236 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                               Write(x.aktivnostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&idProjekat=");
#nullable restore
#line 236 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                                         Write(x.projekatId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&idRealizacija=");
#nullable restore
#line 236 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                                                                                                                                                     Write(x.realizacijaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&korisnikId=");
#nullable restore
#line 236 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
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
#line 246 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </center>\r\n");
#nullable restore
#line 253 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 253 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Detalji.cshtml"
         
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