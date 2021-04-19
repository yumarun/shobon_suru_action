using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol1_4 : MonoBehaviour
{
    public bool JudKoumei1_4 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei1_4 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei1_4 = false;
    }
}
