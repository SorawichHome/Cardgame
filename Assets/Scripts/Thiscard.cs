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

    public bool CardBack;
    public static bool staticCardBack;

    
    // Start is called before the first frame update
    void Start()
    {
        //thisid = Random.Range(0, 374);
        //for (int i = 0; i <= maxIdcard; i++)
        //{
        //    i = thisid;

        //}
        thiscard.Add(CardDatabase.CardList[thisid]);
        //id = thiscard[thisid].id;
        //element = thiscard[thisid].element;
        //color = thiscard[thisid].color;
        //rank = thiscard[thisid].rank;
        //scorerank = thiscard[thisid].scorerank;
    }

    // Update is called once per frame
    void Update()
    {
        //Randomid = 0;
        //for (int i = 0; i <= maxIdcard; i++)
        //{
        //    Randomid = Random.Range(0, maxIdcard);
        //    Randomid = thisid;
        //    if(Randomid == thisid)
        //    {
        //        id = thiscard[Randomid].id;
        //        element = thiscard[Randomid].element;
        //        color = thiscard[Randomid].color;
        //        rank = thiscard[Randomid].rank;
        //        scorerank = thiscard[Randomid].scorerank;
        //        break;
        //    }
        //}
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
