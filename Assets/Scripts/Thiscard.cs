using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Thiscard : MonoBehaviour
{
    public List<Card> thiscard = new List<Card>();
    public int thisid;

    public int id;
    public string element;
    public string color;
    public string rank;
    public int scorerank;

    public Text elementT;
    public Text colorT;
    public Text rankT;

    public bool CardBack;
    public static bool staticCardBack;
    // Start is called before the first frame update
    void Start()
    {
        thiscard.Add(CardDatabase.CardList[thisid]);
    }

    // Update is called once per frame
    void Update()
    {
        id = thiscard[0].id;
        element = thiscard[0].element;
        color = thiscard[0].color;
        rank = thiscard[0].rank;
        scorerank = thiscard[0].scorerank;

        elementT.text = "" + element;
        colorT.text = "" + color;
        rankT.text = "" + rank;

        staticCardBack = CardBack;
    }
}
