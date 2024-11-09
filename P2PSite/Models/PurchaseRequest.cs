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

    public class OnePurchaseRequest
    {
        public int PurchaseId { get; set; }
        public string Purpose { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string CompanyId { get; set; } = string.Empty;
        public string CompanyName { get; set;} = string.Empty;
        public Material[] Materials { get; set; }
    }

    public class Material
    {
        public int MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public float Quantity { get; set; }
    }
}
