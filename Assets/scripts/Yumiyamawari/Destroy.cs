﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    
    void Update()
    {
        if(transform.position.y <= -25)
        {
            Destroy(gameObject);
        }
    }
}
