using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFloar1 : MonoBehaviour
{
    GameObject player;
    float rotateSpeed = 0.9f;
    void Start()
    {
        player = GameObject.Find("player");
    }

    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.tag == "player")
        {
            player.transform.position += new Vector3(rotateSpeed, 0, 0);
        }
    }
}
