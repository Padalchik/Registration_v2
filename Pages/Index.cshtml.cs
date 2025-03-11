using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Registration_v2.Entity;

namespace Registration_v2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<CustomUser> _userManager;

        public IndexModel(UserManager<CustomUser> userManager)
        {
            _userManager = userManager;
        }

        public List<CustomUser> Users { get; set; }
        public void OnGet()
        {
            Users = _userManager.Users.ToList();
        }
    }
}
