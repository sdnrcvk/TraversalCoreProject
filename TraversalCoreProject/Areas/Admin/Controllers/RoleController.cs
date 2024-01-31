using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values=_roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel createRoleViewModel)
        {
            AppRole role = new AppRole()
            {
                Name = createRoleViewModel.RoleName
            };
            var result=await _roleManager.CreateAsync(role);
            if(result.Succeeded)
            {
                return RedirectToAction("Role","Admin");
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var value=_roleManager.Roles.FirstOrDefault(x=>x.Id==id);
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Role","Admin");
        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var value=_roleManager.Roles.FirstOrDefault(x=>x.Id== id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel()
            {
                RoleId = value.Id,
                RoleName = value.Name
            };

            return View(updateRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.RoleId);
            value.Name = updateRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Role", "Admin");
        }

    }
}
