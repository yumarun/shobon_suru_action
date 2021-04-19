using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrowToleft : MonoBehaviour
{
    
    int force = -70;

    private void Update()
    {
        if (!GetComponent<Rigidbody2D>().isKinematic)
        {
            MoveArrow_toLeft();
        }
    }

    public void MoveArrow_toLeft()
    //void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0));
    }
    
}
