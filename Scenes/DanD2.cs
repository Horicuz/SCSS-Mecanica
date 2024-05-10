using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class DanD2 : MonoBehaviour
{
    // Start is called before the first frame update

    private float starPosX;
    private float starPosY;

    private bool isBeingHeld = false;

   
    void Update()
    {   
         UnityEngine.Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if(isBeingHeld == true)
        {
            this.gameObject.transform.localPosition = new UnityEngine.Vector3(mousePos.x, mousePos.y, 0);
        }
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            UnityEngine.Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            isBeingHeld = true;
        }

        
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

}
