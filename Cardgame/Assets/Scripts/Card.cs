using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public int cardID;
    public string CardElement;
    public string CardColor;
    public string CardRank;
    public int Cardscore;

    public Card(int ID, string Element, string Color, string Rank, int Score)
    {
        cardID = ID;
        CardElement = Element;
        CardColor = Color;
        CardRank = Rank;
        Cardscore = Score;

    }
}
