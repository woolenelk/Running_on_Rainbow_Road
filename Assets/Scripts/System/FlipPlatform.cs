using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPlatform : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Flipped", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
