using System.Collections;
using UnityEngine;

public class FlipDog : MonoBehaviour
{
    public GameObject dog;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(FlipCoroutine());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void Flip()
    {
        animator.SetTrigger("flip");
    }

    IEnumerator FlipCoroutine()
    {
        while (true)
        {
            Vector3 location = transform.position + new Vector3(0, 100, -2);
            Instantiate(dog, location, new Quaternion(0,0,0,0));
            yield return new WaitForSeconds(0.5f);
        }
        
    }
}
