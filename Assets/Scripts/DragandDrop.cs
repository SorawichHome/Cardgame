using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragandDrop : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler
{
    public Transform parentToreturnTo = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToreturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToreturnTo);
    }
}
