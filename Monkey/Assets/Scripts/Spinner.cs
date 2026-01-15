using UnityEngine;

public class AdvancedSpinner : MonoBehaviour
{
    [Header("Rotation Settings")]
    public Vector3 rotationAxis = Vector3.up;   // Which axis to rotate around
    public float rotationSpeed = 90f;           // Degrees per second

    [Header("Oscillation Settings")]
    public bool useRangeOfMotion = false;       // Toggle oscillation
    public float minAngle = -45f;               // Minimum rotation angle
    public float maxAngle = 45f;                // Maximum rotation angle
    public float oscillationSpeed = 2f;         // How fast it swings

    private float startAngle;

    void Start()
    {
        startAngle = transform.localEulerAngles.y;
    }

    void Update()
    {
        if (!useRangeOfMotion)
        {
            // Continuous rotation
            transform.Rotate(rotationAxis.normalized * rotationSpeed * Time.deltaTime);
        }
        else
        {
            // Oscillating rotation
            float t = (Mathf.Sin(Time.time * oscillationSpeed) + 1f) / 2f; // 0–1
            float angle = Mathf.Lerp(minAngle, maxAngle, t);

            transform.localRotation = Quaternion.AngleAxis(angle, rotationAxis);
        }
    }
}
