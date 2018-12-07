using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;

namespace batch97.Sections.Models.Regions
{
    public class Section
    {
        /// <summary>
        /// Gets/sets the optional photo image.
        /// </summary>
        [Field(Title = "Class photo")]
        public ImageField Photo { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Name { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Teacher { get; set; }

        public IList<Alumnus> Alumni { get; set; }

    }
}