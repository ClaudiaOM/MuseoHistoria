#pragma checksum "C:\Users\Adrian\Desktop\Programas C#\MuseoHistoria\Museo\Views\Area\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b76e15a9a0eb1512505f5d9e04afe9ed708d626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Area_All), @"mvc.1.0.view", @"/Views/Area/All.cshtml")]
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
#line 1 "C:\Users\Adrian\Desktop\Programas C#\MuseoHistoria\Museo\Views\_ViewImports.cshtml"
using Museo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adrian\Desktop\Programas C#\MuseoHistoria\Museo\Views\_ViewImports.cshtml"
using Museo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adrian\Desktop\Programas C#\MuseoHistoria\Museo\Views\_ViewImports.cshtml"
using Museo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adrian\Desktop\Programas C#\MuseoHistoria\Museo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b76e15a9a0eb1512505f5d9e04afe9ed708d626", @"/Views/Area/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c9bb0757771c05052f5070f7d77679ef6787767", @"/Views/_ViewImports.cshtml")]
    public class Views_Area_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Area>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <div class=""table-responsive"">
        <table class=""table-bordered"">
            <thead class=""table-primary"">
                <tr>
                    <td>Nombre</td>
                    <td>Siglas</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 13 "C:\Users\Adrian\Desktop\Programas C#\MuseoHistoria\Museo\Views\Area\All.cshtml"
                 foreach (var area in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"d-table-row\">\r\n                        <td class=\"d-table-cell\">");
#nullable restore
#line 16 "C:\Users\Adrian\Desktop\Programas C#\MuseoHistoria\Museo\Views\Area\All.cshtml"
                                            Write(area.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"d-table-cell\">");
#nullable restore
#line 17 "C:\Users\Adrian\Desktop\Programas C#\MuseoHistoria\Museo\Views\Area\All.cshtml"
                                            Write(area.Acronym);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Adrian\Desktop\Programas C#\MuseoHistoria\Museo\Views\Area\All.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Area>> Html { get; private set; }
    }
}
#pragma warning restore 1591