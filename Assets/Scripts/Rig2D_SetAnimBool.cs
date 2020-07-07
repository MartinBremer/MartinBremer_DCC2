using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rig2D_SetAnimBool : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            animator.SetBool("Walk", true);
        else
            animator.SetBool("Walk", false);
    }
}
