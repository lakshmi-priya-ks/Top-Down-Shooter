using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
{
    rb.linearVelocity = movement * speed;

    // Clamp position inside screen
    float clampedX = Mathf.Clamp(rb.position.x, -8f, 8f);
    float clampedY = Mathf.Clamp(rb.position.y, -4f, 4f);

    rb.position = new Vector2(clampedX, clampedY);
}
}