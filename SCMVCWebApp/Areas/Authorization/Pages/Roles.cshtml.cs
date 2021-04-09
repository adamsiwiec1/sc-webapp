using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SCMVCWebApp.Areas.Authorization.Pages
{
    [Authorize]
    public class RoleModel : PageModel
    {
    }
}
