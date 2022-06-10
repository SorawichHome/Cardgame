using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDrop : MonoBehaviour
{
    bool Isdragging = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartDrag()
    {
        Isdragging = true;
    }

    public void EndDrag()
    {
        Isdragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Isdragging)
        {
            transform.position = (new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        }
    }
}
