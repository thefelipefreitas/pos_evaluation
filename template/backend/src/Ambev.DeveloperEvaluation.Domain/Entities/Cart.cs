using System.ComponentModel.DataAnnotations;
using Ambev.DeveloperEvaluation.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Cart : BaseEntity
{
    public string Date { get; set; } = string.Empty;

    public Guid UserId { get; set; }

    public required User User { get; set; }

    public required List<Product> Products { get; set; }
}
