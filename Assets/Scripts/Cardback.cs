using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardback : MonoBehaviour
{
    public GameObject backcard;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Thiscard.staticCardBack == true)
        {
            backcard.SetActive(true);
        }
        else
        {
            backcard.SetActive(false);
        }
    }
}
