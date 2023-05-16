namespace LStore.Models.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        
        public List<Product> Product { get; set; }
        public int? UserLogintId { get; set; }
        public UserLogin UserLogin { get; set; }


        public Store() { }
    }
}
