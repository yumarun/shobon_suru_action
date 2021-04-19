using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol2_2 : MonoBehaviour
{
    public bool JudKoumei2_2 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei2_2 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei2_2 = false;
    }
}
