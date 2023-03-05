namespace Talie_kart
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static Card RandomCard()
        {
            return new Card((Values)random.Next(2, 15), (Suits)random.Next(4));
        }
        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            Console.WriteLine("Podaj liczbę kart: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfCards))
            {
                for (int i = 0; i < numberOfCards; i++) { cards.Add(RandomCard()); }
            }
            PrintCards(cards);
            cards.Sort(new CardComparerByValue());
            Console.WriteLine("--------Sortowanie kart---------");
            PrintCards(cards);
        }
    }
}