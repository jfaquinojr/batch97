using System;
using Microsoft.AspNetCore.Mvc;

namespace JFA.Yearbook.Web.Sections.Controllers
{
    public class SectionsController: Controller
    {

        public SectionsController()
        {
        }

        public IActionResult Index()
        {
            //var model = _api.Pages.GetAll<Models.SectionPage>();
            return View("~/Sections/Views/Sections/Index.cshtml");
        }
        
        public IActionResult Section(Guid id)
        {
            //var model = _api.Pages.GetById<Models.SectionPage>(id);
            return View("~/Sections/Views/Sections/Section.cshtml");
        }
        
        public IActionResult Create()
        {
            return View("~/Sections/Views/Sections/Section.cshtml");
        }
    }
}