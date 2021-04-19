using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol1_7 : MonoBehaviour
{
    public bool JudKoumei1_7 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei1_7 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei1_7 = false;
    }
}
