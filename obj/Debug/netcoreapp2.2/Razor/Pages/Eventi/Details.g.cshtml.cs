#pragma checksum "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d47ba22c674cc96e49e5760b5e830d02de0b0cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Used_Books.Pages.Eventi.Pages_Eventi_Details), @"mvc.1.0.razor-page", @"/Pages/Eventi/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Eventi/Details.cshtml", typeof(Used_Books.Pages.Eventi.Pages_Eventi_Details), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d47ba22c674cc96e49e5760b5e830d02de0b0cb", @"/Pages/Eventi/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a45afe256240561d6423aa47c2fff2ea4fd7a5be", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Eventi_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 125, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Book</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(223, 45, false);
#line 15 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(268, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(330, 41, false);
#line 18 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(371, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(432, 45, false);
#line 21 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(477, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(539, 41, false);
#line 24 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(580, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(641, 48, false);
#line 27 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Editore));

#line default
#line hidden
            EndContext();
            BeginContext(689, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(751, 44, false);
#line 30 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Editore));

#line default
#line hidden
            EndContext();
            BeginContext(795, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(856, 53, false);
#line 33 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Corso_studio));

#line default
#line hidden
            EndContext();
            BeginContext(909, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(971, 49, false);
#line 36 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Corso_studio));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1081, 47, false);
#line 39 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Classe));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1190, 43, false);
#line 42 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Classe));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1294, 48, false);
#line 45 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1404, 44, false);
#line 48 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1509, 49, false);
#line 51 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Studente));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1620, 45, false);
#line 54 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Studente));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1726, 49, false);
#line 57 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Studente));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1837, 43, false);
#line 60 "C:\Users\matte\Desktop\5ID\Informatica\Used_Books\Pages\Eventi\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Prezzo));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1927, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d47ba22c674cc96e49e5760b5e830d02de0b0cb10857", async() => {
                BeginContext(1949, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1965, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Used_Books.Pages.Eventi.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Used_Books.Pages.Eventi.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Used_Books.Pages.Eventi.DetailsModel>)PageContext?.ViewData;
        public Used_Books.Pages.Eventi.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591