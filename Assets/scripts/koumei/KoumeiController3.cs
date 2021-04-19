using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoumeiController3 : MonoBehaviour
{
    GameObject kouCol1_3;
    GameObject kouCol2_3;
    public GameObject koumeiObject_3;
    public bool OkKoumei_3 = false;
    GameObject player_3;
    void Start()
    {
        player_3 = GameObject.Find("player");
        kouCol1_3 = GameObject.Find("koumeiCollider1_3");
        kouCol2_3 = GameObject.Find("koumeiCollider2_3");
    }


    void Update()
    {
        if (player_3.transform.position.y <= 1.9)
        {
            OkKoumei_3 = false;
        }
        
        if (!kouCol1_3.GetComponent<koumeiCol1_3>().JudKoumei1_3 && kouCol2_3.GetComponent<koumeiCol2_3>().JudKoumei2_3)
        {
            OkKoumei_3 = true;
        }
        if (kouCol1_3.GetComponent<koumeiCol1_3>().JudKoumei1_3 && kouCol2_3.GetComponent<koumeiCol2_3>().JudKoumei2_3 && OkKoumei_3)
        {
            koumeiObject_3.SetActive(true);
        }

        // DEBUG
        
        //if (OkKoumei) Debug.Log("okKOUMEI");
        //else Debug.Log("dameKOUMEI");
        //if (kouCol1_3.GetComponent<koumeiCol1_3>().JudKoumei1_3) Debug.Log("111111");
        //if (kouCol2_3.GetComponent<koumeiCol2_3>().JudKoumei2_3) Debug.Log("22222");
        
    }
}
