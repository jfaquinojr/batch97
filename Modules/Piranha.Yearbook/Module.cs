using Piranha.Extend;
using Piranha.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JFA.Piranha.Yearbook
{
    public class Module : IModule
    {

        private readonly List<PermissionItem> _permissions = new List<PermissionItem>() {

            new PermissionItem { Name = Permissions.SectionList, Title = "List Sections", Category = "Sections"},
            new PermissionItem { Name = Permissions.SectionAdd, Title = "Add Sections", Category = "Sections" },
            new PermissionItem { Name = Permissions.SectionDelete, Title = "Delete Sections", Category = "Sections" },
            new PermissionItem { Name = Permissions.SectionEdit, Title = "Edit Sections", Category = "Sections" },
            new PermissionItem { Name = Permissions.SectionSave, Title = "Save Sections", Category = "Sections" },

            new PermissionItem { Name = Permissions.AlumnusList, Title = "List Alumnus", Category = "Alumnus"},
            new PermissionItem { Name = Permissions.AlumnusAdd, Title = "Add Alumnus", Category = "Alumnus"},
            new PermissionItem { Name = Permissions.AlumnusEdit, Title = "Edit Alumnus", Category = "Alumnus"},
            new PermissionItem { Name = Permissions.AlumnusSave, Title = "Save Alumnus", Category = "Alumnus"},
            new PermissionItem { Name = Permissions.AlumnusDelete, Title = "Delete Alumnus", Category = "Alumnus"},

            new PermissionItem { Name = Permissions.AlumnusList, Title = "List Alumnus", Category = "Alumnus"},
            new PermissionItem { Name = Permissions.AlumnusAdd, Title = "Add Alumnus", Category = "Alumnus"},
            new PermissionItem { Name = Permissions.AlumnusEdit, Title = "Edit Alumnus", Category = "Alumnus"},
            new PermissionItem { Name = Permissions.AlumnusSave, Title = "Save Alumnus", Category = "Alumnus"},
            new PermissionItem { Name = Permissions.AlumnusDelete, Title = "Delete Alumnus", Category = "Alumnus"},
            
            //new PermissionItem { Name = Permissions.Roles, Title = "List Roles", Category = "Roles"},
            //new PermissionItem { Name = Permissions.RolesAdd, Title = "Add Roles", Category = "Roles" },
            //new PermissionItem { Name = Permissions.RolesDelete, Title = "Delete Roles", Category = "Roles" },
            //new PermissionItem { Name = Permissions.RolesEdit, Title = "Edit Roles", Category = "Roles" },
            //new PermissionItem { Name = Permissions.RolesSave, Title = "Save Roles", Category = "Roles" },
            //new PermissionItem { Name = Permissions.Users, Title = "List Users", Category = "Users" },
            //new PermissionItem { Name = Permissions.UsersAdd, Title = "Add Users", Category = "Users" },
            //new PermissionItem { Name = Permissions.UsersDelete, Title = "Delete Users", Category = "Users" },
            //new PermissionItem { Name = Permissions.UsersEdit, Title = "Edit Users", Category = "Users" },
            //new PermissionItem { Name = Permissions.UsersSave, Title = "Save Users", Category = "Users" }
        };

        public string Author => "Jojo Aquino";

        public string Name => "Batch97";

        public string Version => "0.0.1";

        public string ReleaseDate => "2018-12-17";

        public string Description => "Yearbook Module for Batch97";

        public string PackageURL => "";

        public void Init()
        {
            
        }
    }
}
