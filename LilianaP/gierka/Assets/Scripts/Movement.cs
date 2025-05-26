using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float vectorX;
    [SerializeField] float vectorY = 0;
    [SerializeField] float vectorZ;
    [SerializeField] float speed = 10;
    [SerializeField] InputAction actionJump;
    Rigidbody rb;

    private void OnEnable()
    {
        actionJump.Enable();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        vectorX = Input.GetAxis("Horizontal");
        vectorZ = Input.GetAxis("Vertical");
        transform.Translate(vectorX * Time.deltaTime * speed, vectorY, vectorZ * Time.deltaTime * speed);

    }
    void FixedUpdate()
    {
        if (actionJump.IsPressed())
        {
            rb.AddForce(Vector3.up * Time.fixedDeltaTime);
        }
        if (!actionJump.IsPressed())
        {
            rb.AddForce(Vector3.down * Time.fixedDeltaTime);
        }
    }
}
