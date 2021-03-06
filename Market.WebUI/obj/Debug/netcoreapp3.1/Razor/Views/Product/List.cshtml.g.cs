#pragma checksum "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d97d98fcbea2f52f4c03b3eba160af2925f2619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\_ViewImports.cshtml"
using Market.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\_ViewImports.cshtml"
using Market.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\_ViewImports.cshtml"
using Market.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d97d98fcbea2f52f4c03b3eba160af2925f2619", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"071020307ae8a19a020619f3b37e39d01409d823", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Product List</h1>
<hr />
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Delete</th>
            <th>Name</th>
            <th>Price</th>
            <th>Description</th>
            <th>Image</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 497, "\"", 525, 2);
            WriteAttributeValue("", 504, "/Product/Delete/", 504, 16, true);
#nullable restore
#line 24 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
WriteAttributeValue("", 520, x.Id, 520, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\"><strong>X</strong></a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 596, "\"", 624, 2);
            WriteAttributeValue("", 603, "/Product/Update/", 603, 16, true);
#nullable restore
#line 25 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
WriteAttributeValue("", 619, x.Id, 619, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
                                               Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 666, "\"", 694, 2);
            WriteAttributeValue("", 673, "/Product/Update/", 673, 16, true);
#nullable restore
#line 26 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
WriteAttributeValue("", 689, x.Id, 689, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
                                               Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 739, "\"", 767, 2);
            WriteAttributeValue("", 746, "/Product/Update/", 746, 16, true);
#nullable restore
#line 27 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
WriteAttributeValue("", 762, x.Id, 762, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
                                               Write(x.Descriprion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d97d98fcbea2f52f4c03b3eba160af2925f26197150", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 846, "~/img/", 846, 6, true);
#nullable restore
#line 29 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 852, x.Image, 852, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Bedirhan\source\repos\Market\Market.WebUI\Views\Product\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/Product/Create\" class=\"btn btn-primary\" style=\"width:inherit;\">Create Product</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
