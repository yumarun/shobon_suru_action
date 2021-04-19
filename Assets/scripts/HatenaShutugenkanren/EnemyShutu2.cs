using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShutu2 : MonoBehaviour
{
    public GameObject ene2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            ene2.GetComponent<eneS>().SHUTUGEN();
        }
    }
}
