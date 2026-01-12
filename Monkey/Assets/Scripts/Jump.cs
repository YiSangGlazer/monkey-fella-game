using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    [SerializeField]
    InputAction jump;


    [SerializeField]
    float jumpForce = 5f;

    Rigidbody rb;






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
            rb = GetComponent<Rigidbody>();

    }


    private void OnEnable()
    {
        jump.Enable();
    }


    private void FixedUpdate()
    {
        if (jump.IsPressed())
        {
            if (gameObject.transform.position.y < 0.166f)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
