#pragma checksum "C:\Users\David\source\repos\AlbumApp\AlbumApp\Views\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c01b801385f66ae911dff3b61b0ea4630f4aaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comments), @"mvc.1.0.view", @"/Views/Comments.cshtml")]
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
#line 1 "C:\Users\David\source\repos\AlbumApp\AlbumApp\Views\_ViewImports.cshtml"
using AlbumApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\David\source\repos\AlbumApp\AlbumApp\Views\_ViewImports.cshtml"
using AlbumApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0c01b801385f66ae911dff3b61b0ea4630f4aaa", @"/Views/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc107135481e24d979788c3894ed8759a011021", @"/Views/_ViewImports.cshtml")]
    public class Views_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Comments</h1>\r\n");
#nullable restore
#line 2 "C:\Users\David\source\repos\AlbumApp\AlbumApp\Views\Comments.cshtml"
 foreach (var item in ViewBag.comments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>");
#nullable restore
#line 4 "C:\Users\David\source\repos\AlbumApp\AlbumApp\Views\Comments.cshtml"
     Write(item.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 5 "C:\Users\David\source\repos\AlbumApp\AlbumApp\Views\Comments.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591