using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 出てくる床 : MonoBehaviour
{
    private MeshRenderer mesh;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mesh.enabled = true;
        }
    }
}
