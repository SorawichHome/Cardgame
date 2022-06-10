using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turnsystem : MonoBehaviour
{
    bool Yourturnisready = false;
    public int Yourcard;
    public int Opponentcard;
    public Text Turntext;

    public int maxcard = 2;
    public Text cardText;
    public Text opponenetText;
    // Start is called before the first frame update
    void Start()
    {
        Yourturnisready = true;
        Yourcard = 2;
        maxcard = 2;
        Opponentcard = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(Yourturnisready == true)
        {
            Turntext.text = "Your turn";
        }
        else
        {
            Turntext.text = "Opponent turn";
        }

        cardText.text = Yourcard + "/" + maxcard;
        opponenetText.text = Opponentcard + "/" + maxcard;
    }

    public void endturn()
    {
        Yourturnisready = false;
        Opponentcard = 2;
        Yourcard = 0;
    }
    public void Endopponentturn() //For test text
    {
        Yourturnisready = true;
        Opponentcard = 0;
        Yourcard = 2;
    }
}
