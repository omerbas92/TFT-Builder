#pragma checksum "C:\Users\Omer\Desktop\tftWEB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2636d6c7b1938aa8a89726fe64007622a90a37f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Omer\Desktop\tftWEB\Views\_ViewImports.cshtml"
using tftWEB;

#line default
#line hidden
#line 2 "C:\Users\Omer\Desktop\tftWEB\Views\_ViewImports.cshtml"
using tftWEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2636d6c7b1938aa8a89726fe64007622a90a37f8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd7ae2a1be4274442d8d39a079835bab2e42ccac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Omer\Desktop\tftWEB\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Omer\Desktop\tftWEB\Views\Home\Index.cshtml"
 foreach (Item i in Model)
{

#line default
#line hidden
            BeginContext(106, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(115, 6, false);
#line 9 "C:\Users\Omer\Desktop\tftWEB\Views\Home\Index.cshtml"
   Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(121, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(123, 13, false);
#line 9 "C:\Users\Omer\Desktop\tftWEB\Views\Home\Index.cshtml"
           Write(i.Description);

#line default
#line hidden
            EndContext();
            BeginContext(136, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 10 "C:\Users\Omer\Desktop\tftWEB\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591