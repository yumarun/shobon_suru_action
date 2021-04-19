using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class last_jud_Cont : MonoBehaviour
{
    GameObject rakka_yuka;
    GameObject player;
    Vector3 player_Pos;
    float yuka_down_Speed_last1 = -5.0f;
    

    void Start()
    {
        this.rakka_yuka = GameObject.Find("otiruyuka_gole");
        this.player = GameObject.Find("player");
        this.player_Pos = this.player.transform.position;
    }

    /*void OnTriggerEnter2D(Collider2D collision)
    {
        this.rakka_yuka.transform.position += new Vector3(0, yuka_down_Speed_last1 * Time.deltaTime, 0);
    }*/
    void Update()
    {
        //一段目の床の動き
        if(this.player.transform.position.x >= 358.2f && this.player.transform.position.x <= 376.1f && this.player.transform.position.y <= 6.5f)
        {
            this.rakka_yuka.transform.position += new Vector3(0, yuka_down_Speed_last1 * Time.deltaTime, 0);
        }

    }
}
