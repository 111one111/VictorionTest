#pragma checksum "B:\Code\Test2\NetVet\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bc3aed7b048649df7c367948f4d3bcaafd6f766"
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
#line 1 "B:\Code\Test2\NetVet\Views\_ViewImports.cshtml"
using NetVet;

#line default
#line hidden
#line 2 "B:\Code\Test2\NetVet\Views\_ViewImports.cshtml"
using NetVet.Models;

#line default
#line hidden
#line 6 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc3aed7b048649df7c367948f4d3bcaafd6f766", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12584e54e35005c1adc32a4d5e5f27cc7f7bedb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("param-page-number", "pageNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(96, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6ac3e5ac42f4de69502243d8f303feb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(152, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Get))
{

#line default
#line hidden
            BeginContext(217, 97, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"appointment\">Appointment Date</label>\r\n        ");
            EndContext();
            BeginContext(315, 157, false);
#line 14 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(model => model.DateTime, new { @class = "form-control", name = "date", placeholder = "Appointment Time", type = "date", id = "appointment" }));

#line default
#line hidden
            EndContext();
            BeginContext(472, 99, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"petName\">Pet Name</label>\r\n        ");
            EndContext();
            BeginContext(572, 133, false);
#line 18 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(model => model.PetName, new { @class = "form-control", name = "petName", placeholder = "Pets Name", id = "petName" }));

#line default
#line hidden
            EndContext();
            BeginContext(705, 105, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"ownersName\">Owners Name</label>\r\n        ");
            EndContext();
            BeginContext(811, 144, false);
#line 22 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(model => model.OwnersName, new { @class = "form-control", name = "ownersName", placeholder = "Owners Name", id = "ownersName" }));

#line default
#line hidden
            EndContext();
            BeginContext(955, 113, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"contactDetails\">Contact Details</label>\r\n        ");
            EndContext();
            BeginContext(1069, 146, false);
#line 26 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(model => model.Contact, new { @class = "form-control", name = "contact", placeholder = "Contact Details", id = "contactDetails" }));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 127, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">Search</button>\r\n    </div>\r\n");
            EndContext();
#line 31 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1345, 273, true);
            WriteLiteral(@"
<table class=""table"">
    <tr>
        <th>
            Appointment Date/Time
        </th>
        <th>
            Pet Name
        </th>
        <th>
            Owners Name
        </th>
        <th>
            Perferd Contact
        </th>
    </tr>
");
            EndContext();
#line 48 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
     if (Model.AppointmentDetails.TotalItemCount == 0)
    {

#line default
#line hidden
            BeginContext(1681, 126, true);
            WriteLiteral("        <tr>\r\n            <td colspan=\"4\">\r\n                <h3>No Appointments Found</h3>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
    }
    else
    {
        foreach (var appointment in Model.AppointmentDetails)
        {

#line default
#line hidden
            BeginContext(1905, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1966, 45, false);
#line 62 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(m => appointment.Appointment));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2079, 41, false);
#line 65 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(m => appointment.PetName));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2188, 44, false);
#line 68 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(m => appointment.OwnersName));

#line default
#line hidden
            EndContext();
            BeginContext(2232, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2300, 56, false);
#line 71 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(m => appointment.PreferedContactDetails));

#line default
#line hidden
            EndContext();
            BeginContext(2356, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 74 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2418, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
#line 77 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
  
    var routeData = new Dictionary<string, string>();
    routeData.Add("dateTime", Model.DateTime);
    routeData.Add("petName", Model.PetName);
    routeData.Add("ownersName", Model.OwnersName);
    routeData.Add("contact", Model.Contact);

#line default
#line hidden
            BeginContext(2682, 233, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71a05836b0d94e84ae5fc714e4c41c3a", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 84 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model.AppointmentDetails;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 84 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedListRenderOptions.TwitterBootstrapPager;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __PagedList_Core_Mvc_PagerTagHelper.ParamPageNumber = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 85 "B:\Code\Test2\NetVet\Views\Home\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.RouteValues = routeData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __PagedList_Core_Mvc_PagerTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2915, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchData> Html { get; private set; }
    }
}
#pragma warning restore 1591
