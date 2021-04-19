using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockController : MonoBehaviour
{
    GameObject player;
    Vector3 playerPos;
    Vector3 blockPos;
    float dis;

    void Start()
    {
        player = GameObject.Find("player");   
    }

    
    void Update()
    {
        playerPos = player.transform.position;
        blockPos = transform.position;
        dis = Vector3.Distance(playerPos, blockPos);
        
        if (dis <= 5)
        {
            transform.position = new Vector3(196.8f, 15, 0);
            
        }
    }
}
