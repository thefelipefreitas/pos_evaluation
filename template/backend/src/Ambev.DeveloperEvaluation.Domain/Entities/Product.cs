using System.ComponentModel.DataAnnotations;
using Ambev.DeveloperEvaluation.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Product : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string Description { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Image { get; set; } = string.Empty;

    public required Rating Rating { get; set; }

    public Guid RatingId { get; set; }
}

public class Rating
{
    public Guid Id { get; set; }

    [Range(0, 5)]
    public double Rate { get; set; }

    public int Count { get; set; }

    public required Product Product { get; set; }
}
