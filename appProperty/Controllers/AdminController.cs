using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using appProperty.Models;
using appProperty.Repositories.Interfaces;
using PropertyDB.Admin;

namespace appProperty.Controllers
{
    public class AdminController : Controller
    {
        private IAdminRepository _adminRepository;
        public AdminController(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = _adminRepository.AuthenticateUser(loginViewModel);
                if (result == true)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = _adminRepository.RegisterUser(userViewModel);
            }
            return RedirectToAction("Login");
        }

        public IActionResult General()
        {
            ViewBag.Kind = _adminRepository.GetKindList();
            return View();
        }

        [HttpPost]
        public IActionResult General(GeneralViewModel generalViewModel)
        {
            ViewBag.Kind = _adminRepository.GetKindList();
            var result = _adminRepository.AddGeneral(generalViewModel);
            ModelState.Clear();
            return View();
        }
        public IActionResult AddAddress()
        {
            ViewBag.CountryList = _adminRepository.GetCountryList();
            return View();
        }
        [HttpPost]
        public IActionResult AddAddress(AddressViewModel addressViewModel)
        {
            ViewBag.CountryList = _adminRepository.GetCountryList();
            var result = _adminRepository.AddAddress(addressViewModel);
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public JsonResult GetStatesByCountryCode(int countryCode)
        {
            var states = _adminRepository.GetStatesByCountryCode(countryCode);
            if (states.Count > 0)
            {
                return new JsonResult(states);
            }
            return new JsonResult(null);
        }
    }
}