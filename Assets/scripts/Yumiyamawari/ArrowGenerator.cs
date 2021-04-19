using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject Prefab;
    public bool CanFireArrow = true;
    float IntervalArrow = 0.25f;
    float TimeFire = 0;
    float speed = 100;
    private void Update()
    {
        if (CanFireArrow)
        {
            TimeFire += Time.deltaTime;
            if (TimeFire >= IntervalArrow)
            {
                GameObject arrow = Instantiate(Prefab) as GameObject;
                arrow.transform.position = new Vector3(282, 42, 1);
                TimeFire = 0;
            }
        }
    }
}
