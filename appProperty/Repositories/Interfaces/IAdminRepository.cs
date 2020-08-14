using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appProperty.Models;
using PropertyDB.Admin;
using PropertyDB.Building;

namespace appProperty.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        bool AuthenticateUser(LoginViewModel loginViewModel);
        int RegisterUser(UserViewModel userViewModel);
        CssUser GetUserByUserName(string userName);

        #region General
        int AddGeneral(GeneralViewModel model);
        bool UpdateGeneral(CssGeneral model);
        List<CssGeneral> GetGeneralList();
        CssGeneral GetGeneral(int code);
        bool DeleteGeneral(int code);
        List<CssGeneral> GetGeneralListByKind(string kindText);
        #endregion

        #region Kind
        List<CssKind> GetKindList();

        #endregion

        #region Address
        int AddAddress(AddressViewModel model);
        bool UpdateAddress(CssAddress model);
        List<CssAddress> GetAddressList();
        CssAddress GetAddress(int code);
        bool DeleteAddress(int code);
        #endregion

        #region Country
        List<CssCountry> GetCountryList();
        List<CssState> GetStatesByCountryCode(int countryCode);
        List<CssCity> GetCitiesByStateCode(int stateCode);
        #endregion


        #region OfferContext
        int AddOfferContext(OfferContextViewModel model);
        bool UpdateOfferContext(CssOfferContext model);
        List<CssOfferContext> GetOfferContextList();
        CssOfferContext GetOfferContext(int code);
        bool DeleteOfferContext(int code);
        #endregion
    }

}
