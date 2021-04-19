using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol2_6 : MonoBehaviour
{
    public bool JudKoumei2_6 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei2_6 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei2_6 = false;
    }
}
