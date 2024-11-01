namespace PurpleBuzz.Entities
{
    public class ContactInfo:BaseEntity
    {
        public string Title { get; set; }
        public string Person {  get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoUrl { get; set; }
    }
}
