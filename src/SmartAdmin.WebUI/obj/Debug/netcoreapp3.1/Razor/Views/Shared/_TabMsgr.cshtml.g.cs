#pragma checksum "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_TabMsgr.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "137adab55964079ae54fec9c03fcdd86bf1912b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TabMsgr), @"mvc.1.0.view", @"/Views/Shared/_TabMsgr.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"137adab55964079ae54fec9c03fcdd86bf1912b8", @"/Views/Shared/_TabMsgr.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"533704a18c71ad5063d23e62fe4a94370682f53f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TabMsgr : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""msgr-list d-flex flex-column bg-faded border-faded border-top-0 border-right-0 border-bottom-0 position-absolute pos-top pos-bottom"">
	<div>
		<div class=""height-4 width-3 h3 m-0 d-flex justify-content-center flex-column color-primary-500 pl-3 mt-2"">
			<i");
            BeginWriteAttribute("class", " class=\"", 268, "\"", 314, 2);
#nullable restore
#line 4 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_TabMsgr.cshtml"
WriteAttributeValue("", 276, Settings.Theme.IconPrefix, 276, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 304, "fa-search", 305, 10, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
		</div>
		<input type=""text"" class=""form-control bg-white"" id=""msgr_listfilter_input"" placeholder=""Filter contacts"" aria-label=""FriendSearch"" data-listfilter=""#js-msgr-listfilter"">
	</div>
	<div class=""flex-1 h-100 custom-scroll"">
		<div class=""w-100"">
			<ul id=""js-msgr-listfilter"" class=""list-unstyled m-0"">
				<li>
					<a href=""#"" class=""d-table w-100 px-2 py-2 text-dark hover-white"" data-filter-tags=""tracey chang online"">
						<div class=""d-table-cell align-middle status status-success status-sm "">
							<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-d.png'); background-size: cover;""></span>
						</div>
						<div class=""d-table-cell w-100 align-middle pl-2 pr-2"">
							<div class=""text-truncate text-truncate-md"">
								Tracey Chang
								<small class=""d-block font-italic text-success fs-xs"">
									Online
								</small>
							</div>
						</div>
					</a>
				</li>
				<li>
					<a href=""#"" class=""d-table w-100 px-2 py-2 te");
            WriteLiteral(@"xt-dark hover-white"" data-filter-tags=""oliver kopyuv online"">
						<div class=""d-table-cell align-middle status status-success status-sm "">
							<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-b.png'); background-size: cover;""></span>
						</div>
						<div class=""d-table-cell w-100 align-middle pl-2 pr-2"">
							<div class=""text-truncate text-truncate-md"">
								Oliver Kopyuv
								<small class=""d-block font-italic text-success fs-xs"">
									Online
								</small>
							</div>
						</div>
					</a>
				</li>
				<li>
					<a href=""#"" class=""d-table w-100 px-2 py-2 text-dark hover-white"" data-filter-tags=""dr john cook phd away"">
						<div class=""d-table-cell align-middle status status-warning status-sm "">
							<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-e.png'); background-size: cover;""></span>
						</div>
						<div class=""d-table-cell w-100 align-middle pl-2 pr-2"">
	");
            WriteLiteral(@"						<div class=""text-truncate text-truncate-md"">
								Dr. John Cook PhD
								<small class=""d-block font-italic fs-xs"">
									Away
								</small>
							</div>
						</div>
					</a>					
				</li>
				<li>
					<a href=""#"" class=""d-table w-100 px-2 py-2 text-dark hover-white"" data-filter-tags=""ali amdaney online"">
						<div class=""d-table-cell align-middle status status-success status-sm "">
							<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-g.png'); background-size: cover;""></span>
						</div>
						<div class=""d-table-cell w-100 align-middle pl-2 pr-2"">
							<div class=""text-truncate text-truncate-md"">
								Ali Amdaney
								<small class=""d-block font-italic fs-xs text-success"">
									Online
								</small>
							</div>
						</div>
					</a>
				</li>
				<li>
					<a href=""#"" class=""d-table w-100 px-2 py-2 text-dark hover-white"" data-filter-tags=""sarah mcbrook online"">
						<div class=""d-table-cell align-middle stat");
            WriteLiteral(@"us status-success status-sm"">
							<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-h.png'); background-size: cover;""></span>
						</div>
						<div class=""d-table-cell w-100 align-middle pl-2 pr-2"">
							<div class=""text-truncate text-truncate-md"">
								Sarah McBrook
								<small class=""d-block font-italic fs-xs text-success"">
									Online
								</small>
							</div>
						</div>
					</a>
				</li>
				<li>
					<a href=""#"" class=""d-table w-100 px-2 py-2 text-dark hover-white"" data-filter-tags=""ali amdaney offline"">
						<div class=""d-table-cell align-middle status status-sm"">
							<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-a.png'); background-size: cover;""></span>
						</div>
						<div class=""d-table-cell w-100 align-middle pl-2 pr-2"">
							<div class=""text-truncate text-truncate-md"">
								oliver.kopyuv");
            WriteLiteral(@"@gotbootstrap.com
								<small class=""d-block font-italic fs-xs"">
									Offline
								</small>
							</div>
						</div>
					</a>
				</li>
				<li>
					<a href=""#"" class=""d-table w-100 px-2 py-2 text-dark hover-white"" data-filter-tags=""ali amdaney busy"">
						<div class=""d-table-cell align-middle status status-danger status-sm"">
							<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-j.png'); background-size: cover;""></span>
						</div>
						<div class=""d-table-cell w-100 align-middle pl-2 pr-2"">
							<div class=""text-truncate text-truncate-md"">
								oliver.kopyuv");
            WriteLiteral(@"@gotbootstrap.com
								<small class=""d-block font-italic fs-xs text-danger"">
									Busy
								</small>
							</div>
						</div>
					</a>
				</li>
				<li>
					<a href=""#"" class=""d-table w-100 px-2 py-2 text-dark hover-white"" data-filter-tags=""ali amdaney offline"">
						<div class=""d-table-cell align-middle status status-sm"">
							<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-c.png'); background-size: cover;""></span>
						</div>
						<div class=""d-table-cell w-100 align-middle pl-2 pr-2"">
							<div class=""text-truncate text-truncate-md"">
								oliver.kopyuv");
            WriteLiteral(@"@gotbootstrap.com
								<small class=""d-block font-italic fs-xs"">
									Offline
								</small>
							</div>
						</div>
					</a>
				</li>
				<li>
					<a href=""#"" class=""d-table w-100 px-2 py-2 text-dark hover-white"" data-filter-tags=""ali amdaney inactive"">
						<div class=""d-table-cell align-middle"">
							<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-m.png'); background-size: cover;""></span>
						</div>
						<div class=""d-table-cell w-100 align-middle pl-2 pr-2"">
							<div class=""text-truncate text-truncate-md"">
								+714651347790
								<small class=""d-block font-italic fs-xs opacity-50"">
									Missed Call 
								</small>
							</div>
						</div>
					</a>
				</li>
			</ul>
			<div class=""filter-message js-filter-message""></div>
		</div>
	</div>
	<div>
		<a class=""fs-xl d-flex align-items-center p-3"">
			<i");
            BeginWriteAttribute("class", " class=\"", 6564, "\"", 6608, 2);
#nullable restore
#line 152 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_TabMsgr.cshtml"
WriteAttributeValue("", 6572, Settings.Theme.IconPrefix, 6572, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6600, "fa-cogs", 6601, 8, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
		</a>
	</div>
</div>
<div class=""msgr d-flex h-100 flex-column bg-white"">
	<div class=""custom-scroll flex-1 h-100"">
		<div id=""chat_container"" class=""w-100 p-4"">
			<div class=""chat-segment"">
				<div class=""time-stamp text-center mb-2 fw-400"">
					Jun 19
				</div>
			</div>
			<div class=""chat-segment chat-segment-sent"">
				<div class=""chat-message"">
					<p>
						Hey Tracey, did you get my files?
					</p>
				</div>
				<div class=""text-right fw-300 text-muted mt-1 fs-xs"">
					3:00 pm
				</div>
			</div>
			<div class=""chat-segment chat-segment-get"">
				<div class=""chat-message"">
					<p>
						Hi
					</p>
					<p>
						Sorry going through a busy time in office. Yes I analyzed the solution. 
					</p>
					<p>
						It will require some resource, which I could not manage.
					</p>
				</div>
				<div class=""fw-300 text-muted mt-1 fs-xs"">
					3:24 pm
				</div>
			</div>
			<div class=""chat-segment chat-segment-sent chat-start"">
				<div class=""chat-message"">
					<p>
						Okay
					</p>
");
            WriteLiteral(@"				</div>
			</div>
			<div class=""chat-segment chat-segment-sent chat-end"">
				<div class=""chat-message"">
					<p>
						Sending you some dough today, you can allocate the resources to this project.
					</p>
				</div>
				<div class=""text-right fw-300 text-muted mt-1 fs-xs"">
					3:26 pm
				</div>
			</div>
			<div class=""chat-segment chat-segment-get chat-start"">
				<div class=""chat-message"">
					<p>
						Perfect. Thanks a lot!
					</p>
				</div>
			</div>
			<div class=""chat-segment chat-segment-get"">
				<div class=""chat-message"">
					<p>
						I will have them ready by tonight.
					</p>
				</div>
			</div>
			<div class=""chat-segment chat-segment-get chat-end"">
				<div class=""chat-message"">
					<p>
						Cheers
					</p>
				</div>
			</div>
			<div class=""chat-segment"">
				<div class=""time-stamp text-center mb-2 fw-400"">
					Jun 20
				</div>
			</div>
		</div>
	</div>
	<div class=""d-flex flex-column"">
		<div class=""border-faded border-right-0 border-bottom-0 border-left-0 flex-1 mr-3 m");
            WriteLiteral(@"l-3 position-relative shadow-top"">
			<div class=""pt-3 pb-1 pr-0 pl-0 rounded-0"" tabindex=""-1"">
				<div id=""msgr_input"" contenteditable=""true"" data-placeholder=""Type your message here..."" class=""height-10 form-content-editable""></div>
			</div>
		</div>
		<div class=""height-8 px-3 d-flex flex-row align-items-center flex-wrap flex-shrink-0"">
			<a href=""javascript:void(0);"" class=""btn btn-icon fs-xl width-1 mr-1"" data-toggle=""tooltip"" data-original-title=""More options"" data-placement=""top"">
				<i");
            BeginWriteAttribute("class", " class=\"", 9159, "\"", 9230, 3);
#nullable restore
#line 243 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_TabMsgr.cshtml"
WriteAttributeValue("", 9167, Settings.Theme.IconPrefix, 9167, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 9195, "fa-ellipsis-v-alt", 9196, 18, true);
            WriteAttributeValue(" ", 9213, "color-fusion-300", 9214, 17, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n\t\t\t</a>\n\t\t\t<a href=\"javascript:void(0);\" class=\"btn btn-icon fs-xl mr-1\" data-toggle=\"tooltip\" data-original-title=\"Attach files\" data-placement=\"top\">\n\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 9395, "\"", 9461, 3);
#nullable restore
#line 246 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_TabMsgr.cshtml"
WriteAttributeValue("", 9403, Settings.Theme.IconPrefix, 9403, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 9431, "fa-paperclip", 9432, 13, true);
            WriteAttributeValue(" ", 9444, "color-fusion-300", 9445, 17, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n\t\t\t</a>\n\t\t\t<a href=\"javascript:void(0);\" class=\"btn btn-icon fs-xl mr-1\" data-toggle=\"tooltip\" data-original-title=\"Insert photo\" data-placement=\"top\">\n\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 9626, "\"", 9689, 3);
#nullable restore
#line 249 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\Shared\_TabMsgr.cshtml"
WriteAttributeValue("", 9634, Settings.Theme.IconPrefix, 9634, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 9662, "fa-camera", 9663, 10, true);
            WriteAttributeValue(" ", 9672, "color-fusion-300", 9673, 17, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n\t\t\t</a>\n\t\t\t<div class=\"ml-auto\">\n\t\t\t\t<a href=\"javascript:void(0);\" class=\"btn btn-info\">Send</a>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n</div>\n");
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
