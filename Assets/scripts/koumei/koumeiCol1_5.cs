using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol1_5 : MonoBehaviour
{
    public bool JudKoumei1_5 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei1_5 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei1_5 = false;
    }
}
