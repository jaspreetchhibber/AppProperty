using PropertyDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appProperty.Repositories.Interfaces;
using appProperty.Models;
using PropertyDB.Admin;
using Microsoft.Extensions.Logging;
using AutoMapper;
using PropertyDB.Building;

namespace appProperty.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
        private PropertyDBContext _context;
        private readonly ILogger<BuildingRepository> _logger;
        private IMapper _mapper;

        public BuildingRepository(PropertyDBContext context, ILogger<BuildingRepository> logger)
        {
            _context = context;
            _logger = logger;
            //Auto Mapper Configuration
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BuildingPropertyViewModel, CssBuilding>();
            });
            _mapper = config.CreateMapper();

        }

        #region Unit

        /// <summary>
        /// AddUnit: It is used to Add Unit to Database
        /// </summary>
        public int AddUnit(CssUnit model)
        {
            try
            {
                var result = _context.Unit.Add(model);
                _context.SaveChanges();
                return result.Entity.Code;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// UpdateUnit: It is used to Update Unit
        /// </summary>
        public bool UpdateUnit(CssUnit model)
        {
            try
            {
                var result = _context.Unit.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// GetUnitList: It is used to Get Unit List
        /// </summary>
        public List<CssUnit> GetUnitList()
        {
            try
            {
                var result = _context.Unit.ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// GetUnit: It is used to Get Unit By Id
        /// </summary>
        public CssUnit GetUnit(int code)
        {
            try
            {
                var result = _context.Unit.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// DeleteUnit: It is used to Delete Unit By Id
        /// </summary>
        public bool DeleteUnit(int code)
        {
            try
            {
                var result = _context.Unit.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.Unit.Remove(result);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// ChangeStatus: It is used to Change Unit Status
        /// </summary>
        public bool ChangeUnitStatus(UnitInOutModel unitInOutModel)
        {
            var general = _context.General.Where(x => x.Code == unitInOutModel.StatusCode).FirstOrDefault();
            var unit = _context.Unit.Where(x => x.Code == unitInOutModel.UnitCode).FirstOrDefault();
            unit.Status = general;
            bool unitresult = UpdateUnit(unit);
            if (unitresult == true)
            {
                CssUnitInOut cssUnitInOut = new CssUnitInOut();
                cssUnitInOut.UnitCode = unit;
                cssUnitInOut.StartDate = DateTime.Now;
                cssUnitInOut.StartTime = DateTime.Now;
                //cssUnitInOut.EndTime = DateTime.Now;
                //cssUnitInOut.PeriodTime =;
                //cssUnitInOut.Plate;
                var user = _context.User.Where(x => x.Code == unitInOutModel.UserCode).FirstOrDefault();
                if (user != null)
                {
                    cssUnitInOut.User = user;
                }
                int result = AddUnitInOut(cssUnitInOut);
                if (result != 0)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region UnitHas

        /// <summary>
        /// AddUnitHas: It is used to Add UnitHas to Database
        /// </summary>
        public int AddUnitHas(CssUnitHas model)
        {
            try
            {
                var result = _context.UnitHas.Add(model);
                _context.SaveChanges();
                return result.Entity.Code;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// UpdateUnitHas: It is used to Update UnitHas
        /// </summary>
        public bool UpdateUnitHas(CssUnitHas model)
        {
            try
            {
                var result = _context.UnitHas.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// GetUnitHasList: It is used to Get UnitHas List
        /// </summary>
        public List<CssUnitHas> GetUnitHasList()
        {
            try
            {
                var result = _context.UnitHas.ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// GetUnitHas: It is used to Get UnitHas By Id
        /// </summary>
        public CssUnitHas GetUnitHas(int code)
        {
            try
            {
                var result = _context.UnitHas.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// DeleteUnitHas: It is used to Delete UnitHas By Id
        /// </summary>
        public bool DeleteUnitHas(int code)
        {
            try
            {
                var result = _context.UnitHas.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.UnitHas.Remove(result);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        /// <summary>
        /// GetAvailableUnitList: It is used to Get availble Unit List
        /// </summary>
        public List<CssUnit> GetAvailableUnitList(int buildingCode)
        {
            try
            {
                var building = GetBuilding(buildingCode);
                if (building.Units != null)
                {
                    List<CssUnit> unitList = new List<CssUnit>();
                    foreach (var unit in building.Units)
                    {
                        var result = (from u in _context.Unit
                                      join g in _context.General on u.Status.Code equals g.Code
                                      where u.Code == unit.Code
                                      select new CssUnit
                                      {
                                          Code = u.Code,
                                          Description = u.Description,
                                          Level = u.Level,
                                          LotSize = u.LotSize,
                                          RentalAmount = u.RentalAmount,
                                          SquareFoot = u.SquareFoot,
                                          Status = g,
                                          UnitNumber = u.UnitNumber,
                                          CssBuildingCode = u.CssBuildingCode
                                      }).FirstOrDefault();
                        unitList.Add(result);
                    }
                    return unitList;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion

        #region Amenities

        /// <summary>
        /// AddAmenities: It is used to Add Amenities to Database
        /// </summary>
        public int AddAmenities(CssAmenities model)
        {
            try
            {
                var result = _context.Amenities.Add(model);
                _context.SaveChanges();
                return result.Entity.Code;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// UpdateAmenities: It is used to Update Amenities
        /// </summary>
        public bool UpdateAmenities(CssAmenities model)
        {
            try
            {
                var result = _context.Amenities.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// GetAmenitiesList: It is used to Get Amenities List
        /// </summary>
        public List<CssAmenities> GetAmenitiesList()
        {
            try
            {
                var result = _context.Amenities.ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// GetAmenities: It is used to Get Amenities By Id
        /// </summary>
        public CssAmenities GetAmenities(int code)
        {
            try
            {
                var result = _context.Amenities.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// DeleteAmenities: It is used to Delete Amenities By Id
        /// </summary>
        public bool DeleteAmenities(int code)
        {
            try
            {
                var result = _context.Amenities.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.Amenities.Remove(result);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// GetAmenitiesByUnitCode: It is used to Get Amenites by UnitCode
        /// </summary>
        public List<CssAmenities> GetAmenitiesByUnitCode(int unitCode)
        {
            try
            {
                var amenities = (from a in _context.Amenities
                                 join g in _context.General on a.KindAmenities.Code equals g.Code
                                 join k in _context.Kind on g.Kind.Code equals k.Code
                                 where a.CssUnitCode == unitCode
                                 select new CssAmenities
                                 {
                                     Code = a.Code,
                                     KindAmenities = new CssGeneral { Code = g.Code, Kind = k, Description = g.Description, DependsOn = g.DependsOn, Start = g.Start, End = g.End, Used = g.Used },
                                     Description = a.Description,
                                     Status = g,
                                     CssUnitCode = unitCode
                                 }).ToList();
                return amenities;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Building

        /// <summary>
        /// AddAmenities: It is used to Add Building to Database
        /// </summary>
        public int AddBuilding(BuildingPropertyViewModel model)
        {
            try
            {
                var building = _mapper.Map<CssBuilding>(model);
                var general = _context.General.Where(x => x.Code == model.BuldingTypeCode).FirstOrDefault();
                building.BuldingType = general;
                if (model.CityCode != 0)
                {
                    var city = _context.City.Where(x => x.Code == model.CityCode).FirstOrDefault();
                    CssAddress address = new CssAddress { Address = model.AddressValue, City = city };
                    var addressresult = _context.Address.Add(address);
                    _context.SaveChanges();
                    address.Code = addressresult.Entity.Code;
                    building.Address = address;
                }
                var phone = _context.Phone.Where(x => x.Code == model.PhoneCode).FirstOrDefault();
                building.Phone = phone;

                List<CssUnit> unitList = new List<CssUnit>();
                if (model.Amenities.Length > 0)
                {
                    foreach (string amenityarray in model.Amenities)
                    {
                        var arrayelements = amenityarray.Split(',');
                        foreach (var amenity in arrayelements)
                        {
                            // Get element, and print index and element value.
                            //string amenity = model.Amenities[i];
                            var amenities = _context.Amenities.Where(x => x.Code == Convert.ToInt32(amenity)).FirstOrDefault();
                            var unit = _context.Unit.Where(x => x.Code == amenities.CssUnitCode).FirstOrDefault();
                            unitList.Add(unit);
                        }
                    }
                }
                building.Units = unitList;
                var result = _context.Building.Add(building);
                _context.SaveChanges();
                return result.Entity.Code;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// UpdateBuilding: It is used to Update Building
        /// </summary>
        public bool UpdateBuilding(CssBuilding model)
        {
            try
            {
                var result = _context.Building.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// GetBuildingList: It is used to Get Building List
        /// </summary>
        public List<CssBuilding> GetBuildingList()
        {
            try
            {
                var result = _context.Building.ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// GetBuilding: It is used to Get Building By Id
        /// </summary>
        public CssBuilding GetBuilding(int code)
        {
            try
            {
                var result = _context.Building.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// DeleteBuilding: It is used to Delete Building By Id
        /// </summary>
        public bool DeleteBuilding(int code)
        {
            try
            {
                var result = _context.Building.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.Building.Remove(result);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Section
        /// <summary>
        /// GetSectionListByBuildingCode: It is used to Get Building List by Building Code
        /// </summary>
        public List<CssSection> GetSectionListByBuildingCode(int buildingCode)
        {
            try
            {
                var result = _context.Section.Where(x => x.Building.Code == buildingCode).ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region UnitInOut
        /// <summary>
        /// AddUnitInOut: It is used to Change Unit status to Database
        /// </summary>
        public int AddUnitInOut(CssUnitInOut model)
        {
            try
            {
                var result = _context.UnitInOut.Add(model);
                _context.SaveChanges();
                return result.Entity.Code;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        #endregion
    }
}
