#pragma checksum "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Patient\InscriptionPatient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847fb0ef4f08b7743a425bc4b2ebcf81ac09766a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_InscriptionPatient), @"mvc.1.0.view", @"/Views/Patient/InscriptionPatient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847fb0ef4f08b7743a425bc4b2ebcf81ac09766a", @"/Views/Patient/InscriptionPatient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e34a3bcba01e340b3960ee3d328d0a7686bc73a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_InscriptionPatient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitFormPatient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847fb0ef4f08b7743a425bc4b2ebcf81ac09766a4505", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Patient\InscriptionPatient.cshtml"
     if (ViewBag.MessageError != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row m-1\">\r\n            <div class=\"alert-danger col p-1\">\r\n                ");
#nullable restore
#line 11 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Patient\InscriptionPatient.cshtml"
           Write(ViewBag.MessageError);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 14 "D:\formationZ\Projets_c#\ASPDoctolib\ASPDoctolib\Views\Patient\InscriptionPatient.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""inputEmail4"">Email</label>
            <input type=""email"" class=""form-control"" name=""inputEmail4"" id=""inputEmail4"" placeholder=""Email"">
        </div>
        <div class=""form-group col-md-6"">
            <label for=""inputPassword4"">Mot de passe</label>
            <input type=""password"" class=""form-control"" name=""inputPassword4"" id=""inputPassword4"" placeholder=""Password"">
        </div>
    </div>
    <fieldset class=""form-group"">
        <div class=""form-group col-md-6"">
            <label for=""inputName"">Nom</label>
            <input type=""text"" class=""form-control"" name=""inputName"" id=""inputName"" placeholder=""Nom..."">
        </div>
        <div class=""row"">
            <legend class=""col-form-label col-sm-2 pt-0"">Sexe</legend>
            <div class=""col-sm-10"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""gridRadios1"" id=""gri");
                WriteLiteral(@"dRadios1"" value=""homme"" checked>
                    <label class=""form-check-label"" for=""gridRadios1"">
                        Homme
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""gridRadios2"" id=""gridRadios2"" value=""femme"">
                    <label class=""form-check-label"" for=""gridRadios2"">
                        Femme
                    </label>
                </div>
            </div>
        </div>
    </fieldset>
    <div class=""form-group"">
        <label for=""inputAddress"">Address</label>
        <input type=""text"" class=""form-control"" name=""inputAddress"" id=""inputAddress"" placeholder=""10 rue du..."">
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""inputTel"">T??l??phone Portable</label>
            <input type=""text"" class=""form-control"" name=""inputTel"" id=""inputTel"">
        </div>
        <div class=""inp");
                WriteLiteral(@"ut-group date"" data-provide=""datepicker"">
            <label for=""start"">Date de Naissance :</label>

            <input type=""date"" id=""start"" name=""dateNaissance""
                   value=""2018-07-22""
                   min=""1950-01-01"" max=""2022-12-31"">
        </div>

    </div>

    <button class=""btn btn-primary"">S'inscrire</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
