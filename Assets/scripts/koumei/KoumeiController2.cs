using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoumeiController2 : MonoBehaviour
{
    GameObject kouCol1_2;
    GameObject kouCol2_2;
    public GameObject koumeiObject_2;
    bool OkKoumei_2 = false;
    GameObject player_2;
    void Start()
    {
        player_2 = GameObject.Find("player");
        kouCol1_2 = GameObject.Find("koumeiCollider1_");
        kouCol2_2 = GameObject.Find("koumeiCollider2_");
    }


    void Update()
    {
        if (player_2.transform.position.y <= 9)
        {
            OkKoumei_2 = false;
        }
        
        if (kouCol1_2.GetComponent<koumeiCol1_2>().JudKoumei1_22 && !kouCol2_2.GetComponent<koumeiCol2_2>().JudKoumei2_2)
        {
            kouCol1_2.GetComponent<koumeiCol1_2>().JudKoumei1_22 = false;
            
        }
        
        if (!kouCol1_2.GetComponent<koumeiCol1_2>().JudKoumei1_22 && kouCol2_2.GetComponent<koumeiCol2_2>().JudKoumei2_2)
        {
            OkKoumei_2 = true;
        }
        if (kouCol1_2.GetComponent<koumeiCol1_2>().JudKoumei1_22 && kouCol2_2.GetComponent<koumeiCol2_2>().JudKoumei2_2 && OkKoumei_2)
        {
            koumeiObject_2.SetActive(true);
        }
        // DEBUG
        
        //if (OkKoumei) Debug.Log("okKOUMEI");
        //else Debug.Log("dameKOUMEI");
        if (kouCol1_2.GetComponent<koumeiCol1_2>().JudKoumei1_22) Debug.Log("111111");
        if (kouCol2_2.GetComponent<koumeiCol2_2>().JudKoumei2_2) Debug.Log("22222");
        
    }
}
