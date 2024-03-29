#pragma checksum "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Order\DeliveryMethod.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5600d08e0f746f446fd68659c22163f0343b7219"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_DeliveryMethod), @"mvc.1.0.view", @"/Views/Order/DeliveryMethod.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5600d08e0f746f446fd68659c22163f0343b7219", @"/Views/Order/DeliveryMethod.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c0986c3ed7b02d33d2eaa8522530d50e32cc42", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_DeliveryMethod : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IReadOnlyDictionary<string, string>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Order\DeliveryMethod.cshtml"
  
    ViewData["Title"] = "Cпособ доставки";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Способ доставки</h1>\r\n\r\n<nav>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5600d08e0f746f446fd68659c22163f0343b72194890", async() => {
                WriteLiteral("\r\n        <div class=\"from-group\">\r\n            <h3 class=\"ml-3\"><label for=\"code\">Способ доставки:</label></h3>\r\n            <br/>\r\n            <select class=\"from-control ml-3\" name=\"serviceName\">\r\n");
#nullable restore
#line 14 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Order\DeliveryMethod.cshtml"
                 foreach (var method in Model)
                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5600d08e0f746f446fd68659c22163f0343b72195651", async() => {
#nullable restore
#line 16 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Order\DeliveryMethod.cshtml"
                                           Write(method.Value);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Order\DeliveryMethod.cshtml"
                       WriteLiteral(method.Key);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Order\DeliveryMethod.cshtml"
                 }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn_many ml-3 mb-3 mt-3\">Далее</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "C:\Users\PC\Desktop\Store\presentation\Store.Web\Views\Order\DeliveryMethod.cshtml"
AddHtmlAttributeValue("", 150, Url.Action(nameof(OrderController.StartDelivery)), 150, 50, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IReadOnlyDictionary<string, string>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
