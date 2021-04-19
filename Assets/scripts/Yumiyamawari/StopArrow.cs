using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StopArrow : MonoBehaviour
{
    GameObject ArrowGenerator;
    GameObject ArrowFirer = null;
    
    GameObject b;

    public bool StartCount = false;
    float Interval = 3.0f;
    float time = 0;

    void Start()
    {
        ArrowGenerator = GameObject.Find("ArrowGenerator");
        ArrowFirer = GameObject.Find("ArrowFirer");

        b = GameObject.Find("Arrow");
        //StartCoroutine("Offarrowkine");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "player")
        {
            ArrowGenerator.GetComponent<ArrowGenerator>().CanFireArrow = false;
            

            

            //StartCoroutine("Offarrowkine");
            StartCount = true;
            Debug.Log("当たった");
           
            transform.position = new Vector3(265.5f, 60, 1);
        }
    }
    private void Update()
    {
        if (StartCount)
        {
            //Debug.Log("startcount");
            time += Time.deltaTime;
        }
        if(time >= Interval)
        {
            Off_ArrowKinematic();
        }
    }
    void Off_ArrowKinematic()
    {
        b.GetComponent<Rigidbody2D>().isKinematic = false;
    }
    /*
    private IEnumerator Offarrowkine()
    {
        yield return new WaitForSeconds(2.0f);
        b.GetComponent<Rigidbody2D>().isKinematic = false;
    }
    */
}
