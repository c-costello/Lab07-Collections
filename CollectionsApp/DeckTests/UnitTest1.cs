using CollectionsApp;
using System;
using Xunit;

namespace DeckTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCardToDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card("Q", Card.Suit.Diamonds));


            Assert.Equal(Card.Suit.Diamonds, deck.internalItems[0].CardSuit);
        }

        [Fact]
        public void CanRemoveCardFromDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            Card cardOne = new Card("Q", Card.Suit.Diamonds);
            Card cardToBeRemoved = new Card("J", Card.Suit.Hearts);
            Card cardThree = new Card("5", Card.Suit.Clubs);
            deck.Add(cardOne);
            deck.Add(cardToBeRemoved);
            deck.Add(cardThree);
            deck.Remove(cardToBeRemoved);


            Assert.Equal("5", deck.internalItems[1].Value);

        }

        [Fact]
        public void CannotRemoveCardNotInDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            Card cardOne = new Card("Q", Card.Suit.Diamonds);
            Card cardToBeRemoved = new Card("J", Card.Suit.Hearts);
            Card cardThree = new Card("5", Card.Suit.Clubs);
            deck.Add(cardOne);
            deck.Add(cardThree);
            deck.Remove(cardToBeRemoved);
            Assert.Equal(2, deck.internalItems.Length);

        }
        [Fact]
        public void CanGetAndSetCardProperties()
        {
            Card card = new Card("Q", Card.Suit.Hearts);


            Assert.Equal("Q", card.Value);
        }
        [Fact]
        public void CanGetAndSetCardPropertiesPtTwo()
        {
            Card card = new Card("Q", Card.Suit.Hearts);
            card.Value = "J";

            Assert.Equal("J", card.Value);

        }
    }
}
