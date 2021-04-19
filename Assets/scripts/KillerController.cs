using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerController : MonoBehaviour
{
    GameObject player;
    float kilerSpeed = 1.0f;
    bool CanMove = false;
    private void Start()
    {
        player = GameObject.Find("player");
    }
    void Update()
    {
        if(player.transform.position.x >= 232)
        {
            CanMove = true;
            
        }
        if (CanMove)
        {
            transform.position += new Vector3(0, kilerSpeed, 0);
        }
    }
}
