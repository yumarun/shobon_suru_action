﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeiCol2_4 : MonoBehaviour
{
    public bool JudKoumei2_4 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JudKoumei2_4 = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        JudKoumei2_4 = false;
    }
}
