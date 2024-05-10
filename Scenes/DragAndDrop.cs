using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour
{   
    // private RectTransform rectTransform;

    // private void Awake()
    // {
    //     rectTransform = GetComponent<RectTransform>();
    // }
    // public void OnBeginDrag(PointerEventData eventData)
    // {
    //     Debug.Log("OnBeginDrag");
    // }

    // public void OnDrag(PointerEventData eventData)
    // {
    //     Debug.Log("OnDrag");
    //     rectTransform.anchoredPosition += eventData.delta;
    // }
    
    // public void OnEndDrag(PointerEventData eventData)
    // {
    //     Debug.Log("OnEndDrag");
    // }

    // public void OnPointerDown(PointerEventData eventData)
    // {
    //     Debug.Log("OnPointerDown");
    // }

    private bool isDragging;

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if(isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
   
}
