#pragma checksum "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_Logo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec252391cade8511a77bb6ebc02fda5dc43f78da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Logo), @"mvc.1.0.view", @"/Views/Shared/_Logo.cshtml")]
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
#line 1 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\_ViewImports.cshtml"
using SmartAdmin.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\_ViewImports.cshtml"
using SmartAdmin.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\_ViewImports.cshtml"
using SmartAdmin.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec252391cade8511a77bb6ebc02fda5dc43f78da", @"/Views/Shared/_Logo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"533704a18c71ad5063d23e62fe4a94370682f53f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Logo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-roledescription", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"page-logo\">\n\t<a href=\"#\" class=\"page-logo-link press-scale-down d-flex align-items-center position-relative\">\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ec252391cade8511a77bb6ebc02fda5dc43f78da3955", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 134, "~/img/", 134, 6, true);
#nullable restore
#line 3 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_Logo.cshtml"
AddHtmlAttributeValue("", 140, Settings.Theme.Logo, 140, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 3 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_Logo.cshtml"
AddHtmlAttributeValue("", 169, Settings.AppFlavor, 169, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t<span class=\"page-logo-text mr-1\">");
#nullable restore
#line 4 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_Logo.cshtml"
                                     Write(Settings.AppName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t\t<span class=\"position-absolute text-white opacity-50 small pos-top pos-right mr-2 mt-n2\">");
#nullable restore
#line 5 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_Logo.cshtml"
                                                                                            Write(Settings.AppFlavorSubscript);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 6 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_Logo.cshtml"
         if (ViewBag.AppShortcutModal?.Length > 0)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<i");
            BeginWriteAttribute("class", " class=\"", 459, "\"", 553, 6);
#nullable restore
#line 8 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_Logo.cshtml"
WriteAttributeValue("", 467, Settings.Theme.IconPrefix, 467, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 495, "fa-angle-down", 496, 14, true);
            WriteAttributeValue(" ", 509, "d-inline-block", 510, 15, true);
            WriteAttributeValue(" ", 524, "ml-1", 525, 5, true);
            WriteAttributeValue(" ", 529, "fs-lg", 530, 6, true);
            WriteAttributeValue(" ", 535, "color-primary-300", 536, 18, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n");
#nullable restore
#line 9 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_Logo.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</a>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SmartSettings Settings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591