#pragma checksum "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80a3cdc04cce6d0ebde2e4107915ec483d6b37ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AspNetCore_Interactive), @"mvc.1.0.view", @"/Views/AspNetCore/Interactive.cshtml")]
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
#nullable restore
#line 1 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
using SmartAdmin.WebUI.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
using SmartAdmin.WebUI.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a3cdc04cce6d0ebde2e4107915ec483d6b37ad", @"/Views/AspNetCore/Interactive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"533704a18c71ad5063d23e62fe4a94370682f53f", @"/Views/_ViewImports.cshtml")]
    public class Views_AspNetCore_Interactive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/account/logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/account/login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
  
    ViewData["Title"] = "Interactive Instructions";
    ViewData["PageName"] = "aspnetcore_interactive";
    ViewData["Heading"] = "<i class='fal fa-tools'></i> Interactive: <span class='fw-300'>Modifying the Project</span>";
    var roleName = User.FindFirst(ClaimTypes.Role)?.Value ?? "Guest";
    var returnUrl = new Dictionary<string, string> { { "returnUrl", Url.Action("Interactive", "AspNetCore") } };
    var dbVersion = DbContext.Database.ProviderName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\r\n    <!-- // Note if you wish to use Blazor in other pages of this Project then please move the base element to the _Layout.cshtml file. -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80a3cdc04cce6d0ebde2e4107915ec483d6b37ad6689", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-12"">
        <div class=""panel"">
            <div class=""panel-container show"">
                <div class=""panel-content"">
                    The instructions below are <strong>interactive</strong>, this means that they are built with coding logic enabled that responds to the purpose of the instruction.
                    We hope this approach can assist you with ensuring that the instruction has been carried out correctly and therefor acts as a confirmation when you followed the lesson correctly!
                    So please give them a try!
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-xl-12"">
        <div class=""panel"">
            <div class=""panel-hdr"">
                <h2>Enable Authorization on the Navigation Menu</h2>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content"">
                    <section>
          ");
            WriteLiteral(@"              <ol class=""list-spaced"">
                            <li>
                                Navigate to the folder containing the extracted project package and double-click the <code>SmartAdminCore.sln</code> file
                            </li>
                            <li>
                                Once the solution has finished loading open the <code>nav.json</code> file in the root of the project
                            </li>
                            <li>
                                Scroll down to about <code>Line 141</code> to find the <strong>Tools & Components</strong> menu item
                            </li>
                            <li>
                                You should see a new property that was added in this release to the menu item called <code>roles</code>:
                                <pre class=""prettyprint lang-js mb-0 mt-2"">&quot;roles&quot;: [ &quot;Administrator&quot; ]</pre>
                            </li>
               ");
            WriteLiteral(@"             <li>As you can see we have added an extra instruction that this menu item should only be visible for <strong>Administrators</strong></li>
                            <li>
                                So let's check this now, it seems that you are currently logged in as the <code>");
#nullable restore
#line 58 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
                                                                                                           Write(roleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code> role\r\n");
#nullable restore
#line 59 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
                                 if (User.IsInRole("Administrator"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""alert alert-success mb-0 mt-1 p-1"">
                                        Hurray! You already have the correct role!
                                        Did you want to test it as <strong>Guest</strong> first?
                                        You can logout by clicking here: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a3cdc04cce6d0ebde2e4107915ec483d6b37ad11344", async() => {
                WriteLiteral("Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 64 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = returnUrl;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 66 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"alert alert-warning mb-0 mt-1 p-1\">\r\n                                        This means you are currently not logged in!\r\n                                        Let\'s fix that by clicking here: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a3cdc04cce6d0ebde2e4107915ec483d6b37ad13872", async() => {
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 71 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = returnUrl;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""alert alert-info mb-0 mt-1 p-1"">
                                    As you might have noticed, the menu on the left may not have changed at all by logging in or viewing it as a <strong>Guest</strong>!
                                    This is because by default the Navigation is not enabled to be role aware, so let's change that!
                                </div>
                            </li>
                            <li>Open the <code>Default.cshtml</code> file in the <strong>Views/Shared/Components/Navigation</strong> folder of your project</li>
                            <li>
                                With the file open goto around <code>Line 6</code> and you should see the following line of code:
                                <pre class=""prettyprint lang-csharp mb-0 mt-2"">");
            WriteLiteral(@"@foreach (var group in menu.Lists)</pre>
                            </li>
                            <li>
                                Change or Replace this line of code with the following line of code:
                                <pre class=""prettyprint lang-csharp mb-0 mt-2"">");
            WriteLiteral(@"@foreach (var group in menu.Lists.AuthorizeFor(User))</pre>
                                <div class=""alert alert-success mb-0 mt-1 p-1"">
                                    Authorization is now enabled and the <code>AuthorizeFor</code> extension method will verify the user role with that of the menu item.
                                    If the menu item has no roles available it will be shown regardless of role.
                                </div>
                            </li>
                            <li>Now refresh this page and/or ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a3cdc04cce6d0ebde2e4107915ec483d6b37ad17867", async() => {
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 92 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = returnUrl;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" and you should see the menu change!</li>
                        </ol>
                    </section>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-xl-12"">
        <div class=""panel"">
            <div class=""panel-hdr"">
                <h2>Changing the default database from SQLite to SQL Server</h2>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content"">
                    <section>
                        <ol class=""list-spaced"">
                            <li>
                                Navigate to the folder containing the extracted project package and double-click the <code>SmartAdminCore.sln</code> file
                            </li>
                            <li>
                                Once the solution has finished loading open the <code>Startup.cs</code> file in the root of the project
                            </li>
                ");
            WriteLiteral(@"            <li>
                                With the file open goto around <code>Line 35</code> and you should see the following line of code:
                                <pre class=""prettyprint lang-csharp mb-0 mt-2"">services.AddDbContext&lt;ApplicationDbContext&gt;(options =&gt; options.UseSqlite(Configuration.GetConnectionString(&quot;DefaultConnection&quot;)));</pre>
                            </li>
                            <li>
                                Change or Replace this line of code with the following line of code:
                                <pre class=""prettyprint lang-csharp mb-0 mt-2"">services.AddDbContext&lt;ApplicationDbContext&gt;(options =&gt; options.UseSqlServer(Configuration.GetConnectionString(&quot;DefaultConnection&quot;)));</pre>
                            </li>
                            <li>
                                This will instruct Entity Framework to connect to a Microsoft SQL Server Database.
                                <div class=");
            WriteLiteral(@"""alert alert-warning mb-0 mt-1 p-1"">
                                    <strong>Note:</strong> You might get a warning or an error stating that <code>UseSqlServer</code> is not recognized, this means we will need to add a reference to the <strong>SqlServer</strong> NuGet package for Entity Framework Core
                                </div>
                            </li>
                            <li>Right click the <strong>SmartAdmin.WebUI</strong> project and choose the option: <code>Edit Project File</code></li>
                            <li>
                                With the file open goto around <code>Line 17</code> and you should see the following line of code:
                                <pre class=""prettyprint lang-xml mb-0 mt-2"">&lt;PackageReference Include=&quot;Microsoft.EntityFrameworkCore.Sqlite&quot; Version=&quot;3.1.2&quot; /&gt;</pre>
                            </li>
                            <li>
                                Change or Replace this line of");
            WriteLiteral(@" code with the following line of code:
                                <pre class=""prettyprint lang-xml mb-0 mt-2"">&lt;PackageReference Include=&quot;Microsoft.EntityFrameworkCore.SqlServer&quot; Version=&quot;3.1.2&quot; /&gt;</pre>
                                <div class=""alert alert-info mb-0 mt-1 p-1"">
                                    <strong>Note:</strong> You can also change the NuGet packages of your project by right-clicking the <strong>SmartAdminCore</strong> solution and choosing the option: <code>Manage NuGet Packages for Solution..</code>
                                </div>
                            </li>
                            <li>Last but not least we will need to modify the <strong>ConnectionString</strong> of the application to connect to your SQL Server instance</li>
                            <li>Open the <code>appsettings.json</code>file in the root of your project</li>
                            <li>
                                With the file open goto around ");
            WriteLiteral(@"<code>Line 3</code> and you should see the following line of code:
                                <pre class=""prettyprint lang-js mb-0 mt-2"">&quot;DefaultConnection&quot;: &quot;DataSource=app.db&quot;</pre>
                            </li>
                            <li>
                                Change or Replace this line of code with the following line of code:
                                <pre class=""prettyprint lang-js mb-0 mt-2"">&quot;DefaultConnection&quot;: &quot;Data Source=YourServerAddress;Initial Catalog=YourDatabase;User ID=YourUser;Password=YourPassword;Connect Timeout=20;ApplicationIntent=ReadWrite;MultipleActiveResultSets=true&quot;</pre>
                                <div class=""alert alert-danger mb-0 mt-1 p-1"">
                                    <strong>Note:</strong> Be sure to replace the <code>YourXxxx</code> values with the actual values of your SQL Server instance and credentials!
                                </div>
                            </li>
       ");
            WriteLiteral(@"                     <li>
                                In order to re-create the database schema in your new targeted database we will have to remove the <strong>Migrations</strong> folder from the project.
                                Once this has been done you can re-apply the new schema by typing the following:
                                <pre class=""prettyprint lang-js mb-0 mt-2"">Add-Migration InitialCreate</pre>
                                Followed by updating your targeted database, by typing the following:
                                <pre class=""prettyprint lang-js mb-0 mt-2"">Update-Database</pre>
                            </li>
                            <li>
                                Phew! That was quite the effort, so let's check the result: You are currently using <code>");
#nullable restore
#line 164 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
                                                                                                                     Write(dbVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code> as your data store.\r\n");
#nullable restore
#line 165 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
                                 if (dbVersion.Contains("Sqlite"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""alert alert-warning mb-0 mt-1 p-1"">
                                        It seems you are (still) using SQLite.<br/>
                                        Please follow the instructions above and refresh this page to see the result!
                                    </div>
");
#nullable restore
#line 171 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"alert alert-success mb-0 mt-1 p-1\">\r\n                                        Hurray! You have switched to SQL Server successfully!\r\n                                    </div>\r\n");
#nullable restore
#line 177 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </li>
                        </ol>
                    </section>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-xl-12"">
        <div class=""panel"">
            <div class=""panel-hdr"">
                <h2>Adding support for Blazor to the Project</h2>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content"">
                    <section>
                        <ol class=""list-spaced"">
                            <li>
                                Navigate to the folder containing the extracted project package and double-click the <code>SmartAdminCore.sln</code> file
                            </li>
                            <li>
                                Once the solution has finished loading open the <code>Startup.cs</code> file in the root of the project
                            </li>
                            <li>
     ");
            WriteLiteral(@"                           With the file open goto around <code>Line 48</code> and you should see the following line of code:
                                <pre class=""prettyprint lang-csharp mb-0 mt-2"">services.AddRazorPages();</pre>
                            </li>
                            <li>
                                Add the following line of code directly beneath:
                                <pre class=""prettyprint lang-csharp mb-0 mt-2"">services.AddServerSideBlazor();</pre>
                            </li>
                            <li>
                                Now goto around <code>Line 85</code> and you should see the following line of code:
                                <pre class=""prettyprint lang-csharp mb-0 mt-2"">endpoints.MapRazorPages();</pre>
                            </li>
                            <li>
                                Add the following line of code directly beneath:
                                <pre class=""prettyprint lang-cshar");
            WriteLiteral(@"p mb-0 mt-2"">endpoints.MapBlazorHub();</pre>
                            </li>
                            <li>
                                This will instruct .NET to setup the Blazor Hub and establish a connection upon startup.
                                <div class=""alert alert-warning mb-0 mt-1 p-1"">
                                    <strong>Note:</strong> You might get a warning or an error stating that <code>No connection could be established</code>, this means that a plugin might be interfering with the definition of <strong>WebSocket</strong>.
                                </div>
                            </li>
                            <li>
                                Let's fix that error right-away! Open the <code>_ScriptBasePlugins.cshtml</code> file in the <strong>Views/Shared</strong> folder of the project
                            </li>
                            <li>
                                With the file open goto around <code>Line 2</code> and you shou");
            WriteLiteral(@"ld see the following line of code:
                                <pre class=""prettyprint lang-csharp mb-0 mt-2"">&lt;script src=&quot;~/js/app.bundle.js&quot;&gt;&lt;/script&gt;</pre>
                            </li>
                            <li>
                                Add the following lines of code directly beneath:
                                <pre class=""prettyprint lang-csharp mb-0 mt-2"">
&lt;script&gt;
    // this call is required to remap WebSocket as this is overridden by Pace.js plugin ! :-(
    Object.defineProperty(WebSocket, &#39;OPEN&#39;, { value: 1 });
&lt;/script&gt;
&lt;script src=&quot;~/_framework/blazor.server.js&quot;&gt;&lt;/script&gt;</pre>
                            </li>
                            <li>
                                This will enable the listener framework to be setup as such that the pages can ""communicate"" with your code.
                                <div class=""alert alert-info mb-0 mt-1 p-1"">
                                   ");
            WriteLiteral(@" <strong>Note:</strong> The <code>blazor.server.js</code> file is generated at <strong>runtime</strong>, as such it is not available on disk or in your project.
                                </div>
                            </li>
                            <li>
                                Now rebuild your project and launch it! If everything went well then the item below should show you the rendered contents
                                of the <code>HelloWorld.razor</code> file located in the <strong>Pages</strong> folder in the root of your Project; Blazor support should now be available in SmartAdmin!
                            </li>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80a3cdc04cce6d0ebde2e4107915ec483d6b37ad32791", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 251 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(HelloWorld);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 251 "C:\Users\adams\Desktop\development\SC\SmartAdminMVC\smartadmin-core-bare\src\SmartAdmin.WebUI\Views\AspNetCore\Interactive.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.ServerPrerendered;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </ol>\r\n                    </section>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext DbContext { get; private set; }
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