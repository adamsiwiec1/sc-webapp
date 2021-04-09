using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SCMVCWebApp.Models
{
    public class ViewBagFilter : IActionFilter
    {
        private static readonly string Enabled = "Enabled";
        private static readonly string Disabled = string.Empty;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.Controller is Controller controller)
            {
                // SCMVCWebAppToggle Features
                controller.ViewBag.AppSidebar = Enabled;
                controller.ViewBag.AppHeader = Enabled;
                controller.ViewBag.AppLayoutShortcut = Enabled;
                controller.ViewBag.AppFooter = Enabled;
                controller.ViewBag.ShortcutMenu = Enabled;
                controller.ViewBag.ChatInterface = Enabled;
                controller.ViewBag.LayoutSettings = Enabled;

                // SCMVCWebAppDefault Settings
                controller.ViewBag.App = "SCMVCWebApp";
                controller.ViewBag.AppName = "SCMVCWebAppWebApp";
                controller.ViewBag.AppFlavor = "ASP.NET Core 3.1";
                controller.ViewBag.AppFlavorSubscript = ".NET Core 3.1";
                controller.ViewBag.IconPrefix = "fal";
                controller.ViewBag.User = "Dr. Codex Lantern";
                controller.ViewBag.Email = "drlantern@gotbootstrap.com";
                controller.ViewBag.Twitter = "codexlantern";
                controller.ViewBag.Avatar = "avatar-admin.png";
                controller.ViewBag.Version = "4.2.0";
                controller.ViewBag.ThemeVersion = "4.4.2";
                controller.ViewBag.Bs4v = "4.3";
                controller.ViewBag.Logo = "logo.png";
                controller.ViewBag.LogoM = "logo.png";
                controller.ViewBag.Copyright = "2020 © SCMVCWebAppfor ASP.NET Core 3.1 by&nbsp;<a href='https://wrapbootstrap.com/theme/SCMVCWebAppasp.net-core-responsive-webapp-WB073L89G?ref=Walapa' class='text-primary fw-500' title='Walapa' target='_blank'>Walapa</a>";
                controller.ViewBag.CopyrightInverse = "2020 © SCMVCWebAppfor ASP.NET Core 3.1 by&nbsp;<a href='https://wrapbootstrap.com/theme/SCMVCWebAppasp.net-core-responsive-webapp-WB073L89G?ref=Walapa' class='text-white opacity-40 fw-500' title='Walapa' target='_blank'>Walapa</a>";
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
