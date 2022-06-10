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
    public int maxIdcard = 374;
    public int Randomid;
    public Text elementT;
    public Text colorT;
    public Text rankT;

    public GameObject Cardcover;

    public bool CardBack = false;

    public GameObject Hand;
    public int Numberofcardindeck = 375;

    
    // Start is called before the first frame update
    void Start()
    {
        thisid = Random.Range(0, 374);
        thiscard.Add(CardDatabase.CardList[thisid]);
        Numberofcardindeck = CardDeck.Decksize;
    }

    // Update is called once per frame
    void Update()
    {
        Hand = GameObject.Find("Hand");
        if (this.transform.parent == Hand.transform.parent)
        {
            CardBack = false;
        }

        if(CardBack == true)
        {
            Cardcover.SetActive(true);
        }
        else
        {
            Cardcover.SetActive(false);
        }
        id = thiscard[0].id;
        element = thiscard[0].element;
        color = thiscard[0].color;
        rank = thiscard[0].rank;
        scorerank = thiscard[0].scorerank;

        elementT.text = "" + element;
        colorT.text = "" + color;
        rankT.text = "" + rank;

        //if (this.tag == "Clone")
        //{
        //    thiscard[0] = CardDeck.StaticDeck[Numberofcardindeck - 1];
        //    Numberofcardindeck -= 1;
        //    CardDeck.Decksize -= 1;
        //    this.tag = "Untagged";
        //}
    }
}
