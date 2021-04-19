using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//stage1
public class DethController : MonoBehaviour
{
    GameObject player;
    public Text zanki;
    
    void Start()
    {
        player = GameObject.Find("player");
    }

    
    void Update()
    {
        if(player.transform.position.y <= -10)
        {


            zanki.GetComponent<zanki>().zankiNUM -= 1;
            GoStartPositon();
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            GoStartPositon();
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "player")
        {
            GoStartPositon();
        }
    }
    public void GoStartPositon()
    {
        SceneManager.LoadScene("GameScene");
    }
}
