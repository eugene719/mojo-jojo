using UnityEngine;

public class ManualTimerDestruction : MonoBehaviour
{
    public float timeLeft = 3f;

    void Update()
    {
        // Time.deltaTime is the time (in seconds) since the last frame
        // We subtract that tiny amount from our timer every frame
        timeLeft -= Time.deltaTime;

        // If the timer hits zero or less, poof!
        if (timeLeft <= 0)
        {
            Destroy(gameObject);
        }
    }
}
