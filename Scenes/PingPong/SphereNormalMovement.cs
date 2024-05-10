using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement: MonoBehaviour
{   
    // Speed at which the object moves
    public float moveSpeed = 0f;
    public float userSpeed = 0f;

    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Math.Abs(userSpeed) * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * Math.Abs(userSpeed) * Time.deltaTime);
        
    }
   
   void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Square"))
        {
            moveSpeed = -moveSpeed;
        }
    }
}
