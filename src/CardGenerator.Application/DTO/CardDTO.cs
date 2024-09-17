namespace CardGenerator.Application.DTO
{
    public class CardDTO
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Suit { get; set; }
        public string Effect { get; set; }


        public CardDTO(string number, string name, string suit, string effect)
        {
            Number = number;
            Name = name;
            Suit = suit;
            Effect = effect;
        }
    }
}