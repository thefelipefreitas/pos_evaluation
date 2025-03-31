using System.ComponentModel.DataAnnotations;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Product : BaseEntity
{
    [MaxLength(255)]
    public string Title { get; set; } = string.Empty;

    [Range(0, double.MaxValue)]
    public decimal Price { get; set; }

    public string Description { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Image { get; set; } = string.Empty;

    public required Rating Rating { get; set; }
}

public class Rating
{
    [Range(0, 5)]
    public double Rate { get; set; }

    [Range(0, int.MaxValue)]
    public int Count { get; set; }
}
