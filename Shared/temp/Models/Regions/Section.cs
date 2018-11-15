using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace batch97.Models.Regions
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

    }
}