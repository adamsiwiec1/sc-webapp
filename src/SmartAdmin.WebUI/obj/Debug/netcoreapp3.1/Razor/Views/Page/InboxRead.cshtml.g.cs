#pragma checksum "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a12a0a7e036fb696270ceef7f76881cdda98f3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_InboxRead), @"mvc.1.0.view", @"/Views/Page/InboxRead.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a12a0a7e036fb696270ceef7f76881cdda98f3f", @"/Views/Page/InboxRead.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"533704a18c71ad5063d23e62fe4a94370682f53f", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_InboxRead : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen, print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fa-solid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fa-brands.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/demo/avatars/avatar-c.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-image profile-image-md rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Melissa Ayre"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Dr. Codex Lantern"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Signature", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Compose", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
   
	ViewData["Title"] = "Inbox Read";
	ViewData["PageName"] = "page_inbox_read";
	ViewData["Heading"] = "inbox";
	ViewData["Category1"] = "Page Views";
	ViewData["PreemptiveClass"] = "nav-function-minify layout-composed";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a12a0a7e036fb696270ceef7f76881cdda98f3f7859", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a12a0a7e036fb696270ceef7f76881cdda98f3f9119", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("<div class=\"d-flex flex-grow-1 p-0\">\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a12a0a7e036fb696270ceef7f76881cdda98f3f10479", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
	<div class=""d-flex flex-column flex-grow-1 bg-white"">
		<div class=""flex-grow-0"">
			<div class=""d-flex flex-wrap align-items-center pl-2 pr-3 py-2 px-sm-4 pr-lg-5 pl-lg-0 border-faded border-top-0 border-left-0 border-right-0"">
				<div class=""flex-1 d-flex align-items-center"">
					<a href=""/page/inboxgeneral"" class=""btn btn-icon rounded-circle mr-2 mr-lg-3"">
					<i class=""fas fa-arrow-left fs-lg""></i>
					</a>
					<a href=""javascript:void(0);"" class=""btn btn-icon rounded-circle mr-1"">
					<i class=""fas fa-redo fs-md""></i>
					</a>
					<a href=""/page/inboxgeneral"" class=""btn btn-icon rounded-circle mr-1"">
					<i class=""fas fa-exclamation-circle fs-md""></i>
					</a>
					<a href=""/page/inboxgeneral"" id=""js-delete-selected"" class=""btn btn-icon rounded-circle mr-1"">
					<i class=""fas fa-trash fs-md""></i>
					</a>
				</div>
				<div class=""text-muted mr-1 mr-lg-3 ml-auto"">
					<span class=""hidden-lg-down""> 1 - 50 of 135 </span>
					<div class=""btn-group hidden-lg-up"" role=""group"">
						<button t");
            WriteLiteral(@"ype=""button"" class=""btn btn-default"">Reply</button>
						<div class=""btn-group"" role=""group"">
							<button id=""dropdown-reply"" type=""button"" class=""btn btn-default dropdown-toggle px-2 js-waves-off"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""></button>
							<div class=""dropdown-menu p-0"" aria-labelledby=""dropdown-reply"">
								<a class=""dropdown-item"" href=""#"">Reply to all</a>
								<a class=""dropdown-item"" href=""#"">Forward</a>
								<div class=""dropdown-divider m-0""></div>
								<a class=""dropdown-item"" href=""#"">
								Move to...</a>
							</div>
						</div>
					</div>
				</div>
				<div class=""d-flex flex-wrap hidden-lg-down"">
					<button class=""btn btn-icon rounded-circle""><i");
            BeginWriteAttribute("class", " class=\"", 2207, "\"", 2265, 3);
#nullable restore
#line 48 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
WriteAttributeValue("", 2215, Settings.Theme.IconPrefix, 2215, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2243, "fa-chevron-left", 2244, 16, true);
            WriteAttributeValue(" ", 2259, "fs-md", 2260, 6, true);
            EndWriteAttribute();
            WriteLiteral("></i></button>\n\t\t\t\t\t<button class=\"btn btn-icon rounded-circle\"><i");
            BeginWriteAttribute("class", " class=\"", 2332, "\"", 2391, 3);
#nullable restore
#line 49 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
WriteAttributeValue("", 2340, Settings.Theme.IconPrefix, 2340, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2368, "fa-chevron-right", 2369, 17, true);
            WriteAttributeValue(" ", 2385, "fs-md", 2386, 6, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></button>
				</div>
			</div>
		</div>
		<div class=""flex-wrap align-items-center flex-grow-1 position-relative bg-white"">
			<div class="" position-absolute pos-top pos-bottom w-100 custom-scroll"">
				<div class=""d-flex h-100 flex-column"">
					<div class=""d-flex align-items-center pl-2 pr-3 py-3 pl-sm-3 pr-sm-4 py-sm-4 px-lg-5 py-lg-3 flex-shrink-0"">
						<a href=""javascript:void(0);"" class=""pl-3 pr-3 py-2 d-flex d-lg-none align-items-center justify-content-center mr-2 btn"" data-action=""toggle"" data-class=""slide-on-mobile-left-show"" data-target=""#js-inbox-menu"">
							<i");
            BeginWriteAttribute("class", " class=\"", 2979, "\"", 3038, 5);
#nullable restore
#line 58 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
WriteAttributeValue("", 2987, Settings.Theme.IconPrefix, 2987, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3015, "fa-ellipsis-v", 3016, 14, true);
            WriteAttributeValue(" ", 3029, "h1", 3030, 3, true);
            WriteAttributeValue(" ", 3032, "mb-0", 3033, 5, true);
            WriteAttributeValue(" ", 3037, "", 3038, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
						</a>
						<h1 class=""subheader-title mb-0 ml-2 ml-lg-5"">
							Re: New security codes
						</h1>
						<span class=""badge badge-primary ml-2 hidden-sm-down"">INBOX</span>
						<div class=""d-flex position-relative ml-auto"">
							<a href=""#"" title=""starred"" class=""btn btn-icon ml-1 fs-lg"">
								<i class=""fas fa-star color-warning-500""></i>
							</a>
							<a href=""javascript:void(0);"" class=""btn btn-icon ml-1 fs-lg"" data-toggle=""collapse"" data-target="".js-collapse"">
								<i class=""fas fa-arrows-v""></i>
							</a>
							<a href=""javascript:void(0);"" class=""btn btn-icon ml-1 fs-lg hidden-lg-down"">
								<i class=""fas fa-print""></i>
							</a>
						</div>
					</div>
					<div id=""msg-01"" class=""d-flex flex-column border-faded border-top-0 border-left-0 border-right-0 py-3 px-3 px-sm-4 px-lg-0 mr-0 mr-lg-5 flex-shrink-0"">
						<div class=""d-flex align-items-center flex-row"">
							<div class=""ml-0 mr-3 mx-lg-3"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a12a0a7e036fb696270ceef7f76881cdda98f3f16982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div class=\"fw-500 flex-1 d-flex flex-column cursor-pointer\" data-toggle=\"collapse\" data-target=\"#msg-01 > .js-collapse\">\n\t\t\t\t\t\t\t\t<div class=\"fs-lg\">\n\t\t\t\t\t\t\t\t\tMelissa Ayre\n\t\t\t\t\t\t\t\t\t<span class=\"fs-nano fw-400 ml-2\">notifications");
            WriteLiteral("@github.com</span>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t<div class=\"fs-nano\">\n\t\t\t\t\t\t\t\t\tto ");
#nullable restore
#line 87 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
                                   Write(Settings.Theme.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
							<div class=""color-fusion-200 fs-sm"">
								1:00 AM <span class=""hidden-sm-down"">(12 hours ago)</span>
							</div>
							<div class=""collapsed-reveal""> 
								<a href=""javascript:void(0);"" class=""btn btn-icon ml-1 fs-lg rounded-circle"">
									<i");
            BeginWriteAttribute("class", " class=\"", 4759, "\"", 4804, 2);
#nullable restore
#line 95 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
WriteAttributeValue("", 4767, Settings.Theme.IconPrefix, 4767, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4795, "fa-reply", 4796, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</a>
							</div>
						</div>
						<div class=""collapse js-collapse"">
							<div class=""pl-lg-5 ml-lg-5 pt-3 pb-4"">
								We've taken customer feedback on board and are pleased to announce that the the industry's most recommended and secure option for Two-Factor Authentication (2FA) is now available to use on our site.
								So, if you've tried our previous 2FA methods and have not been convinced, why not try our new Time-Based One-Time Password (TOTP)? It's super easy to use, and it works with many third-party 2FA apps you might already have on your phone. We're positive you'll love the new improved experience.
							</div>
						</div>
					</div>
					<div id=""msg-02"" class=""d-flex flex-column border-faded border-top-0 border-left-0 border-right-0 py-3 px-3 px-sm-4 px-lg-0 mr-0 mr-lg-5 flex-shrink-0"">
						<div class=""d-flex align-items-center flex-row"">
							<div class=""ml-0 mr-3 mx-lg-3"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a12a0a7e036fb696270ceef7f76881cdda98f3f20666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5756, "~/img/demo/avatars/", 5756, 19, true);
#nullable restore
#line 109 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
AddHtmlAttributeValue("", 5775, Settings.Theme.Avatar, 5775, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div class=\"fw-500 flex-1 d-flex flex-column cursor-pointer\" data-toggle=\"collapse\" data-target=\"#msg-02 > .js-collapse\">\n\t\t\t\t\t\t\t\t<div class=\"fs-lg\">\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 113 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
                                Write(Settings.Theme.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t\t\t\t\t<span class=\"fs-nano fw-400 ml-2\">me</span>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t<div class=\"fs-nano\">\n\t\t\t\t\t\t\t\t\tto melissa.ayre");
            WriteLiteral(@"@gotbootstrap.com
								</div>
							</div>
							<div class=""color-fusion-200 fs-sm"">
								7:00 AM <span class=""hidden-sm-down"">(6 hours ago)</span>
							</div>
							<div class=""collapsed-reveal""> 
								<a href=""javascript:void(0);"" class=""btn btn-icon ml-1 fs-lg rounded-circle"">
									<i");
            BeginWriteAttribute("class", " class=\"", 6513, "\"", 6558, 2);
#nullable restore
#line 125 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
WriteAttributeValue("", 6521, Settings.Theme.IconPrefix, 6521, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6549, "fa-reply", 6550, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</a>
							</div>
						</div>
						<div class=""collapse js-collapse"">
							<div class=""pl-lg-5 ml-lg-5 pt-3 pb-4"">
								We've taken customer feedback on board and are pleased to announce that the the industry's most recommended and secure option for Two-Factor Authentication (2FA) is now available to use on our site.
								So, if you've tried our previous 2FA methods and have not been convinced, why not try our new Time-Based One-Time Password (TOTP)? It's super easy to use, and it works with many third-party 2FA apps you might already have on your phone. We're positive you'll love the new improved experience.
								<br>
								<br>
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a12a0a7e036fb696270ceef7f76881cdda98f3f24583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
							</div>
						</div>
					</div>
					<div id=""msg-03"" class=""d-flex flex-column border-faded border-top-0 border-left-0 border-right-0 py-3 px-3 px-sm-4 px-lg-0 mr-0 mr-lg-5 flex-shrink-0"">
						<div class=""d-flex align-items-center flex-row"">
							<div class=""ml-0 mr-3 mx-lg-3 width-2"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a12a0a7e036fb696270ceef7f76881cdda98f3f26013", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div class=\"fw-500 flex-1 d-flex flex-column cursor-pointer\" data-toggle=\"collapse\" data-target=\"#msg-03 > .js-collapse\">\n\t\t\t\t\t\t\t\t<div class=\"fs-lg\">\n\t\t\t\t\t\t\t\t\tMelissa Ayre\n\t\t\t\t\t\t\t\t\t<span class=\"fs-nano fw-400 ml-2\">notifications");
            WriteLiteral("@github.com</span>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t<div class=\"fs-nano\">\n\t\t\t\t\t\t\t\t\tto ");
#nullable restore
#line 150 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
                                   Write(Settings.Theme.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
							<div class=""color-fusion-200 fs-sm"">
								6:00 AM <span class=""hidden-sm-down"">(5 hours ago)</span>
							</div>
							<div class=""collapsed-reveal""> 
								<a href=""javascript:void(0);"" class=""btn btn-icon ml-1 fs-lg rounded-circle"">
									<i");
            BeginWriteAttribute("class", " class=\"", 8327, "\"", 8372, 2);
#nullable restore
#line 158 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Page\InboxRead.cshtml"
WriteAttributeValue("", 8335, Settings.Theme.IconPrefix, 8335, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 8363, "fa-reply", 8364, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</a>
							</div>
						</div>
						<div id=""js-msg-1"" class=""js-collapse"">
							<div class=""pl-lg-5 ml-lg-5 pt-3 pb-4 "">
								We've taken customer feedback on board and are pleased to announce that the the industry's most recommended and secure option for Two-Factor Authentication (2FA) is now available to use on our site.
								So, if you've tried our previous 2FA methods and have not been convinced, why not try our new Time-Based One-Time Password (TOTP)? It's super easy to use, and it works with many third-party 2FA apps you might already have on your phone. We're positive you'll love the new improved experience.
							</div>
						</div>
					</div>	
				</div>
			</div>
		</div>
	</div>
	");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a12a0a7e036fb696270ceef7f76881cdda98f3f29478", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\n<script type=\"text/javascript\">\n\t// push settings with \"false\" save to local\n\tinitApp.pushSettings(\"nav-function-minify layout-composed\", false);\n</script>\n");
            }
            );
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
