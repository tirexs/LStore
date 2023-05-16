namespace LStore.Models.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int cost { get; set; }
        public byte[] Image { get; set; }


        public int? UserLogintId { get; set; }
        public UserLogin UserLogin { get; set; }
        
        public Cart() { }
    }
}
