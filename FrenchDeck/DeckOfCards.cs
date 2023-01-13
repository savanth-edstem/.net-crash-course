class DeckOfCards
{
    public readonly List<Card> _frenchDeck;
    public DeckOfCards()
    {
        _frenchDeck = new List<Card>();
    }
    public void AddToDeckOfcards()
    {
        string[] ranks = {  "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suits = { "spades", "diamonds", "clubs", "hearts" };
        foreach (string rank in ranks)
        {
            foreach (string suit in suits)
            {
                _frenchDeck.Add(new Card(rank, suit));
            }
        }
    }
}