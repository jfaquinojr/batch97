using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;

namespace JFA.Yearbook.Web.Sections.Models
{
    [PageType(Title = "Class Section page")]
    [PageTypeRoute(Title = "Section", Route = "/section")]
    public class SectionPage : Page<SectionPage>
    {
        /// <summary>
        /// Gets/sets the alumni.
        /// </summary>
        [Region(ListTitle = "Alumni")]
        public IList<Regions.Alumnus> Alumni { get; set; }


        [Region]
        public Regions.Section Section { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SectionPage()
        {
            Alumni = new List<Regions.Alumnus>();
        }
    }
}