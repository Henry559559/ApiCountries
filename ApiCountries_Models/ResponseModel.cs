namespace ApiCountries_Models
{
    public class ResponseModel
    {
        public object Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public ResponseModel()
        {
            this.Success = false;
        }
    }
}
