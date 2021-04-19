using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol2_3 : MonoBehaviour
{
    public bool JudKoumei2_3 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei2_3 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei2_3 = false;
    }
}
