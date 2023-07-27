using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material material1;
    public Material material2;

    public MeshRenderer meshRenderer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            meshRenderer.material = material1;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            meshRenderer.material = material2;
        }
    }
}
