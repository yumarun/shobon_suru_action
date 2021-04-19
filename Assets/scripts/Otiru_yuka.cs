using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otiru_yuka : MonoBehaviour
{
    public float yuka_down_Speed = -0.4f;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "player")
        {
            other.gameObject.transform.SetParent(this.transform);
        }
    }

    void OnCollisionStay2D(Collision2D other1)
    {
        if (other1.gameObject.tag == "player")
        {
            this.transform.position += new Vector3(0, yuka_down_Speed * Time.deltaTime, 0);
        }
    }
    void OnCollisionExit2D(Collision2D other2)
    {
        if (other2.gameObject.tag == "player")
        {
            other2.gameObject.transform.SetParent(null);
            this.GetComponent<Rigidbody2D>().isKinematic = false;

        }
    }
}
