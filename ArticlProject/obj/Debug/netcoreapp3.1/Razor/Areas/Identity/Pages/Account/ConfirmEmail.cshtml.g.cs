#pragma checksum "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\Account\ConfirmEmail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8f2b37aada4c079cc9115b02ce208039201738d7783802a695dd6c77e2a7ba7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\_ViewImports.cshtml"
using ArticlProject.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\_ViewImports.cshtml"
using ArticlProject.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ArticlProject.Areas.Identity.Pages.Account

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8f2b37aada4c079cc9115b02ce208039201738d7783802a695dd6c77e2a7ba7e", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0a96227ad5cdfe9621ecc9cb005aee9d72a8fd8a7ef3628d314f01f98aedb741", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cb7c14bd931a4919380155ad7b385a293bcbb0ec02d3449ac579fa0500ec11c6", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "تاكيد الايميل";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1 style=\"font-family: Cairo;direction:rtl\">");
            Write(
#nullable restore
#line 7 "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
                                              ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
