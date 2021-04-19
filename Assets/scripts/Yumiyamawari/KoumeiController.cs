using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoumeiController : MonoBehaviour
{
    GameObject kouCol1;
    GameObject kouCol2;
    public GameObject koumeiObject;
    bool OkKoumei = false;
    GameObject player;
    void Start()
    {
        player = GameObject.Find("player");
        kouCol1 = GameObject.Find("koumeiCollider1");
        kouCol2 = GameObject.Find("koumeiCollider2");
    }

    
    void Update()
    {
        if(player.transform.position.y <= 1.9)
        {
            OkKoumei = false;
        }
        /*
        if (kouCol1.GetComponent<koumeiCol1>().JudKoumei1 && !kouCol2.GetComponent<koumeiCol2>().JudKoumei2)
        {
            kouCol1.GetComponent<koumeiCol1>().JudKoumei1 = false;
            
        }
        */
        if (!kouCol1.GetComponent<koumeiCol1>().JudKoumei1 && kouCol2.GetComponent<koumeiCol2>().JudKoumei2)
        {
            OkKoumei = true;
        }
        if(kouCol1.GetComponent<koumeiCol1>().JudKoumei1 && kouCol2.GetComponent<koumeiCol2>().JudKoumei2 && OkKoumei)
        {
            koumeiObject.SetActive(true);
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
