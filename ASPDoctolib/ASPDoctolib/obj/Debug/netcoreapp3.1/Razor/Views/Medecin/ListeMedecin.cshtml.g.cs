#pragma checksum "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\ListeMedecin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5852953350408ab9133afc06c4dc71b4374d844e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medecin_ListeMedecin), @"mvc.1.0.view", @"/Views/Medecin/ListeMedecin.cshtml")]
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
#line 1 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\_ViewImports.cshtml"
using ASPDoctolib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\_ViewImports.cshtml"
using ASPDoctolib.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5852953350408ab9133afc06c4dc71b4374d844e", @"/Views/Medecin/ListeMedecin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e34a3bcba01e340b3960ee3d328d0a7686bc73a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Medecin_ListeMedecin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Medecin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\ListeMedecin.cshtml"
  
    ViewData["Title"] = "Liste des médecins";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

 
    

<h1>Liste des Medecins</h1>
<div class=""row"">
    <div class=""col"">
        Code Médecin
    </div>
    <div class=""col"">
        Nom du Médecin
    </div>
    <div class=""col"">
        Tel du Médecin
    </div>
    <div class=""col"">
        Specialite Médecin
    </div>
   
</div>

");
#nullable restore
#line 27 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\ListeMedecin.cshtml"
 foreach (Medecin m in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 31 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\ListeMedecin.cshtml"
       Write(m.Code_Medecin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 34 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\ListeMedecin.cshtml"
       Write(m.Nom_Medecin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 37 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\ListeMedecin.cshtml"
       Write(m.Tel_Medecin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 40 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\ListeMedecin.cshtml"
       Write(m.SpecialiteMedecin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        \r\n    </div>\r\n");
#nullable restore
#line 44 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\ListeMedecin.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Medecin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
