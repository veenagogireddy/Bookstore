#pragma checksum "\\business.colostate.edu\students\file\veenag\Downloads\ASP\ASP\ANVBookstore\Views\MAIN\CourseView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26241738a8ef1c4afe6675ea381fa24b37e70438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MAIN_CourseView), @"mvc.1.0.view", @"/Views/MAIN/CourseView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MAIN/CourseView.cshtml", typeof(AspNetCore.Views_MAIN_CourseView))]
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
#line 1 "\\business.colostate.edu\students\file\veenag\Downloads\ASP\ASP\ANVBookstore\Views\_ViewImports.cshtml"
using ANVBookstore;

#line default
#line hidden
#line 2 "\\business.colostate.edu\students\file\veenag\Downloads\ASP\ASP\ANVBookstore\Views\_ViewImports.cshtml"
using ANVBookstore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26241738a8ef1c4afe6675ea381fa24b37e70438", @"/Views/MAIN/CourseView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b5ba13ef8db57a55407d31393c2f3a084a7cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_MAIN_CourseView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Textbook>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "\\business.colostate.edu\students\file\veenag\Downloads\ASP\ASP\ANVBookstore\Views\MAIN\CourseView.cshtml"
  
    ViewData["Title"] = "CourseView";

#line default
#line hidden
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "\\business.colostate.edu\students\file\veenag\Downloads\ASP\ASP\ANVBookstore\Views\MAIN\CourseView.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
            BeginContext(230, 117, true);
            WriteLiteral("    <div class=\"card border-primary m-1 p-1\">\r\n        <div class=\"bg-light p-1\">\r\n            <h4>\r\n                ");
            EndContext();
            BeginContext(348, 6, false);
#line 14 "\\business.colostate.edu\students\file\veenag\Downloads\ASP\ASP\ANVBookstore\Views\MAIN\CourseView.cshtml"
           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(354, 161, true);
            WriteLiteral("\r\n                <span style=\"float:right\">\r\n\r\n                </span>\r\n            </h4>\r\n\r\n\r\n        </div>\r\n        <div class=\"card-text p-1\">\r\n            ");
            EndContext();
            BeginContext(516, 8, false);
#line 23 "\\business.colostate.edu\students\file\veenag\Downloads\ASP\ASP\ANVBookstore\Views\MAIN\CourseView.cshtml"
       Write(p.Author);

#line default
#line hidden
            EndContext();
            BeginContext(524, 97, true);
            WriteLiteral("\r\n            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                ");
            EndContext();
            BeginContext(622, 21, false);
#line 25 "\\business.colostate.edu\students\file\veenag\Downloads\ASP\ASP\ANVBookstore\Views\MAIN\CourseView.cshtml"
           Write(p.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(643, 57, true);
            WriteLiteral("\r\n\r\n            </span>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
#line 32 "\\business.colostate.edu\students\file\veenag\Downloads\ASP\ASP\ANVBookstore\Views\MAIN\CourseView.cshtml"
}

#line default
#line hidden
            BeginContext(703, 1505, true);
            WriteLiteral(@"

    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Sustainable Eco-Friendly Merchandise!</h5>
                        <p class=""card-text"">Support the Earth-Day Movement at the Bookstore</p>
                        <a href=""#"" class=""btn btn-primary"">Check It Out!</a>
                    </div>
                </div>
            </div>
            <br>
            <div class=""col-sm-4"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">$10 off on textbooks Editions 1 Year Old</h5>
                        <p class=""card-text"">Support the Earth-Day Movement at the Bookstore</p>
                        <a href=""#"" class=""btn btn-primary"">Check It Out!</a>
                    </div>
                </div>

            </div>
            <br>
         ");
            WriteLiteral(@"   <div class=""col-sm-4"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Special ART  Kits ,$10 off on textbooks.</h5>
                        <p class=""card-text"">Support the Earth-Day Movement at the Bookstore</p>
                        <a href=""#"" class=""btn btn-primary"">Check It Out!</a>
                    </div>
                </div>
            </div>


        </div>
    </div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Textbook>> Html { get; private set; }
    }
}
#pragma warning restore 1591
