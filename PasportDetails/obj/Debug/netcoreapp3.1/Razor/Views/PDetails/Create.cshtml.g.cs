#pragma checksum "C:\Users\Som\source\repos\PasportDetails\PasportDetails\Views\PDetails\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a759973cbf6581b482cfbfa286e84db3cec1be5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PDetails_Create), @"mvc.1.0.view", @"/Views/PDetails/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a759973cbf6581b482cfbfa286e84db3cec1be5d", @"/Views/PDetails/Create.cshtml")]
    public class Views_PDetails_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PasportDetails.Models.PDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Som\source\repos\PasportDetails\PasportDetails\Views\PDetails\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>PDetails</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""PHolderName"" class=""control-label""></label>
                <input asp-for=""PHolderName"" class=""form-control"" />
                <span asp-validation-for=""PHolderName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PPNumber"" class=""control-label""></label>
                <input asp-for=""PPNumber"" class=""form-control"" />
                <span asp-validation-for=""PPNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PPExp"" class=""control-label""></label>
                <input asp-for=""PPExp"" class=""form-control"" />
                <span asp-validation-for=""PPExp"" class=""text-danger""></");
            WriteLiteral(@"span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PPOCode"" class=""control-label""></label>
                <input asp-for=""PPOCode"" class=""form-control"" />
                <span asp-validation-for=""PPOCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Som\source\repos\PasportDetails\PasportDetails\Views\PDetails\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PasportDetails.Models.PDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591