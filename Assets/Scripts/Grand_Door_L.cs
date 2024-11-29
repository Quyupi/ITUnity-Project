using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grand_Door_L : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator != null)
        {
            animator.Play("Grand_Door_L");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
