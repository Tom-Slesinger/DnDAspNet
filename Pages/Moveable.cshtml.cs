using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DnDAspNet.Pages
{
    public class MoveableModel : PageModel
    {
        private readonly ILogger<MoveableModel> _logger;

        public MoveableModel(ILogger<MoveableModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}