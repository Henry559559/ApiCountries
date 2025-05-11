using ApiCountries_Models;
using CountriesService;

namespace ApiCountries_Adapters.DepartmentAdapter
{
    public class DepartmentAdapter
    {
        private readonly ResponseModel _res = new();
        private readonly ServiceClient _countrySvc = new();

        public ResponseModel ReadAll()
        {
            _res.Data = _countrySvc.ReadDepartmentsAsync();
            _res.Success = true;
            _res.Message = "OK";
            return _res;
        }

        public ResponseModel Create(Department model)
        {
            _res.Data = _countrySvc.CreateDepartmentsAsync(model);
            _res.Success = true;
            _res.Message = "OK";
            return _res;
        }

        public ResponseModel Update(Department model)
        {
            _res.Data = _countrySvc.UpdateDepartmentsAsync(model);
            _res.Success = true;
            _res.Message = "OK";
            return _res;
        }

        public ResponseModel Delete(short id)
        {
            _res.Data = _countrySvc.DeleteDepartmentAsync(id);
            _res.Success = true;
            _res.Message = "OK";
            return _res;
        }
    }
}
