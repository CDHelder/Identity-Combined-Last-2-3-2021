#pragma checksum "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc9b6506260c9a5f36e8d573061fb37b3b2d2d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RepairMvc.Pages.RepairOrders.Pages_RepairOrders_Details), @"mvc.1.0.razor-page", @"/Pages/RepairOrders/Details.cshtml")]
namespace RepairMvc.Pages.RepairOrders
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
#line 1 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\_ViewImports.cshtml"
using RepairMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\_ViewImports.cshtml"
using RepairMvc.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc9b6506260c9a5f36e8d573061fb37b3b2d2d5", @"/Pages/RepairOrders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14434d34d2a38496f09da1635f8ac95fb9a0957f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RepairOrders_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./CreateInvoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>RepairOrder</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
        <!--
    Verwerk hier de customer en emplyee info verder

    <dt class=""col-sm-2"">
        Html.DisplayNameFor(model => model.RepairOrder.Customer)
    </dt>
    <dd class=""col-sm-10"">
        Html.DisplayFor(model => model.RepairOrder.Customer.Name)
        <span style=""color:grey"">
            &emsp;&emsp;&emsp;&emsp; Email: Model.RepairOrder.Customer.Emailadress
            &emsp;&emsp;&emsp;&emsp; Phone: Model.RepairOrder.Customer.PhoneNumber
        </span>
    </dd>
    <dt class=""col-sm-2"">
        Html.DisplayNameFor(model => model.RepairOrder.Employee)
    </dt>
    <dd class=""col-sm-10"">
        Html.DisplayFor(model => model.RepairOrder.Employee.Name)
        <span style=""color:grey"">
            &emsp;&emsp;&emsp;&emsp; Email: Model.RepairOrder.Employee.Emailadress
            &emsp;&emsp;&emsp;&emsp; Phone: Model.RepairOrder.Employee.PhoneNumber
        </span>
    </dd>
    -->
        <dt class=""col-sm-2"">
            ");
#nullable restore
#line 47 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.HoursWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.HoursWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.BeginDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.BeginDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 71 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.WorkReport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.WorkReport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br><br />\r\n        </dd>\r\n\r\n");
#nullable restore
#line 78 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
         if (Model.Order.PartID1 != null || Model.Order.PartID2 != null || Model.Order.PartID3 != null
|| Model.Order.PartID4 != null || Model.Order.PartID5 != null || Model.Order.PartID6 != null
|| Model.Order.PartID7 != null || Model.Order.PartID8 != null)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\"><u>Part Name</u></dt>\n            <dd class=\"col-sm-10\"><u>Part Quantity</u></dd>\n");
#nullable restore
#line 85 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"

            if (Model.Order.PartID1 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    <label class=\"control-label\">");
#nullable restore
#line 89 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(ViewBag.PartID1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <label class=\"control-label\">");
#nullable restore
#line 92 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(Model.Order.Part1Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dd>\n");
#nullable restore
#line 94 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
            }
            if (Model.Order.PartID2 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    <label class=\"control-label\">");
#nullable restore
#line 98 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(ViewBag.PartID2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <label class=\"control-label\">");
#nullable restore
#line 101 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(Model.Order.Part2Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dd>\n");
#nullable restore
#line 103 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
            }
            if (Model.Order.PartID3 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    <label class=\"control-label\">");
#nullable restore
#line 107 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(ViewBag.PartID3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <label class=\"control-label\">");
#nullable restore
#line 110 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(Model.Order.Part3Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dd>\n");
#nullable restore
#line 112 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
            }
            if (Model.Order.PartID4 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    <label class=\"control-label\">");
#nullable restore
#line 116 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(ViewBag.PartID4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <label class=\"control-label\">");
#nullable restore
#line 119 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(Model.Order.Part4Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dd>\n");
#nullable restore
#line 121 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
            }
            if (Model.Order.PartID5 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    <label class=\"control-label\">");
#nullable restore
#line 125 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(ViewBag.PartID5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <label class=\"control-label\">");
#nullable restore
#line 128 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(Model.Order.Part5Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dd>\n");
#nullable restore
#line 130 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
            }
            if (Model.Order.PartID6 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    <label class=\"control-label\">");
#nullable restore
#line 134 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(ViewBag.PartID6);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <label class=\"control-label\">");
#nullable restore
#line 137 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(Model.Order.Part6Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dd>\n");
#nullable restore
#line 139 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
            }
            if (Model.Order.PartID7 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    <label class=\"control-label\">");
#nullable restore
#line 143 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(ViewBag.PartID7);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <label class=\"control-label\">");
#nullable restore
#line 146 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(Model.Order.Part7Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dd>\n");
#nullable restore
#line 148 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
            }
            if (Model.Order.PartID8 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    <label class=\"control-label\">");
#nullable restore
#line 152 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(ViewBag.PartID8);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <label class=\"control-label\">");
#nullable restore
#line 155 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                            Write(Model.Order.Part8Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </dd>\n");
#nullable restore
#line 157 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc9b6506260c9a5f36e8d573061fb37b3b2d2d519458", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 165 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                           WriteLiteral(Model.Order.OrderId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc9b6506260c9a5f36e8d573061fb37b3b2d2d521628", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc9b6506260c9a5f36e8d573061fb37b3b2d2d522794", async() => {
                WriteLiteral("Create Invoice");
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
#nullable restore
#line 167 "C:\Users\CDHel\Desktop\Youri laatste Versie Identity\RepairMvc\Pages\RepairOrders\Details.cshtml"
                                    WriteLiteral(Model.Order.OrderId);

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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Razor_Identity.Pages.RepairOrders.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Razor_Identity.Pages.RepairOrders.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Razor_Identity.Pages.RepairOrders.DetailsModel>)PageContext?.ViewData;
        public Razor_Identity.Pages.RepairOrders.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
