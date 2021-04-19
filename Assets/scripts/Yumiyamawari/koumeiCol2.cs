using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol2 : MonoBehaviour
{
    public bool JudKoumei2 = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei2 = true;
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei2 = false;
    }
}
