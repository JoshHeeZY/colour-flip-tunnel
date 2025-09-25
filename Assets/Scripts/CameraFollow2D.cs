using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;       // player reference
    public float smoothTime = 0.15f;
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (!target) return;

        // Only follow X (lock Y, keep Z as camera's current Z)
        Vector3 goal = new Vector3(target.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.SmoothDamp(transform.position, goal, ref velocity, smoothTime);
    }
}
