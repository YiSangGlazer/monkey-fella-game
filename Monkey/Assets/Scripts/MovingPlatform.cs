using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public int locationIndex = 0;
    public Transform[] locations;












    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != locations[locationIndex].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, locations[locationIndex].position, 2 * Time.deltaTime);
        }
        else
        {
            if (locationIndex + 1 == locations.Length)
            {
                locationIndex = 0;
            }
            else
            {
                locationIndex++;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = null;
        }
    }





}
