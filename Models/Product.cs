using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;

namespace StoreApi.Models
{
	public class Product
	{
        [Key]
        public int ProductId { get; set; }  // Clave primaria
        [Required, StringLength(50)]
        public string? Name { get; set; }
        public decimal Price { get; set; }
        [StringLength(50)]
        public string? Descripcion { get; set; }
        public DateTime FechaExpiracion { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; } // Clave foránea de Category
        public Category? Category { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; } // Clave foránea de Supplier
        public Supplier? Supplier { get; set; }
        public int Estado { get; set; }
    }


public static class ProductEndpoints
{
	public static void MapProductEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Product").WithTags(nameof(Product));

        group.MapGet("/", () =>
        {
            return new [] { new Product() };
        })
        .WithName("GetAllProducts")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new Product { ID = id };
        })
        .WithName("GetProductById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, Product input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateProduct")
        .WithOpenApi();

        group.MapPost("/", (Product model) =>
        {
            //return TypedResults.Created($"/api/Products/{model.ID}", model);
        })
        .WithName("CreateProduct")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new Product { ID = id });
        })
        .WithName("DeleteProduct")
        .WithOpenApi();
    }
}
}

