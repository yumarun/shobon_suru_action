using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol1 : MonoBehaviour
{
    public bool JudKoumei1 = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei1 = true;
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei1 = false;
    }
}
