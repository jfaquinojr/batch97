using System.Collections.Generic;

namespace JFA.Yearbook.Web.Sections.Models.Regions
{
    public class Section
    {
        /// <summary>
        /// Gets/sets the optional photo image.
        /// </summary>
        public byte[] Photo { get; set; }

        public string Name { get; set; }

        public string Teacher { get; set; }

        public IList<Alumnus> Alumni { get; set; }

    }
}