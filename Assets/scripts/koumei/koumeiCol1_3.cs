using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol1_3 : MonoBehaviour
{
    public bool JudKoumei1_3 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei1_3 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei1_3 = false;
    }
}
