using System.ComponentModel.DataAnnotations;
using Ambev.DeveloperEvaluation.Domain.Common;

public class Sale : BaseEntity
{    
    public DateTime SaleDate { get; set; }

    public int CustomerId { get; set; }

    [Range(0, double.MaxValue)]
    public decimal TotalAmount { get; set; }

    public bool IsCancelled { get; set; }

    public List<SaleItem> Items { get; set; } = new();
}