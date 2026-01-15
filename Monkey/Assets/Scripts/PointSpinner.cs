using UnityEngine;

public class FanSpinner : MonoBehaviour
{
    [Header("Fan Settings")]
    public float speed = 300f;          // How fast the fan spins (degrees per second)
    public Vector3 axis = Vector3.up;   // Axis of rotation (Y = vertical)

    void Update()
    {
        transform.Rotate(axis.normalized * speed * Time.deltaTime);
    }
}
