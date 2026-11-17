namespace ShoppingList.Data.Entitites
{
    public class ProductNote
    {
        public int Id { get; set; }

        public string Content { get; set; } = null!;

        public int ProductId { get; set; }
        public Product product { get; set; } = null!;
    }
}
