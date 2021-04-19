using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol2_5 : MonoBehaviour
{
    public bool JudKoumei2_5 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei2_5 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei2_5 = false;
    }
}
