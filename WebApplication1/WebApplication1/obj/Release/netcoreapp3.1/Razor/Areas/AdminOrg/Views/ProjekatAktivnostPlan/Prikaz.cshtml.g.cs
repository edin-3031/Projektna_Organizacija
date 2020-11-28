#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb48885a24335b41f59875366062800dfb2dc5d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_ProjekatAktivnostPlan_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb48885a24335b41f59875366062800dfb2dc5d2", @"/Areas/AdminOrg/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatAktivnostPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
  
    List<ProjekatAktivnostPlan> lista = (List<ProjekatAktivnostPlan>)ViewData["pro_aktiv_plan"];

    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>


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
        width: 17%;
        /*            background-color:green;*/
        display: block;
        margin-left: -17.8%;
    }

    #menu {
        position: fixed;
        /*height: 65%;*/
        width");
            WriteLiteral(@": 15%;
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
            BeginWriteAttribute("href", " href=\"", 1921, "\"", 1999, 6);
            WriteAttributeValue("", 1928, "/AdminOrg/AdminOrg/Index?u=", 1928, 27, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1955, id.userId, 1955, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1965, "&o=", 1965, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1968, id.organisationId, 1968, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1986, "&r=", 1986, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1989, id.roleId, 1989, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2155, "\"", 2247, 6);
            WriteAttributeValue("", 2162, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2162, 41, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2203, id.userId, 2203, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2213, "&o=", 2213, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2216, id.organisationId, 2216, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2234, "&r=", 2234, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2237, id.roleId, 2237, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2304, "\"", 2386, 6);
            WriteAttributeValue("", 2311, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2311, 31, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2342, id.userId, 2342, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2352, "&o=", 2352, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2355, id.organisationId, 2355, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2373, "&r=", 2373, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2376, id.roleId, 2376, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2549, "\"", 2632, 6);
            WriteAttributeValue("", 2556, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2556, 32, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2588, id.userId, 2588, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2598, "&o=", 2598, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2601, id.organisationId, 2601, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2619, "&r=", 2619, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2622, id.roleId, 2622, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2671, "\"", 2763, 6);
            WriteAttributeValue("", 2678, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2678, 41, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2719, id.userId, 2719, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2729, "&o=", 2729, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2732, id.organisationId, 2732, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2750, "&r=", 2750, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2753, id.roleId, 2753, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2903, "\"", 3002, 6);
            WriteAttributeValue("", 2910, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 2910, 48, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2958, id.userId, 2958, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2968, "&o=", 2968, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2971, id.organisationId, 2971, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2989, "&r=", 2989, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2992, id.roleId, 2992, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3133, "\"", 3212, 6);
            WriteAttributeValue("", 3140, "/AdminOrg/Korisnik/Prikaz?u=", 3140, 28, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3168, id.userId, 3168, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3178, "&o=", 3178, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3181, id.organisationId, 3181, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3199, "&r=", 3199, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3202, id.roleId, 3202, 10, false);

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
        <h1 style=""position:relative; display:inline;"">Prikaz Projektnih aktivnosti</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3524, "\"", 3537, 1);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3530, imgsrc, 3530, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3642, "\"", 3732, 6);
            WriteAttributeValue("", 3649, "/AdminOrg/ProjekatAktivnostPlan/Unos?u=", 3649, 39, true);
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3688, id.userId, 3688, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3698, "&o=", 3698, 3, true);
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3701, id.organisationId, 3701, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3719, "&r=", 3719, 3, true);
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3722, id.roleId, 3722, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Dodaj novi</a>\r\n        </div>\r\n        <div id=\"print_excel\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3812, "\"", 3870, 2);
            WriteAttributeValue("", 3819, "/Report/IndexAdminOrgAktivnost?o=", 3819, 33, true);
#nullable restore
#line 116 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3852, id.organisationId, 3852, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">Export to Excel</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>Projekat plan</th>
        <th>Šifra</th>
        <th>Naziv</th>
        <th>Datum od</th>
        <th>Datum do</th>
        <th>Jedinica mjere</th>
        <th>Količina</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 131 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 134 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.projekatPlan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 136 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumOd.Date.Day+"."+ x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumDo.Date.Day+"."+ x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.JedinicaMjere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4837, "\"", 4959, 8);
            WriteAttributeValue("", 4844, "/AdminOrg/ProjekatAktivnostPlan/Uredi?id=", 4844, 41, true);
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 4885, x.ProjekatAktivnostPlan_ID, 4885, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4912, "&u=", 4912, 3, true);
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 4915, id.userId, 4915, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4925, "&o=", 4925, 3, true);
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 4928, id.organisationId, 4928, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4946, "&r=", 4946, 3, true);
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 4949, id.roleId, 4949, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                        <a");
            BeginWriteAttribute("id", " id=\"", 4998, "\"", 5037, 2);
            WriteAttributeValue("", 5003, "ukloni_", 5003, 7, true);
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5010, x.ProjekatAktivnostPlan_ID, 5010, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                        <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 5192, "\"", 5231, 2);
            WriteAttributeValue("", 5197, "poruka_", 5197, 7, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5204, x.ProjekatAktivnostPlan_ID, 5204, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 5244, "\"", 5367, 8);
            WriteAttributeValue("", 5251, "/AdminOrg/ProjekatAktivnostPlan/Ukloni?id=", 5251, 42, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5293, x.ProjekatAktivnostPlan_ID, 5293, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5320, "&u=", 5320, 3, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5323, id.userId, 5323, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5333, "&o=", 5333, 3, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5336, id.organisationId, 5336, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5354, "&r=", 5354, 3, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5357, id.roleId, 5357, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 5417, "\"", 5452, 2);
            WriteAttributeValue("", 5422, "no_", 5422, 3, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5425, x.ProjekatAktivnostPlan_ID, 5425, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                        <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 151 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 154 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                              Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 155 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                        </script>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 160 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</center>");
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
