using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appProperty.Models;
using appProperty.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyDB.Building;

namespace appProperty.Controllers
{
    public class BuildingController : Controller
    {
        private IBuildingRepository _buildingRepository;
        private IAdminRepository _adminRepository;
        public BuildingController(IBuildingRepository buildingRepository,
            IAdminRepository adminRepository)
        {
            _buildingRepository = buildingRepository;
            _adminRepository = adminRepository;
        }

        [HttpPost]
        public JsonResult Login([FromBody] LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = _adminRepository.AuthenticateUser(loginViewModel);
                if (result == true)
                {
                    return Json(new { result = result });
                }
                else
                {
                    var error = "Invalid login attempt.";
                    return Json(new { error = error });
                }
            }
            return new JsonResult(null);
        }

        public IActionResult AddBuildingProperty()
        {
            ViewBag.GeneralList = _adminRepository.GetGeneralList();
            ViewBag.CountryList = _adminRepository.GetCountryList();
            ViewBag.UnitList = _buildingRepository.GetUnitList();
            return View();
        }
        [HttpPost]
        public IActionResult AddBuildingProperty(BuildingPropertyViewModel buildingPropertyViewModel)
        {
            ViewBag.GeneralList = _adminRepository.GetGeneralList();
            ViewBag.CountryList = _adminRepository.GetCountryList();
            ViewBag.UnitList = _buildingRepository.GetUnitList();
            var result = _buildingRepository.AddBuilding(buildingPropertyViewModel);
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public JsonResult GetStatesByCountryCode(int country)
        {

            var states = _adminRepository.GetStatesByCountryCode(country);
            if (states.Count > 0)
            {
                return new JsonResult(states);
            }
            return new JsonResult(null);
        }
        [HttpGet]
        public JsonResult GetCitiesByStateCode(int state)
        {

            var cities = _adminRepository.GetCitiesByStateCode(state);
            if (cities.Count > 0)
            {
                return new JsonResult(cities);
            }
            return new JsonResult(null);
        }

        [HttpGet]
        public JsonResult GetAmenitiesByUnitCode(int unitcode)
        {
            var amentities = _buildingRepository.GetAmenitiesByUnitCode(unitcode);
            if (amentities.Count > 0)
            {
                return new JsonResult(amentities);
            }
            return new JsonResult(null);
        }

        public IActionResult UnitStatus(int buildingCode)
        {
            ViewBag.SectionList = _buildingRepository.GetSectionListByBuildingCode(buildingCode);
            ViewBag.AvailableUnitList = _buildingRepository.GetAvailableUnitList(buildingCode);
            ViewBag.StatusList = _adminRepository.GetGeneralListByKind("Amenities Status");
            return View();
        }

        [HttpPost]
        public IActionResult UnitStatus(UnitInOutModel unitInOutModel)
        {
            var result = _buildingRepository.ChangeUnitStatus(unitInOutModel);
            if (result == true)
            {
                //return Json(new { result = result });
            }
            return View();
        }

        public IActionResult Unit(int buildingCode)
        {
            ViewBag.SectionList = _buildingRepository.GetSectionListByBuildingCode(buildingCode);
            return View();
        }

        [HttpPost]
        public IActionResult Unit(CssUnit model)
        {
            return View();
        }
    }
}