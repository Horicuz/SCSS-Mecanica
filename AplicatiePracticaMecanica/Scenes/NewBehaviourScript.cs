using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   public GameObject obj1;

    public void Start()
    {
        Rigidbody2D rb = obj1.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.None;
    }

    public void Stop()
    {
        Rigidbody2D rb = obj1.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
   

}
