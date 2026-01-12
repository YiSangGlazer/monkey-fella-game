using UnityEngine;
using UnityEngine.InputSystem;

public class Sphere : MonoBehaviour
{

    public Rigidbody sphere;
    public GameObject cameraX;
    public GameObject cameraY;

    private float moveSpeed = 500f;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 moveDirection;

    private float mouseX;
    private float mouseY;
    private float turnRate = 500f;
    private float lookRate = 500f;
    private float camRotY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void MoveSphere()
    {
        horizontalInput = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        verticalInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        moveDirection = (cameraX.transform.forward * verticalInput) + (cameraX.transform.right * horizontalInput);

        sphere.AddForce(moveDirection);

    }

    void MoveCamera()
    {
        mouseX = Input.GetAxis("Mouse X") * turnRate * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * lookRate * Time.deltaTime;

        cameraX.transform.Rotate(Vector3.up * mouseX);

        camRotY -= mouseY;
        camRotY = Mathf.Clamp(camRotY, -90, 90);
        cameraY.transform.localRotation = Quaternion.Euler(camRotY, 0f, 0f);
        cameraX.transform.position = transform.position;

       

    }



    // Update is called once per frame
    void Update()
    {
        MoveSphere();
        MoveCamera();
 
    }

  
}
