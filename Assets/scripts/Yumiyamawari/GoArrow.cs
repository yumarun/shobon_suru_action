using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoArrow : MonoBehaviour
{
    //GameObject[] arrows;
    GameObject arrow;
    
    float IntervalFire = 4;
    float time = 0;
    void Start()
    {
        arrow = GameObject.Find("Arrow");
        /*
        arrows[1] = GameObject.Find("Arrow (1)");
        arrows[0] = GameObject.Find("Arrow");
        arrows[2] = GameObject.Find("Arrow (2)");
        arrows[3] = GameObject.Find("Arrow (3)");
        arrows[4] = GameObject.Find("Arrow (4)");
        arrows[5] = GameObject.Find("Arrow (5)");
        arrows[6] = GameObject.Find("Arrow (6)");
        arrows[7] = GameObject.Find("Arrow (7)");
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CountDown()
    {
        time += Time.deltaTime;
    }
    public void FireArrow()
    {
        //for(int i = 0; i <= 7; i++)
        //{

        //arrows[i].transform.position += new Vector3(-ArrowSpeed, 0, 0); 
        //}
        //arrow.transform.position += new Vector3(-ArrowSpeed, 0, 0);
    }
}
