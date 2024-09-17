document.getElementById('drawCardButton').addEventListener('click', drawCard);

const cards = [
    { number: "K", name: "Day", suit: "♦", effect: "You gain a +1 bonus to saving throws. This benefit lasts until you finish a long rest." },
    { number: "Q", name: "Night", suit: "♦", effect: "You gain darkvision within a range of 300 feet. This darkvision lasts for 8 hours." },
    { number: "J", name: "Dawn", suit: "♦", effect: "For the next 8 hours, you can add your proficiency bonus to your initiative rolls." },
    { number: "K", name: "Crown", suit: "♥", effect: "You gain one use of the Friends cantrip. Use your Intelligence, Wisdom, or Charisma as the spellcasting ability (your choice). The use disappears after 8 hours." },
    { number: "Q", name: "Lock", suit: "♥", effect: "You gain the ability to cast Knock 1d3 times. Use your Intelligence, Wisdom, or Charisma as the spellcasting ability (your choice)." },
    { number: "J", name: "Champion", suit: "♥", effect: "You gain a +1 bonus to weapon attack and damage rolls. This bonus lasts for 8 hours." },
    { number: "K", name: "Chaos", suit: "♣", effect: "You gain resistance to one of the following damage types, chosen at random: acid, cold, fire, lightning, or thunder. This resistance lasts for 1d12 days." },
    { number: "Q", name: "Order", suit: "♣", effect: "You gain resistance to one of the following damage types, chosen at random: force, necrotic, poison, psychic, or radiant. This resistance lasts for 1d12 days." },
    { number: "J", name: "Beginning", suit: "♣", effect: "Your hit point maximum and current hit points increase by 2d10. Your hit point maximum remains increased in this way for the next 8 hours." },
    { number: "K", name: "End", suit: "♠", effect: "You take 2d10 necrotic damage, and your hit point maximum is reduced by an amount equal to the damage taken. This effect can't reduce your hit point maximum below 10 hit points. This reduction lasts until you finish a long rest, but it can be ended early by a Remove Curse spell or similar magic." },
    { number: "Q", name: "Monster", suit: "♠", effect: "While cursed in this way, whenever you make a saving throw, you must roll 1d4 and subtract the number rolled from the total. The curse lasts until you finish a long rest, but it can be ended early with a Remove Curse spell or similar magic." },
    { number: "J", name: "Knife", suit: "♠", effect: "You become vulnerable to either bludgeon damage, slashing damage, or piercing damage, chosen at random. Lasts 8 hours." },
    { number: "Joker", name: "Mischief", suit: "Joker", effect: "Choose one creature within 60 feet, the chosen creature must roll once on the wild magic table, or you can draw two additional cards beyond your declared draws." }
];

function drawCard() {
    const randomIndex = Math.floor(Math.random() * cards.length);
    const card = cards[randomIndex];

    document.getElementById('cardNumber').textContent = card.number;
    document.getElementById('cardName').textContent = card.name;
    document.getElementById('cardSuit').textContent = card.suit;
    document.getElementById('cardEffect').textContent = card.effect;
}
