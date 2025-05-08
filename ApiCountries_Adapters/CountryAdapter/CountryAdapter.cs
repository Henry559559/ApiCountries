using ApiCountries_Models;
using CountriesService;

namespace ApiCountries_Adapters.CountryAdapter
{

    public class CountryAdapter
    {
        private readonly ResponseModel _res = new();
        private readonly ServiceClient _countrySvc = new();

        public ResponseModel ReadAll()
        {
            _res.Data = _countrySvc.ReadCountriesAsync();
            _res.Success = true;
            _res.Message = "OK";
            return _res;
        }

        public ResponseModel Create(Country model)
        {
            _res.Data = _countrySvc.CreateCountriesAsync(model);
            _res.Success = true;
            _res.Message = "OK";
            return _res;
        }
    }
}
