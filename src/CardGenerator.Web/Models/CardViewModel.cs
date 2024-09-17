namespace CardGenerator.Web.Models
{
    public class CardViewModel
    {
        public required string Number { get; set; }
        public required string Name { get; set; }
        public required string Suit { get; set; }
        public required string Effect { get; set; }

    }
}