using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEnemy : MonoBehaviour
{
    float moveSpeed3 = 0.09f;
    
    void Update()
    {
        transform.position += new Vector3(moveSpeed3, 0, 0);
    }
}
