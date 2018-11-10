using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;

namespace batch97.Models
{
    [PageType(Title = "Class Section page")]
    [PageTypeRoute(Title = "Default", Route = "/class")]
    public class SectionPage : Page<SectionPage>
    {
        /// <summary>
        /// Gets/sets the page heading.
        /// </summary>
        [Region]
        public Regions.Heading Heading { get; set; }

        /// <summary>
        /// Gets/sets the available teasers.
        /// </summary>
        [Region(ListTitle = "Alumni")]
        public IList<Regions.Alumnus> Alumni { get; set; }


        [Region]
        public Regions.Section Section { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SectionPage() {
            Alumni = new List<Regions.Alumnus>();
        }
    }
}