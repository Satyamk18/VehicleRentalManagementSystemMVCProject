#pragma checksum "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\Vehicle\ReturnVehicleConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4e3d6bcd67bf589995714a9912ce5928c4e8749"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_ReturnVehicleConfirmation), @"mvc.1.0.view", @"/Views/Vehicle/ReturnVehicleConfirmation.cshtml")]
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
#line 1 "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\_ViewImports.cshtml"
using VehicleRentalManagementProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\_ViewImports.cshtml"
using VehicleRentalManagementProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4e3d6bcd67bf589995714a9912ce5928c4e8749", @"/Views/Vehicle/ReturnVehicleConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"289173efeda0dbef7f31d0ada85a383f86d67930", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_ReturnVehicleConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleRentalManagementProject.Models.TransactionVrm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowVehicles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\Vehicle\ReturnVehicleConfirmation.cshtml"
  
    ViewData["Title"] = "ReturnVehicleConfirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center\">Vehicle Return Confirmation</h1><br>\r\n\r\n<div>\r\n    <h5>Thanks For Returning Vehicle</h5>\r\n    <hr />\r\n\r\n    <p><b>Transaction Id : </b>");
#nullable restore
#line 13 "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\Vehicle\ReturnVehicleConfirmation.cshtml"
                          Write(ViewBag.transaction.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><b>User Id : </b>");
#nullable restore
#line 14 "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\Vehicle\ReturnVehicleConfirmation.cshtml"
                   Write(ViewBag.transaction.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><b>Vehicle Id : </b>");
#nullable restore
#line 15 "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\Vehicle\ReturnVehicleConfirmation.cshtml"
                      Write(ViewBag.transaction.VehicleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><b>Rental Rate : </b>");
#nullable restore
#line 16 "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\Vehicle\ReturnVehicleConfirmation.cshtml"
                       Write(ViewBag.transaction.RentalRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><b>Rental Start Date : </b>");
#nullable restore
#line 17 "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\Vehicle\ReturnVehicleConfirmation.cshtml"
                             Write(ViewBag.transaction.RentalStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><b>Rental End Date : </b>");
#nullable restore
#line 18 "C:\Users\S.K.yam15\VehicleRentalManagementProject\Views\Vehicle\ReturnVehicleConfirmation.cshtml"
                           Write(ViewBag.transaction.RentalEndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n<div>\r\n    <div class=\"text-center\">\r\n        <button type=\"button\" class=\"btn btn-primary\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3d6bcd67bf589995714a9912ce5928c4e87496615", async() => {
                WriteLiteral("Give Review of the vehicle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button><br>\r\n        <br>\r\n        <button type=\"button\" class=\"btn btn-danger\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3d6bcd67bf589995714a9912ce5928c4e87497959", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n    </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleRentalManagementProject.Models.TransactionVrm> Html { get; private set; }
    }
}
#pragma warning restore 1591
