using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

public class BeehiveGame
{
    public List<Card> deck;
    public SerializableStack<Card> beehiveStack;
    public SerializableStack<Card> workingPile;
    public SerializableStack<Card> flowerStack1;
    public SerializableStack<Card> flowerStack2;
    public SerializableStack<Card> flowerStack3;
    public SerializableStack<Card> flowerStack4;
    public SerializableStack<Card> flowerStack5;
    public SerializableStack<Card> flowerStack6;
    public bool win = false;

    public List<Card> getDeck()
    {
        return deck;
    }
    public SerializableStack<Card> getBeehive()
    {
        return beehiveStack;
    }
    public SerializableStack<Card> getFlowerStack(int i)
    {
        if (i == 1)
        {
            return flowerStack1;
        }
        else if (i == 2)
        {
            return flowerStack2;
        }
        else if (i == 3)
        {
            return flowerStack3;
        }
        else if (i == 4)
        {
            return flowerStack4;
        }
        else if (i == 5)
        {
            return flowerStack5;
        }
        else if (i == 6)
        {
            return flowerStack6;
        }
        return null;
    }

    public SerializableStack<Card> getWorkingPile()
    {
        return workingPile;
    }

    public bool moveWorkingCardToFlower(int stack)
    {
        return moveTopOfStackToFlower(workingPile, stack);
    }

    public bool moveBeehiveToFlower(int stack)
    {
        return moveTopOfStackToFlower(beehiveStack, stack);
    }

    public bool moveTopOfStackToFlower(SerializableStack<Card> source, int stack)
    {
        SerializableStack<Card> flowerStack = getFlowerStack(stack);
        if (source.Count() > 0)
        {
            char workingCardValue = source.Peek().getValue();
            if (flowerStack.Count() > 0)
            {
                d("move top " + stack + " src " + source.Peek() + " d " + flowerStack.Peek());
            }

            if (flowerStack.Count() == 0 || flowerStack.Peek().getValue() == workingCardValue)
            {
                Card toMove = source.Pop();
                flowerStack.Push(toMove);
                if (flowerStack.Count() >= 4)
                {
                    d("cleared flower stack: " + flowerStack.Peek().getValue());
                    flowerStack.Clear();
                }
                checkWinState();
                return true;
            }
        }
        return false;
    }

    public void checkWinState()
    {
        for (int i = 1; i <= 6; i++)
        {
            SerializableStack<Card> s = getFlowerStack(i);
            if (s.Count() != 0)
            {
                return;
            }
        }
        win = true;
    }

    public bool playerWon()
    {
        return win;
    }

    public void getDifferentWorkingPile()
    {
        while (workingPile.Count() > 0)
        {
            deck.Add(workingPile.Pop());
        }
        for (int i = 0; i < 3; i++)
        {
            if (deck.Count > 0)
            {
                workingPile.Push(deck.ElementAt(0));
                deck.RemoveAt(0);
            }
        }
    }


    public BeehiveGame()
    {
        deck = new List<Card>();
        for (int i = 1; i <= 13; i++)
        {
            char c = map(i);
            deck.Add(new Card(Card.Suit.Club, c));
            deck.Add(new Card(Card.Suit.Spade, c));
            deck.Add(new Card(Card.Suit.Heart, c));
            deck.Add(new Card(Card.Suit.Diamond, c));
        }

        var shuffledcards = deck.OrderBy(a => Guid.NewGuid());
        deck = new List<Card>(shuffledcards);

        flowerStack1 = new SerializableStack<Card>();
        flowerStack2 = new SerializableStack<Card>();
        flowerStack3 = new SerializableStack<Card>();
        flowerStack4 = new SerializableStack<Card>();
        flowerStack5 = new SerializableStack<Card>();
        flowerStack6 = new SerializableStack<Card>();
        beehiveStack = new SerializableStack<Card>();
        workingPile = new SerializableStack<Card>();

        for (int i = 0; i < 10; i++)
        {
            beehiveStack.Push(deck.ElementAt(0));
            deck.RemoveAt(0);
        }
        for (int i = 0; i < 3; i++)
        {
            workingPile.Push(deck.ElementAt(0));
            deck.RemoveAt(0);
        }

        flowerStack1.Push(deck.ElementAt(0));
        deck.RemoveAt(0);
        flowerStack2.Push(deck.ElementAt(0));
        deck.RemoveAt(0);
        flowerStack3.Push(deck.ElementAt(0));
        deck.RemoveAt(0);
        flowerStack4.Push(deck.ElementAt(0));
        deck.RemoveAt(0);
        flowerStack5.Push(deck.ElementAt(0));
        deck.RemoveAt(0);
        flowerStack6.Push(deck.ElementAt(0));
        deck.RemoveAt(0);
    }

    private char map(int i)
    {
        if (i == 10)
        {
            return 't';
        }
        else if (i == 11)
        {
            return 'j';
        }
        else if (i == 12)
        {
            return 'q';
        }
        else if (i == 13)
        {
            return 'k';
        }
        else
        {
            return Char.Parse("" + i);
        }
    }

    public string getCardsValues(List<Card> d)
    {
        StringBuilder result = new StringBuilder();
        int num = 0;
        foreach (Card c in d)
        {

            result.Append(c + " "); num++;
            if (num % 15 == 14)
            {
                result.Append("\n");
            }
        }
        result.Append("\n");
        return result.ToString();
    }

    public bool moveFlowerToFlower(int source, int destination)
    {
        d("move flower to flower " + source + " " + destination);
        SerializableStack<Card> s = getFlowerStack(source);
        SerializableStack<Card> de = getFlowerStack(destination);

        if (s.Count() > 0)
        {
            if (de.Count() == 0 || s.Peek().getValue() == de.Peek().getValue())
            {
                while (s.Count() > 0)
                {
                    de.Push(s.Pop());
                    if (de.Count() == 4)
                    {
                        d("Cleared by flower to flower " + de);
                        de.Clear();
                    }
                }
                return true;
            }
        }
        return false;
    }

    public void d(String s)
    {
        Console.WriteLine(s);
    }

    public string printGameState()
    {
        StringBuilder result = new StringBuilder();

        result.Append(getCardsValues(getDeck()));
        for (int i = 1; i <= 6; i++)
        {
            result.Append("Flower stack " + i + "\n");
            result.Append(getFlowerStack(i) + "\n");
        }
        result.Append("Beehive: " + "\n");
        result.Append(getBeehive() + "\n");
        result.Append("Working pile: " + "\n");
        result.Append(getWorkingPile() + "\n");
        return result.ToString();
    }
}

