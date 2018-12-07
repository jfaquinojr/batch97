using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;

namespace batch97.Sections.Models
{
    [PageType(Title = "Sections List page")]
    [PageTypeRoute(Title = "Default", Route = "/sections")]
    public class SectionListPage : Page<SectionListPage>
    {
        [Region]
        public IList<Regions.Section> Sections { get; set; }
        public SectionListPage()
        {
            Sections = new List<Regions.Section>();
        }
    }
}