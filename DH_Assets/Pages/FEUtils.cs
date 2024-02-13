using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json.Nodes;

namespace DH_Assets.Pages
{
    public class FEUtils : PageModel
    {
        public object? NotificationCount { get; set; }

        public void OnGet()
        {
            // Fetch the notification count from your data source
            NotificationCount = null;
        }
        public object? NotificationGrid { get; set; }
        public void OnPost()
        {
            // Create grid view for notifications page 
            NotificationGrid = null;
        }
    }
}
