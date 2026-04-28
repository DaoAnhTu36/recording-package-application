namespace SellerCenter.Infrastructure.Models
{
    public class EmployeeFacebookAppModel
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public long FacebookAppId { get; set; }
        public bool CanView { get; set; }
        public bool CanGetToken { get; set; }
        public bool CanPost { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public long? AssignedBy { get; set; }
    }
}