using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_zakoenemy : MonoBehaviour
{
    float moveSpeed = -0.1f;
    float moveSpeed2 = -0.4f;
    float moveSpeed3 = 0.09f;
    public void Move_toLeft()
    {
        transform.position += new Vector3(moveSpeed, 0, 0);
    }
    public void Speedy_Move_toLeft()
    {
        transform.position += new Vector3(moveSpeed2, 0, 0);
    }
    public void MoveOfStartenemy()
    {
        transform.position += new Vector3(moveSpeed3, 0, 0);
    }
    private void Update()
    {
        if(transform.position.x <= 50)
        {
            moveSpeed = 0.1f;
        }
        if(transform.position.x >= 74)
        {
            moveSpeed = -0.1f;
        }
    }
}
