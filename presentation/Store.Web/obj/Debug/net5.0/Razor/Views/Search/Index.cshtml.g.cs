#pragma checksum "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7390bb8c7ad51c5bdf61a6842014b51abfccf181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using Store.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using Store.Web.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using Store.Web.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using BookStore.Contractors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using Store.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7390bb8c7ad51c5bdf61a6842014b51abfccf181", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c0986c3ed7b02d33d2eaa8522530d50e32cc42", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IReadOnlyCollection<BookModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml"
   
    ViewData["Title"] = "Результаты поиска";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Результаты поиска</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Ничего не найдено</p>\r\n");
#nullable restore
#line 12 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml"
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 16 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml"
         foreach(var book in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 274, "\"", 330, 1);
#nullable restore
#line 18 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml"
WriteAttributeValue("", 281, Url.Action("Index", "Book", new { id = book.Id}), 281, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mt-2\">\r\n                ");
#nullable restore
#line 19 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml"
           Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                <p>");
#nullable restore
#line 20 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml"
              Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </a></li>\r\n");
#nullable restore
#line 22 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 24 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Search\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IReadOnlyCollection<BookModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
