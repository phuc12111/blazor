namespace HoiSinh.Data
{
    public class HS
    {
        public string Code { get; set; }
        public string display { get; set; }
    }
    public class ApiResult<T>
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string Hints { get; set; }
        public T Value { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
