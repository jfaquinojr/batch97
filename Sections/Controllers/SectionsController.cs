using System;
using Microsoft.AspNetCore.Mvc;
using Piranha;

namespace batch97.Sections.Controllers
{
    public class SectionsController: Controller
    {
        private readonly IApi _api;

        public SectionsController(IApi api)
        {
            _api = api;
        }

        public IActionResult Index()
        {
            var model = _api.Pages.GetAll<Models.SectionPage>();
            return View("~/Sections/Views/Sections/Index.cshtml", model);
        }
        
        public IActionResult Section(Guid id)
        {
            var model = _api.Pages.GetById<Models.SectionPage>(id);
            return View("~/Sections/Views/Sections/Section.cshtml", model);
        }
    }
}