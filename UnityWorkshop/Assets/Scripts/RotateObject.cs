using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public bool isRotating = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            isRotating = !isRotating;
            Debug.Log("Rotation Toggled "+isRotating);
        }

        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            rotationSpeed += 10;
            Debug.Log("Rotation Increase : " + rotationSpeed);
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            rotationSpeed -= 10;
            Debug.Log("Rotation Decrease : " + rotationSpeed);
        }

        if (isRotating)
        {
            gameObject.transform.Rotate(0.0f, rotationSpeed * Time.deltaTime, 0.0f);
        }
    }
}
