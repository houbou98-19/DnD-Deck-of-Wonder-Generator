using System.ComponentModel.DataAnnotations;

namespace CardGenerator.Domain.Entities
{
    public class Card
    {
        [Required]
        public string Number { get; private set; }
        [Required]
        public string Name { get; private set; }
        [Required]
        public string Suit { get; private set; }
        [Required]
        public string Effect { get; private set; }

        public Card(string number, string name, string suit, string effect)
        {
            Number = number ?? throw new ArgumentNullException(nameof(number));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Suit = suit ?? throw new ArgumentNullException(nameof(suit));
            Effect = effect ?? throw new ArgumentNullException(nameof(effect));
        }



        
    }
}