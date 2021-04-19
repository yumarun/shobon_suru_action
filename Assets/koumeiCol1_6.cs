using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol1_6 : MonoBehaviour
{
    public bool JudKoumei1_6 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei1_6 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei1_6 = false;
    }
}
