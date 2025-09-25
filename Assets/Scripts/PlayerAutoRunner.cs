using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerAutoRunner : MonoBehaviour
{
    public float forwardSpeed = 6f;   // units per second on X
    public float maxY = 4f;           // keep the player inside the frame (optional)
    public float minY = -4f;

    Rigidbody2D rb;

    void Awake() => rb = GetComponent<Rigidbody2D>();

    void FixedUpdate()
    {
        // Constant forward velocity (right)
        Vector2 v = rb.velocity;
        v.x = forwardSpeed;
        rb.velocity = v;

        // Optional: clamp vertical position so it doesn't drift off-screen
        Vector3 p = transform.position;
        p.y = Mathf.Clamp(p.y, minY, maxY);
        transform.position = p;
    }
}
