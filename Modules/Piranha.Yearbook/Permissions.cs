using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JFA.Piranha.Yearbook
{
    public static class Permissions
    {
        public const string SectionList = "YearbookSectionList";
        public const string SectionAdd = "YearbookSectionAdd";
        public const string SectionEdit = "YearbookSectionEdit";
        public const string SectionDelete = "YearbookSectionDelete";
        public const string SectionSave = "YearbookSectionSave";

        public const string AlumnusList = "AlumnsList";
        public const string AlumnusAdd = "AlumnsAdd";
        public const string AlumnusEdit = "AlumnsEdit";
        public const string AlumnusDelete = "AlumnsDelete";
        public const string AlumnusSave = "AlumnsSave";

        public const string ListList = "ListList";
        public const string ListAdd = "ListAdd";
        public const string ListEdit = "ListEdit";
        public const string ListDelete = "ListDelete";
        public const string ListSave = "ListSave";
        public const string ListVote = "ListVote";

        public static string[] All()
        {
            return new string []
            {
                SectionAdd,
                SectionEdit,
                SectionDelete,
                SectionSave,
                AlumnusAdd,
                AlumnusEdit,
                AlumnusDelete,
                AlumnusSave,
                ListAdd,
                ListEdit,
                ListDelete,
                ListSave,
                ListVote
            };
        }
    }
}
