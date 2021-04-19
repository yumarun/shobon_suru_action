using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol2_7 : MonoBehaviour
{
    public bool JudKoumei2_7 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei2_7 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei2_7 = false;
    }
}
