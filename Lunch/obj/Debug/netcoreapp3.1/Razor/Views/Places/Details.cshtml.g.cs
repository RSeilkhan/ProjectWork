#pragma checksum "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d59d0ac36e7c8fa360f09a7e59fa7449a13f2d27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Places_Details), @"mvc.1.0.view", @"/Views/Places/Details.cshtml")]
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
#line 1 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\_ViewImports.cshtml"
using Lunch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\_ViewImports.cshtml"
using Lunch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d59d0ac36e7c8fa360f09a7e59fa7449a13f2d27", @"/Views/Places/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f7d23bd44691c40b219de806d86104d13f21659", @"/Views/_ViewImports.cshtml")]
    public class Views_Places_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lunch.ViewModels.PlacesData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
 foreach (var item in Model.Places)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>\r\n        ");
#nullable restore
#line 9 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
   Write(Html.DisplayFor(model => item.place_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n");
            WriteLiteral("    <div>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dd class=\"col-sm-10\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 305, "\"", 346, 1);
#nullable restore
#line 16 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
WriteAttributeValue("", 311, Html.DisplayFor(model => item.img), 311, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"альтернативный текст\">\r\n            </dd>\r\n\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
           Write(Html.DisplayFor(model => item.short_desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 24 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
           Write(Html.DisplayFor(model => item.desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dd class=\"col-sm-10\">\r\n                Средний счет: ");
#nullable restore
#line 28 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                         Write(Html.DisplayFor(model => item.av_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n\r\n            <dd class=\"col-sm-10\">\r\n                Адрес: ");
#nullable restore
#line 33 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                  Write(Html.DisplayFor(model => item.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 36 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
           Write(Html.DisplayFor(model => item.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dd class=\"col-sm-10\">\r\n                Кухня: ");
#nullable restore
#line 40 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                  Write(Html.DisplayFor(model => item.Kitchen.kitchen_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dd class=\"col-sm-10\">\r\n                Ссылки: ");
#nullable restore
#line 44 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                   Write(Html.DisplayFor(model => item.Links));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 48 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                  
                    foreach (var link in item.Links)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><a");
            BeginWriteAttribute("href", " href=\"", 1404, "\"", 1420, 1);
#nullable restore
#line 51 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
WriteAttributeValue("", 1411, link.url, 1411, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                                          Write(link.link_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n");
#nullable restore
#line 52 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"


                        
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n\r\n            <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 60 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                  
                    foreach (var menu in item.Menus)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <hr>\r\n                        <p>Название: ");
#nullable restore
#line 64 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                                Write(menu.menu_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Описание: ");
#nullable restore
#line 65 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                                Write(menu.product_desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Первое: ");
#nullable restore
#line 66 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                              Write(menu.first);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Второе: ");
#nullable restore
#line 67 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                              Write(menu.second);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Напиток: ");
#nullable restore
#line 68 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                               Write(menu.drink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Салат: ");
#nullable restore
#line 69 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                             Write(menu.salat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p style=\"margin-bottom:20px\">Цена: ");
#nullable restore
#line 70 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                                                       Write(menu.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" тг</p>\r\n");
#nullable restore
#line 71 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"

                        

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n\r\n\r\n        </dl>\r\n    </div>\r\n");
            WriteLiteral("    <div style=\"margin-bottom:40px\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d59d0ac36e7c8fa360f09a7e59fa7449a13f2d2711290", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
                               WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d59d0ac36e7c8fa360f09a7e59fa7449a13f2d2713431", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 86 "C:\Users\neblh\source\repos\AA\Lunch\Lunch\Views\Places\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lunch.ViewModels.PlacesData> Html { get; private set; }
    }
}
#pragma warning restore 1591