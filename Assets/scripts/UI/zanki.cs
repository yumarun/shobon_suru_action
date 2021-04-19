using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zanki : MonoBehaviour
{
    public int zankiNUM = 10;
    public Text zankiText;
    // Start is called before the first frame update
    void Start()
    {
        zankiText.text = "";//+ zankiNUM;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
