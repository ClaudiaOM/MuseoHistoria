#pragma checksum "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7280c7085465b209785b4b10e39b65fa7328e3c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_All), @"mvc.1.0.view", @"/Views/Event/All.cshtml")]
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
#line 1 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\_ViewImports.cshtml"
using Museo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\_ViewImports.cshtml"
using Museo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\_ViewImports.cshtml"
using Museo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7280c7085465b209785b4b10e39b65fa7328e3c2", @"/Views/Event/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c9bb0757771c05052f5070f7d77679ef6787767", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("toolbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Breadcrumb", async() => {
                WriteLiteral("\r\n    <li class=\"breadcrumb-item active\">Eventos</li>\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
  
    ViewData["Title"] = "Eventos";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card bg-light\">\r\n    <div class=\"card-header d-flex\">\r\n        <h4 class=\"mb-0\">Eventos</h4>\r\n        <div class=\"dropdown ml-auto\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7280c7085465b209785b4b10e39b65fa7328e3c25805", async() => {
                WriteLiteral(" <i class=\"fa fa-angle-double-right\"></i> Insertar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 22 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
          
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xl-8 col-lg-12 col-md-12 col-sm-12 col-12 mb-5\">\r\n                    <div class=\"section-block\">\r\n                        <h3 class=\"section-title\">");
#nullable restore
#line 27 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                             Write(item.EventName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"tab-regular\">\r\n                        <ul class=\"nav nav-tabs nav-fill\"");
            BeginWriteAttribute("id", " id=\"", 934, "\"", 951, 2);
            WriteAttributeValue("", 939, "myTab_", 939, 6, true);
#nullable restore
#line 30 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 945, count, 945, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tablist\">\r\n                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link active\"");
            BeginWriteAttribute("id", " id=\"", 1079, "\"", 1107, 2);
            WriteAttributeValue("", 1084, "home-tab-justify_", 1084, 17, true);
#nullable restore
#line 32 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1101, count, 1101, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"");
            BeginWriteAttribute("href", " href=\"", 1126, "\"", 1153, 2);
            WriteAttributeValue("", 1133, "#home-justify_", 1133, 14, true);
#nullable restore
#line 32 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1147, count, 1147, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1165, "\"", 1192, 2);
            WriteAttributeValue("", 1181, "home_", 1181, 5, true);
#nullable restore
#line 32 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1186, count, 1186, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-selected=\"true\">Descripción</a>\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link\"");
            BeginWriteAttribute("id", " id=\"", 1369, "\"", 1400, 2);
            WriteAttributeValue("", 1374, "profile-tab-justify_", 1374, 20, true);
#nullable restore
#line 35 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1394, count, 1394, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"");
            BeginWriteAttribute("href", " href=\"", 1419, "\"", 1449, 2);
            WriteAttributeValue("", 1426, "#profile-justify_", 1426, 17, true);
#nullable restore
#line 35 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1443, count, 1443, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1461, "\"", 1491, 2);
            WriteAttributeValue("", 1477, "profile_", 1477, 8, true);
#nullable restore
#line 35 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1485, count, 1485, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-selected=\"false\">Asistentes</a>\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link\"");
            BeginWriteAttribute("id", " id=\"", 1668, "\"", 1699, 2);
            WriteAttributeValue("", 1673, "contact-tab-justify_", 1673, 20, true);
#nullable restore
#line 38 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1693, count, 1693, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"");
            BeginWriteAttribute("href", " href=\"", 1718, "\"", 1748, 2);
            WriteAttributeValue("", 1725, "#contact-justify_", 1725, 17, true);
#nullable restore
#line 38 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1742, count, 1742, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1760, "\"", 1790, 2);
            WriteAttributeValue("", 1776, "contact_", 1776, 8, true);
#nullable restore
#line 38 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1784, count, 1784, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-selected=\"false\">Tema</a>\r\n                            </li>\r\n                        </ul>\r\n                        <div class=\"tab-content\"");
            BeginWriteAttribute("id", " id=\"", 1938, "\"", 1962, 2);
            WriteAttributeValue("", 1943, "myTabContent_", 1943, 13, true);
#nullable restore
#line 41 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 1956, count, 1956, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"tab-pane fade show active\"");
            BeginWriteAttribute("id", " id=\"", 2032, "\"", 2056, 2);
            WriteAttributeValue("", 2037, "home-justify_", 2037, 13, true);
#nullable restore
#line 42 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 2050, count, 2050, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2073, "\"", 2114, 2);
            WriteAttributeValue("", 2091, "home-tab-justify_", 2091, 17, true);
#nullable restore
#line 42 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 2108, count, 2108, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p class=\"lead\">");
#nullable restore
#line 43 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                           Write(item.EventDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Fecha: ");
#nullable restore
#line 44 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                     Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Lugar: ");
#nullable restore
#line 45 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                     Write(item.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"tab-pane fade\"");
            BeginWriteAttribute("id", " id=\"", 2401, "\"", 2428, 2);
            WriteAttributeValue("", 2406, "profile-justify_", 2406, 16, true);
#nullable restore
#line 47 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 2422, count, 2422, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2445, "\"", 2489, 2);
            WriteAttributeValue("", 2463, "profile-tab-justify_", 2463, 20, true);
#nullable restore
#line 47 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 2483, count, 2483, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p><span class=\"lead\">Total de Participantes:</span>  ");
#nullable restore
#line 48 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                                                                 Write(item.TotalParticipant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"lead\">Organizadores:</p>\r\n                                <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 51 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                      
                                        foreach (var o in item.Organizers)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><span class=\"badge-dot badge-primary\"></span> ");
#nullable restore
#line 54 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                                                                         Write(o.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 55 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                                <p class=\"lead\">Personalidades:</p>\r\n                                <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 60 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                      
                                        foreach (var p in item.Personalities)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><span class=\"badge-dot badge-primary\"></span> ");
#nullable restore
#line 63 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                                                                         Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 64 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </div>\r\n                            <div class=\"tab-pane fade\"");
            BeginWriteAttribute("id", " id=\"", 3733, "\"", 3760, 2);
            WriteAttributeValue("", 3738, "contact-justify_", 3738, 16, true);
#nullable restore
#line 68 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 3754, count, 3754, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3777, "\"", 3821, 2);
            WriteAttributeValue("", 3795, "contact-tab-justify_", 3795, 20, true);
#nullable restore
#line 68 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
WriteAttributeValue("", 3815, count, 3815, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p class=\"lead\">Tema: ");
#nullable restore
#line 69 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                                 Write(item.EventThmatic.Thematic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>");
#nullable restore
#line 70 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                              Write(item.EventThmatic.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"lead\">Tipo: ");
#nullable restore
#line 71 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                                                 Write(item.EventType.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>");
#nullable restore
#line 72 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                              Write(item.EventType.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 77 "C:\Users\Claudia's PC\Documents\GitHub\MuseoHistoria\Museo\Views\Event\All.cshtml"
                count = count + 1;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"card-footer\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7280c7085465b209785b4b10e39b65fa7328e3c222389", async() => {
                WriteLiteral(" <i class=\"fa fa-angle-double-right\"></i> Insertar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
