using UnityEngine;
using System.Collections; // Required for Coroutines

public class TimedDestruction : MonoBehaviour
{
    public float delay = 3f;

    void Start()
    {
        // This starts the countdown as soon as the object is born
        StartCoroutine(DestroyAfterDelay());
    }

    IEnumerator DestroyAfterDelay()
    {
        // The script pauses here for 'delay' seconds
        yield return new WaitForSeconds(delay);
        
        // Then it continues and deletes the object
        Destroy(gameObject);
    }
}