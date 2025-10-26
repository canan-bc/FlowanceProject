using System.Threading.Tasks;
using Azure.Identity;
using FlowanceProject.DtoLayer.Dtos.AppUserDtos;
using FlowanceProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.Models;

namespace FlowanceProject.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManeger;

        public RegisterController(UserManager<AppUser> userManeger)
        {
            _userManeger = userManeger;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = appUserRegisterDto.Username,
                    Name = appUserRegisterDto.Name,
                    Surname = appUserRegisterDto.Surname,
                    Email = appUserRegisterDto.Email
                };
                
                var result = await _userManeger.CreateAsync(appUser, appUserRegisterDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "ConfirmMail");
                }
                //else
                //{
                //    foreach (var error in result.Errors)
                //    {
                //        ModelState.AddModelError("", error.Description);
                //    }
                //}
            }
            return View();
        }

        /*There was an error running the selected code generator:
'The specified bootstrap version '3' is not valid. The valid options are '4, 5'.' 
        
        hatası alıyorum
        
       NOT! bootstrap 5 e  göre ayarladığım zamanda olmadı
        
        */
        
        
    }
}
