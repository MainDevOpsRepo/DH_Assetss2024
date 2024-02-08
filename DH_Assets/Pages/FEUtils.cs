namespace DH_Assets.Pages
{
    public class FEUtils
    {
        public int NotificationCount { get; set; }

        public void OnGet()
        {
            // Fetch the notification count from your data source
            NotificationCount = 5; // For example
        }
    }
}
