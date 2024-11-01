namespace PurpleBuzz.Entities
{
    public class Contact : BaseEntity
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string IconClass { get; set; }
    }
}
