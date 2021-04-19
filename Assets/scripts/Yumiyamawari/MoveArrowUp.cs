using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrowUp : MonoBehaviour
{
    float moveArrowSpeed = 0.1f;
    public void moveArrowUp()
    {
        transform.position += new Vector3(0, moveArrowSpeed, 0);
    }
}
