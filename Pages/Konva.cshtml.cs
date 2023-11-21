using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DnDAspNet.Pages
{
    public class KonvaModel : PageModel
    {
        private readonly ILogger<KonvaModel> _logger;

        public KonvaModel(ILogger<KonvaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}