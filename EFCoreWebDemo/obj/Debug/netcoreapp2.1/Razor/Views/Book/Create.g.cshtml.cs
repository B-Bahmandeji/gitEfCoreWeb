#pragma checksum "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Book\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2eb046b1231e8d2c762ae5fcbcb10c5e2a55f31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Create), @"mvc.1.0.view", @"/Views/Book/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Create.cshtml", typeof(AspNetCore.Views_Book_Create))]
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
#line 1 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\_ViewImports.cshtml"
using EFCoreWebDemo;

#line default
#line hidden
#line 2 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\_ViewImports.cshtml"
using EFCoreWebDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2eb046b1231e8d2c762ae5fcbcb10c5e2a55f31", @"/Views/Book/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e3cb575225e75b359599a007749e2d400f4bd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Book\Create.cshtml"
   
    ViewBag.Title = "New Book";

#line default
#line hidden
            BeginContext(54, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(59, 13, false);
#line 5 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Book\Create.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(72, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 6 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Book\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(109, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(148, 36, false);
#line 9 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Book\Create.cshtml"
   Write(Html.LabelFor(model=>model.AuthorId));

#line default
#line hidden
            EndContext();
            BeginContext(184, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(195, 133, false);
#line 10 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Book\Create.cshtml"
   Write(Html.DropDownListFor(model=>model.AuthorId, (IEnumerable<SelectListItem>)ViewBag.Authors, string.Empty, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(328, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(381, 35, false);
#line 13 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Book\Create.cshtml"
   Write(Html.LabelFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(416, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(427, 70, false);
#line 14 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Book\Create.cshtml"
   Write(Html.TextBoxFor(model => model.Title, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(497, 81, true);
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n");
            EndContext();
#line 17 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Book\Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
