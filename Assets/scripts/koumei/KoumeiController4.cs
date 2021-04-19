using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoumeiController4 : MonoBehaviour
{
    GameObject kouCol1_4;
    GameObject kouCol2_4;
    public GameObject koumeiObject_4;
    bool OkKoumei_4 = false;
    GameObject player_4;
    void Start()
    {
        player_4 = GameObject.Find("player");
        kouCol1_4 = GameObject.Find("koumeiCollider1_4");
        kouCol2_4 = GameObject.Find("koumeiCollider2_4");
    }


    void Update()
    {
        if (player_4.transform.position.y <= 8.2)
        {
            OkKoumei_4 = false;
        }
        /*
        if (kouCol1.GetComponent<koumeiCol1>().JudKoumei1 && !kouCol2.GetComponent<koumeiCol2>().JudKoumei2)
        {
            kouCol1.GetComponent<koumeiCol1>().JudKoumei1 = false;
            
        }
        */
        if (!kouCol1_4.GetComponent<koumeiCol1_4>().JudKoumei1_4 && kouCol2_4.GetComponent<koumeiCol2_4>().JudKoumei2_4)
        {
            OkKoumei_4 = true;
        }
        if (kouCol1_4.GetComponent<koumeiCol1_4>().JudKoumei1_4 && kouCol2_4.GetComponent<koumeiCol2_4>().JudKoumei2_4 && OkKoumei_4)
        {
            koumeiObject_4.SetActive(true);
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
