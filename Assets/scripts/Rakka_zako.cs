using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rakka_zako : MonoBehaviour
{
    float downspeed = -1.0f;
    public void SpeedyMove_toDown()
    {
        transform.position += new Vector3(0, downspeed, 0);
    }
}
