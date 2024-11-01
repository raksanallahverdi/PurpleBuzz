namespace PurpleBuzz.Entities
{
    public class PricingCard:BaseEntity
    {
        public string Title { get; set; }   
        public string Price { get; set; }
        public List<string> Features { get; set; } = new List<string>();
    }
}
