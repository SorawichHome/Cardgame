using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropCardzone : MonoBehaviour,IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        DragandDrop D = eventData.pointerDrag.GetComponent<DragandDrop>();
        if(D != null)
        {
            D.parentToreturnTo = this.transform;
        }
    }
    
    
}
