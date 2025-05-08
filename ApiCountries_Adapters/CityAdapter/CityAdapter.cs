using ApiCountries_Models;
using CountriesService;

namespace ApiCountries_Adapters.CityAdapter
{
    public class CityAdapter
    {
        private readonly ResponseModel _res = new();
        private readonly ServiceClient _countrySvc = new();

        public ResponseModel ReadAll()
        {
            _res.Data = _countrySvc.ReadCitiesAsync();
            _res.Success = true;
            _res.Message = "OK";
            return _res;
        }

        public ResponseModel Create(City model)
        {
            _res.Data = _countrySvc.CreateCitiesAsync(model);
            _res.Success = true;
            _res.Message = "OK";
            return _res;
        }
    }
}
