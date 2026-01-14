using System.Collections;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    [SerializeField] GameObject Loc1;
    [SerializeField] GameObject Loc2;
    [SerializeField] float speed = 10f;
    [SerializeField] float delay = 1f;
    [SerializeField] GameObject platform;

    private Vector3 targetPosition;








    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        platform.transform.position = Loc1.transform.position;
        targetPosition = Loc2.transform.position;
        StartCoroutine(MovePlatform());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MovePlatform()
    {
        while (true)
        {
            while ((targetPosition - platform.transform.position).sqrMagnitude > 0.01f)
            {
                platform.transform.position = Vector3.MoveTowards(platform.transform.position, targetPosition, speed * Time.deltaTime);
                yield return null;
            }
            targetPosition = targetPosition == Loc1.transform.position ? Loc2.transform.position : Loc1.transform.position;
            yield return new WaitForSeconds(delay);

        }
    }







}
