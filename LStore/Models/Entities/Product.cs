namespace LStore.Models.Entities
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int cost { get; set; }
        public int quantity { get; set; }
        public byte[] Image { get; set; }

        public int? StoreId { get; set; }
        public Store Store { get; set; }


        public Product() { }
    }
}
