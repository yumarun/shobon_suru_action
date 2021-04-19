using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoumeiController5 : MonoBehaviour
{
    GameObject kouCol1_5;
    GameObject kouCol2_5;
    public GameObject koumeiObject_5;
    bool OkKoumei_5 = false;
    GameObject player_5;
    void Start()
    {
        player_5 = GameObject.Find("player");
        kouCol1_5 = GameObject.Find("koumeiCollider1_5");
        kouCol2_5 = GameObject.Find("koumeiCollider2_5");
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
        if (!kouCol1_5.GetComponent<koumeiCol1_5>().JudKoumei1_5 && kouCol2_5.GetComponent<koumeiCol2_5>().JudKoumei2_5)
        {
            OkKoumei_5 = true;
        }
        if (kouCol1_5.GetComponent<koumeiCol1_5>().JudKoumei1_5 && kouCol2_5.GetComponent<koumeiCol2_5>().JudKoumei2_5 && OkKoumei_5)
        {
            koumeiObject_5.SetActive(true);
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
