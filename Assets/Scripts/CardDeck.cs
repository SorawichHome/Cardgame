using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> Deckcontainer = new List<Card>();
    public static List<Card> StaticDeck = new List<Card>();
    public int randomCard;
    public static int Decksize = 374;
    public GameObject Showdeck;

    public GameObject Cardback;
    public GameObject Deck;
    public GameObject CardonHand;

    int Maxcardonhand = 5;

    public GameObject[] Clones;
    // Start is called before the first frame update
    void Start()
    {
        randomCard = 0;
        for(int i = 0; i <= Decksize; i++)
        {
            randomCard = Random.Range(0, 374);
            deck.Add(CardDatabase.CardList[randomCard]);
        }
        StartCoroutine(startgame());
    }

    // Update is called once per frame
    void Update()
    {
        StaticDeck = deck;
        if(Decksize <= 0)
        {
            Showdeck.SetActive(false);
        }
    }

    IEnumerator startgame()
    {
        for(int i =0; i< Maxcardonhand; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(CardonHand, transform.position, transform.rotation);
        }
    }

    public void Shuffle()
    {
        for(int i = 0; i <= Decksize; i++)
        {
            int randomIndex = Random.Range(0, 374);
            Deckcontainer.Add(CardDatabase.CardList[randomIndex]);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = Deckcontainer[0];
        }

        Instantiate(Cardback, transform.position, transform.rotation);
    }
    

}
