using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Data.Entitites
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string ProductName { get; set; } = null!;
        public HashSet<ProductNote> ProductNotes { get; set; } = new HashSet<ProductNote>();
    }
}
