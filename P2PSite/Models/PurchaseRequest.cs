using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        public MaterialPreview[]? Materials { get; set; }
    }

    public class MaterialPreview
    {
        public int MaterialCode { get; set; }
        public string MaterialName { get; set; } = string.Empty;
        public float Quantity { get; set; }
    }

    public class Material
    {
        public int MaterialCode { get; set; }
        public string MaterialName { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Dimensions { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class PurchaseRequestMaterial
    {
        public Material? Material { get; set; }
        public float Quantity { get; set; }
    }
}
