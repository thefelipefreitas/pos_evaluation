using System.ComponentModel.DataAnnotations;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Sale : BaseEntity
{
    public DateTime SaleDate { get; set; } = DateTime.UtcNow;

    public int CustomerId { get; set; }

    [Range(0, double.MaxValue)]
    public decimal TotalAmount { get; set; }

    public bool IsCancelled { get; set; }

    public List<SaleItem> Items { get; set; } = new();
}
