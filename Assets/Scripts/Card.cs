using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string element;
    public string color;
    public string rank;
    public int scorerank;

    public Card()
    {

    }

    public Card(int Id, string Element, string Color, string Rank, int Score)
    {
        id = Id;
        element = Element;
        color = Color;
        rank = Rank;
        scorerank = Score;
    }
}


