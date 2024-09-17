using CardGenerator.Application.DTO;
using CardGenerator.Application.Interfaces;
using CardGenerator.Domain.Entities;

namespace CardGenerator.Application.Services
{
    public class CardService : ICardService
    {
        private readonly List<Card> _cards;
        private readonly Random _random;
        public CardService(Random random)
        {
            _random = random;
            _cards = new List<Card>
                {
                    new Card("K", "Day", "♦", "You gain a +1 bonus to saving throws. This benefit lasts until you finish a long rest."),
                    new Card("Q", "Night", "♦", "You gain darkvision within a range of 300 feet. This darkvision lasts for 8 hours."),
                    new Card("J", "Dawn", "♦", "For the next 8 hours, you can add your proficiency bonus to your initiative rolls."),
                    new Card("K", "Crown", "♥", "You gain one use of the Friends cantrip. Use your Intelligence, Wisdom, or Charisma as the spellcasting ability (your choice). The use disappears after 8 hours."),
                    new Card("Q", "Lock", "♥", "You gain the ability to cast Knock 1d3 times. Use your Intelligence, Wisdom, or Charisma as the spellcasting ability (your choice)."),
                    new Card("J", "Champion", "♥", "You gain a +1 bonus to weapon attack and damage rolls. This bonus lasts for 8 hours."),
                    new Card("K", "Chaos", "♣", "You gain resistance to one of the following damage types, chosen at random: acid, cold, fire, lightning, or thunder. This resistance lasts for 1d12 days."),
                    new Card("Q", "Order", "♣", "You gain resistance to one of the following damage types, chosen at random: force, necrotic, poison, psychic, or radiant. This resistance lasts for 1d12 days."),
                    new Card("J", "Beginning", "♣", "Your hit point maximum and current hit points increase by 2d10. Your hit point maximum remains increased in this way for the next 8 hours."),
                    new Card("K", "End", "♠", "You take 2d10 necrotic damage, and your hit point maximum is reduced by an amount equal to the damage taken. This effect can't reduce your hit point maximum below 10 hit points. This reduction lasts until you finish a long rest, but it can be ended early by a Remove Curse spell or similar magic."),
                    new Card("Q", "Monster", "♠", "While cursed in this way, whenever you make a saving throw, you must roll 1d4 and subtract the number rolled from the total. The curse lasts until you finish a long rest, but it can be ended early with a Remove Curse spell or similar magic."),
                    new Card("J", "Knife", "♠", "You become vulnerable to either bludgeon damage, slashing damage, or piercing damage, chosen at random. Lasts 8 hours."),
                    new Card("Joker", "Mischief", "", "Choose one creature within 60 feet, the chosen creature must roll once on the wild magic table, or you can draw two additional cards beyond your declared draws.")
                };
        }
       public CardDTO DrawCard()
        {
            int index = _random.Next(_cards.Count);
            var card = _cards[index];
            return new CardDTO(card.Number, card.Name, card.Suit, card.Effect);
        }
    }
}