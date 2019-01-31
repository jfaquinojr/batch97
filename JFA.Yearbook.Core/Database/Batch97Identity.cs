//using Microsoft.AspNetCore.Identity;
//using Piranha.AspNetCore.Identity;
//using Piranha.AspNetCore.Identity.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Pirhana = Piranha.AspNetCore.Identity;
//
//namespace JFA.Yearbook.Web.Users
//{
//    public class Batch97Identity : IIdentitySeed
//    {
//        private readonly IDb _db;
//        private readonly UserManager<Pirhana.Data.User> _userManager;
//        private readonly RoleManager<Pirhana.Data.Role> _roleManager;
//
//        public Batch97Identity(IDb db, UserManager<Pirhana.Data.User> userManager, RoleManager<Pirhana.Data.Role> roleManager)
//        {
//            _db = db;
//            _userManager = userManager;
//            _roleManager = roleManager;
//        }
//        public async Task CreateAsync()
//        {
//            if (_db.Users.Count() == 0)
//            {
//                var user = new Pirhana.Data.User
//                {
//                    UserName = "admin",
//                    Email = "jfaquinojr@gmail.com",
//                    SecurityStamp = Guid.NewGuid().ToString()
//                };
//                var createResult = await _userManager.CreateAsync(user, "password");
//
//                if (createResult.Succeeded)
//                {
//                    await _userManager.AddToRoleAsync(user, "SysAdmin");
//                }
//            }
//
//            await AddRole("BatchMate");
//            await AddRole("BatchOfficer");
//        }
//
//        private async Task AddRole(string roleBatchMate)
//        {
//            if (!_db.Roles.Any(r => r.Name == roleBatchMate))
//            {
//                await _roleManager.CreateAsync(new Role
//                {
//                    Id = Guid.NewGuid(),
//                    Name = roleBatchMate
//                });
//            }
//        }
//    }
//}
