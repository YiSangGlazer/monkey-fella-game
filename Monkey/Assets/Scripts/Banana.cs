using UnityEngine;

public class Banana : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Call the ScoreManager to add points 
            ScoreManager.instance.AddBanana();

            // Destroy the banana object after collection 
            Destroy(gameObject);
        }
    }
}