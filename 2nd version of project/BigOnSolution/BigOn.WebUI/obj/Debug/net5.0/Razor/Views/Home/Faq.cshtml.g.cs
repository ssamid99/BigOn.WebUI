#pragma checksum "D:\BigOnSolution\BigOn.WebUI\Views\Home\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae17af28e1dc067cdf5712d725d25d4dcc344cbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Faq), @"mvc.1.0.view", @"/Views/Home/Faq.cshtml")]
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
#line 2 "D:\BigOnSolution\BigOn.WebUI\Views\_ViewImports.cshtml"
using BigOn.WebUI.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae17af28e1dc067cdf5712d725d25d4dcc344cbd", @"/Views/Home/Faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a3084ce915cd477cf718ee015b600967215deb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Faq>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\BigOnSolution\BigOn.WebUI\Views\Home\Faq.cshtml"
  
    ViewData["Title"] = "Faq";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Breadcrumb Start -->
<div class=""breadcrumb-area ptb-50"">
    <div class=""container"">
        <div class=""breadcrumb"">
            <ul>
                <li><a href=""index.html"">Home</a></li>
                <li class=""active""><a href=""contact.html"">Faqs</a></li>
            </ul>
        </div>
    </div>
    <!-- Container End -->
</div>
<!-- Breadcrumb End -->

<div class=""container"">
    <div class=""row"">
        <div class=""accordion"" id=""accordionExample"">
");
#nullable restore
#line 24 "D:\BigOnSolution\BigOn.WebUI\Views\Home\Faq.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"accordion-item\">\r\n                    <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                        <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree-");
#nullable restore
#line 28 "D:\BigOnSolution\BigOn.WebUI\Views\Home\Faq.cshtml"
                                                                                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\" aria-controls=\"collapseThree\">\r\n                            ");
#nullable restore
#line 29 "D:\BigOnSolution\BigOn.WebUI\Views\Home\Faq.cshtml"
                       Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                    </h2>\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 1060, "\"", 1087, 2);
            WriteAttributeValue("", 1065, "collapseThree-", 1065, 14, true);
#nullable restore
#line 32 "D:\BigOnSolution\BigOn.WebUI\Views\Home\Faq.cshtml"
WriteAttributeValue("", 1079, item.Id, 1079, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse\" aria-labelledby=\"headingThree\" data-bs-parent=\"#accordionExample\">\r\n                        <div class=\"accordion-body\">\r\n                            ");
#nullable restore
#line 34 "D:\BigOnSolution\BigOn.WebUI\Views\Home\Faq.cshtml"
                       Write(Html.Raw(@item.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 39 "D:\BigOnSolution\BigOn.WebUI\Views\Home\Faq.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<br/>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Faq>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
