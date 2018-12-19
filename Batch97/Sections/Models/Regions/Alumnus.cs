using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace JFA.Yearbook.Web.Sections.Models.Regions
{
    public class Alumnus
    {
        /// <summary>
        /// Gets/sets the optional photo image.
        /// </summary>
        [Field(Title = "Alumnus photo")]
        public ImageField Photo { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Firstname { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Middlename { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Lastname { get; set; }

        [Field]
        public TextField Ambition { get; set; }

    }
}