using PurpleBuzz.Entities;

namespace PurpleBuzz.Models.Home
{
    public class CardVM : BaseEntity
    {
        public string PhotoPath { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }

    }
}
