using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiController6 : MonoBehaviour
{
    GameObject kouCol1_6;
    GameObject kouCol2_6;
    public GameObject koumeiObject_6;
    bool OkKoumei_6 = false;
    GameObject player_6;
    void Start()
    {
        player_6 = GameObject.Find("player");
        kouCol1_6 = GameObject.Find("koumeiCollider1_6");
        kouCol2_6 = GameObject.Find("koumeiCollider2_6");
    }


    void Update()
    {
        /*
        if (player_5.transform.position.y <= 8.2)
        {
            OkKoumei_5 = false;
        }
        */

        /*
        if (kouCol1.GetComponent<koumeiCol1>().JudKoumei1 && !kouCol2.GetComponent<koumeiCol2>().JudKoumei2)
        {
            kouCol1.GetComponent<koumeiCol1>().JudKoumei1 = false;
            
        }
        */
        if (!kouCol1_6.GetComponent<koumeiCol1_6>().JudKoumei1_6 && kouCol2_6.GetComponent<koumeiCol2_6>().JudKoumei2_6)
        {
            OkKoumei_6 = true;
        }
        if (kouCol1_6.GetComponent<koumeiCol1_6>().JudKoumei1_6 && kouCol2_6.GetComponent<koumeiCol2_6>().JudKoumei2_6 && OkKoumei_6)
        {
            koumeiObject_6.SetActive(true);
        }
        // DEBUG
        /*
        if (OkKoumei) Debug.Log("okKOUMEI");
        else Debug.Log("dameKOUMEI");
        if (kouCol1.GetComponent<koumeiCol1>().JudKoumei1) Debug.Log("111111");
        if (kouCol2.GetComponent<koumeiCol2>().JudKoumei2) Debug.Log("22222");
        */
    }
}
