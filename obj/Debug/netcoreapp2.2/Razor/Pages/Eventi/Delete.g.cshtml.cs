#pragma checksum "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e8c7bc40b6989a1c5f92d5f7207f79044a9461a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Used_Books.Pages.Eventi.Pages_Eventi_Delete), @"mvc.1.0.razor-page", @"/Pages/Eventi/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Eventi/Delete.cshtml", typeof(Used_Books.Pages.Eventi.Pages_Eventi_Delete), null)]
namespace Used_Books.Pages.Eventi
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e8c7bc40b6989a1c5f92d5f7207f79044a9461a", @"/Pages/Eventi/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a45afe256240561d6423aa47c2fff2ea4fd7a5be", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Eventi_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(95, 164, true);
            WriteLiteral("\r\n<h1>Reservation</h1>\r\n\r\n<h3>Are you sure you want to reserve this book?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(260, 45, false);
#line 15 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(305, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(367, 41, false);
#line 18 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Book.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(408, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(469, 45, false);
#line 21 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(514, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(576, 41, false);
#line 24 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Book.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(617, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(678, 48, false);
#line 27 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Editore));

#line default
#line hidden
            EndContext();
            BeginContext(726, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(788, 44, false);
#line 30 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Book.Editore));

#line default
#line hidden
            EndContext();
            BeginContext(832, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(893, 53, false);
#line 33 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Corso_studio));

#line default
#line hidden
            EndContext();
            BeginContext(946, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1008, 49, false);
#line 36 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Book.Corso_studio));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1118, 47, false);
#line 39 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Classe));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1227, 43, false);
#line 42 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Book.Classe));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1331, 48, false);
#line 45 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1441, 44, false);
#line 48 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Book.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1546, 49, false);
#line 51 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Studente));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1657, 45, false);
#line 54 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Book.Studente));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1763, 47, false);
#line 57 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Prezzo));

#line default
#line hidden
            EndContext();
            BeginContext(1810, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1872, 43, false);
#line 60 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Book.Prezzo));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1953, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e8c7bc40b6989a1c5f92d5f7207f79044a9461a11862", async() => {
                BeginContext(1973, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1983, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e8c7bc40b6989a1c5f92d5f7207f79044a9461a12255", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Book.id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2024, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Reserve\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2108, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e8c7bc40b6989a1c5f92d5f7207f79044a9461a14164", async() => {
                    BeginContext(2130, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2146, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2159, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Used_Books.Pages.Eventi.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Used_Books.Pages.Eventi.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Used_Books.Pages.Eventi.DeleteModel>)PageContext?.ViewData;
        public Used_Books.Pages.Eventi.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
