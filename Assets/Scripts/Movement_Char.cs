using System;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class Movement_Char : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private float maxSpeed = 0.1f;
    private Rigidbody2D rb;
    private Vector2 vel = new Vector2(0, 0);


    private void UpdateMovement()
    {


        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

        rb.linearVelocity = vel;
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }
}
