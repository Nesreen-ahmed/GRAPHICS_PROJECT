using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody rb;
    float xInput;
    float zInput;
    public float speed;
    float rotation_speed = 100;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {

    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        float xVelocity = xInput * speed;
        float zVelocity = zInput * speed;

        rb.velocity = new Vector3(xVelocity, rb.velocity.y, zVelocity);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -rotation_speed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, rotation_speed * Time.deltaTime, 0));
        }
    }
}