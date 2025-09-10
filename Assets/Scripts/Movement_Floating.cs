using UnityEditor.Callbacks;
using UnityEngine;

public class Movement_Floating : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private float speed = 0.5f;
    [SerializeField] private float amp = 0.5f;
    private Rigidbody2D rb;

    private void UpdateMovement()
    {
        rb.linearVelocity = new Vector2(amp * Mathf.Sin(speed * 1.5f * Time.time), amp * Mathf.Sin(speed * Time.time));

    }

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
