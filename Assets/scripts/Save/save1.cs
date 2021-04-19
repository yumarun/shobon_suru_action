using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save1 : MonoBehaviour
{
    GameObject flag1;
    GameObject player;
    float saveP1 = 30.0f;
    float saveP2 = 79.0f;
    public bool StartFrom1 = false;



    void Start()
    {
        flag1 = GameObject.Find("flag");
        player = GameObject.Find("player");
        if (StartFrom1)
        {
            player.transform.position = new Vector3(160.0f, 30.0f, 1.0f);
        }
    }

    // Update is called once per frame

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            StartFrom1 = true;
        }
    }
}
