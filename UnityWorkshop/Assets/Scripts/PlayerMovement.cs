using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 45f;
    public float  movementSpeed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * vertical * movementSpeed * Time.deltaTime;
        transform.position += movement;

        gameObject.transform.Rotate(0.0f, rotationSpeed * Time.deltaTime * horizontal, 0.0f);
    }
}
