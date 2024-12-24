using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.ComponentViewComponents
{
    public class _AddCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
