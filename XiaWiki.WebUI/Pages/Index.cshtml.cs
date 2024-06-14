using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XiaWiki.Core.Repositories;
using XiaWiki.WebUI.Models;

namespace XiaWiki.WebUI.Pages;

public class IndexModel(IPageRepository pageRepository) : PageModel
{
    public SideNav SideNav { get; set; } = new SideNav([], "");

    public TopNav TopNav { get; set; } = new TopNav([]);

    public void OnGet()
    {
        var allPages = pageRepository.GetAll();

        SideNav = new SideNav(allPages.Adapt<IEnumerable<SideNavItem>>(), "");
    }
}
