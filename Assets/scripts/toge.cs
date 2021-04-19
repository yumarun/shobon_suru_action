using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toge : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "player")
        {
            Debug.Log("hitotobutukattayo");
        }
    }
}
