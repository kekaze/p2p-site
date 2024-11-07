namespace P2PSite.Models
{
    public class PurchaseRequest
    {
        public int PurchaseId { get; set; }
        public string Purpose { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
