using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2Enemy : MonoBehaviour
{
    float moveSpeeD1 = 0.2f;
    float moveSpeeD2 = 0.2f;
    
    private void Update()
    {
        if(gameObject.name == "enem1 (6)")
        {
            transform.position += new Vector3(-moveSpeeD1, 0, 0);
        }
        if(gameObject.name == "enem1 (7)")
        {
            transform.position += new Vector3(moveSpeeD2, 0, 0);
        }
        if(transform.position.x <= -5)
        {
            moveSpeeD1 *= -1;
        }
        if(transform.position.x >= 18)
        {
            moveSpeeD2 *= -1;
        }
    }
    
}
