using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBackprefabs : MonoBehaviour
{
    public GameObject deck;
    public GameObject It;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deck = GameObject.Find("deckpanel");
        It.transform.SetParent(deck.transform);
        It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
        It.transform.eulerAngles = new Vector3(30,0, 0);
    }
}
