#pragma checksum "C:\Users\dldygnl\Desktop\@ENTPROG\Negociantes\Views\Post\AnyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcee0a40d2c3bd150799c8685bf10ee01c045bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_AnyAccount), @"mvc.1.0.view", @"/Views/Post/AnyAccount.cshtml")]
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
#line 1 "C:\Users\dldygnl\Desktop\@ENTPROG\Negociantes\Views\_ViewImports.cshtml"
using Negociantes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dldygnl\Desktop\@ENTPROG\Negociantes\Views\_ViewImports.cshtml"
using Negociantes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcee0a40d2c3bd150799c8685bf10ee01c045bd3", @"/Views/Post/AnyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5b0a978edd30a5c255f6ffeafaff7fc7557b98", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_AnyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Negociantes.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dldygnl\Desktop\@ENTPROG\Negociantes\Views\Post\AnyAccount.cshtml"
  
    ViewData["Title"] = "AnyAccount";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AnyAccount</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\dldygnl\Desktop\@ENTPROG\Negociantes\Views\Post\AnyAccount.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\dldygnl\Desktop\@ENTPROG\Negociantes\Views\Post\AnyAccount.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "C:\Users\dldygnl\Desktop\@ENTPROG\Negociantes\Views\Post\AnyAccount.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\dldygnl\Desktop\@ENTPROG\Negociantes\Views\Post\AnyAccount.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Negociantes.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
