using System;

public class Card
{
    public enum Suit { Heart, Diamond, Club, Spade };
    public char value;
    public Suit suit;
    public Card(Suit suit, char value)
    {
        this.value = value;
        this.suit = suit;
    }

    public Card()
    {

    }

    public override string ToString()
    {
        return value + " " + suit;
    }

    public char getValue()
    {
        return value;
    }
    public Suit getSuit()
    {
        return suit;
    }

    public bool isSameValue(Card c)
    {
        return this.value == c.value;
    }

    public string getImageFile()
    {
        string result = "";
        if (suit.Equals(Suit.Club))
        {
            result += 'c';
        }
        else if (suit.Equals(Suit.Spade))
        {
            result += 's';
        }
        else if (suit.Equals(Suit.Diamond))
        {
            result += 'd';
        }
        else if (suit.Equals(Suit.Heart))
        {
            result += 'h';
        }
        if (value == 't')
        {
            result += "10";
        }
        else
        {
            result += value;
        }

        return result + ".png";
    }
}
