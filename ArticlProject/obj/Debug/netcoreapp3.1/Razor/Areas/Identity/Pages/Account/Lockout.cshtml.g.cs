#pragma checksum "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\Account\Lockout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "32c4b5da2402ef504dda6b2ac7e9249cec0cc13d1408eb675e2bf565d7c1273e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Lockout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"32c4b5da2402ef504dda6b2ac7e9249cec0cc13d1408eb675e2bf565d7c1273e", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0a96227ad5cdfe9621ecc9cb005aee9d72a8fd8a7ef3628d314f01f98aedb741", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cb7c14bd931a4919380155ad7b385a293bcbb0ec02d3449ac579fa0500ec11c6", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_Lockout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\Account\Lockout.cshtml"
  
    ViewData["Title"] = "قفل الحساب";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<header style=\"font-family: Cairo;direction:rtl\">\r\n    <h1 class=\"text-danger\">");
            Write(
#nullable restore
#line 8 "C:\Users\Legion\source\repos\ArticlProject\ArticlProject\Areas\Identity\Pages\Account\Lockout.cshtml"
                             ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">تم قفل حسابك , يرجى المحاولة لاحقا</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LockoutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel>)PageContext?.ViewData;
        public LockoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
