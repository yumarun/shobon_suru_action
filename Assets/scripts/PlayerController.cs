using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 1300.0f;
    float moveForce = 20.0f;
    float maxSpeed = 2.0f;
    float idoumaxspeed = 13.0f;
    bool jump_Jud = false; //ジャンプ回数の制限のため
    CircleCollider2D circol = null;
    GameObject zakoEnemy1;
    GameObject zakoEnemy2;
    GameObject zakoEnemy3;

    public float stepOnRate;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        circol = GetComponent<CircleCollider2D>();
        zakoEnemy1 = GameObject.Find("enem1 (3)");
        zakoEnemy2 = GameObject.Find("enem1 (4)");
        zakoEnemy3 = GameObject.Find("enem1 (2)");
    }

    
    void Update()
    {
        
        //ジャンプ
        if (Input.GetKeyDown(KeyCode.Space) && !jump_Jud)
        {
            this.rigid2D.AddForce(transform.up * jumpForce);
            jump_Jud = true;
        }

        //移動
        float x = Input.GetAxis("Horizontal");
        x = x * idoumaxspeed;
        var vec = new Vector2(x, rigid2D.velocity.y);
        rigid2D.AddForce(3 * (vec - rigid2D.velocity));

        //敵に近づいたときに左の敵を動かす
        if(transform.position.x > 46)
        {
            zakoEnemy1.GetComponent<move_zakoenemy>().Move_toLeft();
        }
        //敵に近づいたときに右の敵を動かす
        if(transform.position.x > 61 && transform.position.y < 2.9)
        {
            zakoEnemy2.GetComponent<move_zakoenemy>().Speedy_Move_toLeft();
        }

        //最後の落下的
        if(transform.position.x >= 341)
        {
            zakoEnemy3.GetComponent<Rakka_zako>().SpeedyMove_toDown();
        }
       
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        //ジャンプ制限の解除
        this.jump_Jud = false;   
        
        //敵を踏むのと殺されるのとの区別
        if(collision.collider.tag == "Enemy")
        {
            /*
            // 踏みつけ判定になる高さ
            float stepOnHeight = circol.radius * (stepOnRate / 100f);
            // 踏みつけ判定のワールド座標
            float judgePos = transform.position.y - (circol.radius / 2f) + stepOnHeight;
            foreach(ContactPoint2D p in collision.contacts)
            {
                if(p.point.y < judgePos)
                {
                    //もう一度はねる
                    //[敵を倒す]の関数を呼ぶ
                    this.rigid2D.AddForce(transform.up * jumpForce);
                }
                else
                {
                    //ダウンする
                    Debug.Log("you die");
                }
            }
            */
            Debug.Log("you die");
        }
    }
    


}
