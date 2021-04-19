using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol1_2 : MonoBehaviour
{
    public bool JudKoumei1_22 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei1_22 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei1_22 = false;
    }
}
