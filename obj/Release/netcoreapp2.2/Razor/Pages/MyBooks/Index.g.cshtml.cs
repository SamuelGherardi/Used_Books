#pragma checksum "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e160c398effa05809dc1b778c7d44063f63a41b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Used_Books.Pages.MyBooks.Pages_MyBooks_Index), @"mvc.1.0.razor-page", @"/Pages/MyBooks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/MyBooks/Index.cshtml", typeof(Used_Books.Pages.MyBooks.Pages_MyBooks_Index), null)]
namespace Used_Books.Pages.MyBooks
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\_ViewImports.cshtml"
using Used_Books;

#line default
#line hidden
#line 3 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\_ViewImports.cshtml"
using Used_Books.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e160c398effa05809dc1b778c7d44063f63a41b", @"/Pages/MyBooks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a45afe256240561d6423aa47c2fff2ea4fd7a5be", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyBooks_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 28, true);
            WriteLiteral("\r\n<h1>My Books</h1>\r\n\r\n<p>\r\n");
            EndContext();
            BeginContext(120, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e160c398effa05809dc1b778c7d44063f63a41b4774", async() => {
                BeginContext(141, 15, true);
                WriteLiteral("Insert New Book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(160, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(253, 48, false);
#line 16 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(301, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(357, 48, false);
#line 19 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Nome));

#line default
#line hidden
            EndContext();
            BeginContext(405, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(461, 51, false);
#line 22 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Editore));

#line default
#line hidden
            EndContext();
            BeginContext(512, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(568, 56, false);
#line 25 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Corso_studio));

#line default
#line hidden
            EndContext();
            BeginContext(624, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(680, 50, false);
#line 28 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Classe));

#line default
#line hidden
            EndContext();
            BeginContext(730, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(786, 51, false);
#line 31 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Materia));

#line default
#line hidden
            EndContext();
            BeginContext(837, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(893, 52, false);
#line 34 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Studente));

#line default
#line hidden
            EndContext();
            BeginContext(945, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1001, 50, false);
#line 37 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Prezzo));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
         foreach (var item in Model.Book)
        {

#line default
#line hidden
            BeginContext(1191, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1240, 39, false);
#line 47 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1335, 39, false);
#line 50 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1430, 42, false);
#line 53 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Editore));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1528, 47, false);
#line 56 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Corso_studio));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1631, 41, false);
#line 59 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Classe));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1728, 42, false);
#line 62 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1826, 43, false);
#line 65 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Studente));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1925, 41, false);
#line 68 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prezzo));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2021, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e160c398effa05809dc1b778c7d44063f63a41b13329", async() => {
                BeginContext(2066, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
                                       WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2074, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2094, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e160c398effa05809dc1b778c7d44063f63a41b15670", async() => {
                BeginContext(2142, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
                                          WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2153, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2173, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e160c398effa05809dc1b778c7d44063f63a41b18017", async() => {
                BeginContext(2220, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
                                         WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2230, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 76 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\MyBooks\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2277, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Used_Books.Pages.MyBooks.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Used_Books.Pages.MyBooks.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Used_Books.Pages.MyBooks.IndexModel>)PageContext?.ViewData;
        public Used_Books.Pages.MyBooks.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591