using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShutsugen : MonoBehaviour
{
    public GameObject enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {

            enemy.GetComponent<eneS>().SHUTUGEN();
        }
    }
}
