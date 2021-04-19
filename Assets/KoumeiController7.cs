using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoumeiController7 : MonoBehaviour
{
    GameObject kouCol1_7;
    GameObject kouCol2_7;
    public GameObject koumeiObject_7;
    bool OkKoumei_7 = false;
    GameObject player_7;
    void Start()
    {
        player_7 = GameObject.Find("player");
        kouCol1_7 = GameObject.Find("koumeiCollider1_7");
        kouCol2_7 = GameObject.Find("koumeiCollider2_7");
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
        if (!kouCol1_7.GetComponent<koumeiCol1_7>().JudKoumei1_7 && kouCol2_7.GetComponent<koumeiCol2_7>().JudKoumei2_7)
        {
            OkKoumei_7 = true;
        }
        if (kouCol1_7.GetComponent<koumeiCol1_7>().JudKoumei1_7 && kouCol2_7.GetComponent<koumeiCol2_7>().JudKoumei2_7 && OkKoumei_7)
        {
            koumeiObject_7.SetActive(true);
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
