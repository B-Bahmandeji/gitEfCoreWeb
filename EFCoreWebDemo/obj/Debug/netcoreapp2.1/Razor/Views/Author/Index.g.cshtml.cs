#pragma checksum "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7bdfa9249558344fb878f6cac731ec82a18e9d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/Index.cshtml", typeof(AspNetCore.Views_Author_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bdfa9249558344fb878f6cac731ec82a18e9d9", @"/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e3cb575225e75b359599a007749e2d400f4bd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Author\Index.cshtml"
   
    ViewBag.Title = "Authors";

#line default
#line hidden
            BeginContext(68, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(75, 13, false);
#line 6 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Author\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(88, 13, true);
            WriteLiteral("</h1>\r\n<ul>\r\n");
            EndContext();
#line 8 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Author\Index.cshtml"
     foreach(var author in Model)
    {

#line default
#line hidden
            BeginContext(143, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(156, 16, false);
#line 10 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Author\Index.cshtml"
       Write(author.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(172, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(174, 15, false);
#line 10 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Author\Index.cshtml"
                         Write(author.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(189, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Author\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(203, 12, true);
            WriteLiteral("</ul>\r\n<div>");
            EndContext();
            BeginContext(216, 32, false);
#line 13 "C:\PROJECTS\CoreProjects\EFCoreWebDemo\EFCoreWebDemo\Views\Author\Index.cshtml"
Write(Html.ActionLink("New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(248, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
