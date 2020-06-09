using Microsoft.AspNetCore.Components;

namespace BugTrackerBlazor.Shared
{
    public class NavMenuBase : ComponentBase
    {
        public bool collapseNavMenu = true;

        public string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        public void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}
