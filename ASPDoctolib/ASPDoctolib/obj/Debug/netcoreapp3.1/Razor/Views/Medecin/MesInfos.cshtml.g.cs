#pragma checksum "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\MesInfos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca2778295b2dd669b347b953defbf5fd2ac866b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medecin_MesInfos), @"mvc.1.0.view", @"/Views/Medecin/MesInfos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca2778295b2dd669b347b953defbf5fd2ac866b", @"/Views/Medecin/MesInfos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e34a3bcba01e340b3960ee3d328d0a7686bc73a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Medecin_MesInfos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Bien venue sur votre compte ");
#nullable restore
#line 6 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Medecin\MesInfos.cshtml"
                           Write(ViewBag.Medecin.Nom_Medecin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
