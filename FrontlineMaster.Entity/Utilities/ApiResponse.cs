namespace FrontlineMaster.Entity.Utilities
{
    public class ApiResponse
    {
        public string Status { get; set; }
        public string Messsage { get; set; }
    }

    public enum Status
    {
        Success,
        Failed
    }
}
