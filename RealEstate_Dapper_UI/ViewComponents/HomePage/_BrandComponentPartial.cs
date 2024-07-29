using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _BrandComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
